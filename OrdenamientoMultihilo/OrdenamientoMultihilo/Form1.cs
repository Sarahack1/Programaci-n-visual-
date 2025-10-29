using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Word = Microsoft.Office.Interop.Word;

namespace OrdenamientoParalelo
{
    public partial class Form1 : Form
    {
        private List<int> datos;
        private Thread hiloBubble;
        private Thread hiloMerge;
        private bool cancelar = false;

        public Form1()
        {
            InitializeComponent();
            InicializarChart();
        }
        private StringBuilder sbBurbuja = new StringBuilder();
        private StringBuilder sbQuick = new StringBuilder();
        private StringBuilder sbMerge = new StringBuilder();
        private StringBuilder sbSelection = new StringBuilder();

        private void InicializarChart()
        {
            chartTiempos.Series.Clear();
            chartTiempos.ChartAreas.Clear();

            chartTiempos.ChartAreas.Add(new ChartArea("Area1"));
            chartTiempos.Series.Add("Tiempos");
            chartTiempos.Series["Tiempos"].ChartType = SeriesChartType.Column;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
            {
                Random rnd = new Random();
                datos = new List<int>();
                for (int i = 0; i < cantidad; i++)
                    datos.Add(rnd.Next(0, 10000));

                MessageBox.Show("Datos generados correctamente.");
            }
            else
            {
                MessageBox.Show("Ingrese un número válido de elementos.");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (datos == null || datos.Count == 0)
            {
                MessageBox.Show("Primero genere los datos.");
                return;
            }

            cancelar = false;
            InicializarChart();

            // Hilo 1: Bubble Sort
            hiloBubble = new Thread(() => EjecutarAlgoritmo("BubbleSort", BubbleSort, progressBubble, lblTiempoBubble));
            hiloBubble.Start();

            // Hilo 2: QuickSort (BackgroundWorker)
            BackgroundWorker workerQuick = new BackgroundWorker();
            workerQuick.WorkerReportsProgress = true;
            workerQuick.WorkerSupportsCancellation = true;
            workerQuick.DoWork += (s, ev) => EjecutarAlgoritmo("QuickSort", QuickSortWrapper, progressQuick, lblTiempoQuick);
            workerQuick.RunWorkerAsync();

            // Hilo 3: MergeSort
            hiloMerge = new Thread(() => EjecutarAlgoritmo("MergeSort", MergeSortWrapper, progressMerge, lblTiempoMerge));
            hiloMerge.Start();

            // Hilo 4: SelectionSort
            Thread hiloSelection = new Thread(() => EjecutarAlgoritmo("SelectionSort", SelectionSort, progressSelection, lblTiempoSelection));
            hiloSelection.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            cancelar = true;
            MessageBox.Show("Procesos detenidos.");
        }

        private void EjecutarAlgoritmo(string nombre, Action<List<int>, IProgress<int>> metodo,
                                       ProgressBar barra, Label etiqueta)
        {
            List<int> copia = new List<int>(datos);
            Stopwatch sw = new Stopwatch();
            barra.Invoke((MethodInvoker)(() => barra.Value = 0));
            etiqueta.Invoke((MethodInvoker)(() => etiqueta.Text = $"{nombre}: ejecutando..."));

            Progress<int> progreso = new Progress<int>(valor =>
            {
                if (valor <= 100)
                {
                    if (barra.InvokeRequired)
                        barra.Invoke((MethodInvoker)(() => barra.Value = valor));
                    else
                        barra.Value = valor;
                }
            });

            sw.Start();
            metodo(copia, progreso);
            sw.Stop();

            if (!cancelar)
            {
                etiqueta.Invoke((MethodInvoker)(() =>
                    etiqueta.Text = $"{nombre}: {sw.ElapsedMilliseconds} ms"));
                AgregarTiempoChart(nombre, sw.ElapsedMilliseconds);
                GuardarIteracionesWord(nombre, copia);
            }
        }

        private void AgregarTiempoChart(string algoritmo, long tiempo)
        {
            if (chartTiempos.InvokeRequired)
            {
                chartTiempos.Invoke((MethodInvoker)(() => AgregarTiempoChart(algoritmo, tiempo)));
            }
            else
            {
                chartTiempos.Series["Tiempos"].Points.AddXY(algoritmo, tiempo);
            }
        }

        // -------------------- ALGORITMOS --------------------

        private void BubbleSort(List<int> lista, IProgress<int> progreso)
        {
            int n = lista.Count;
            for (int i = 0; i < n - 1 && !cancelar; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
                progreso.Report((i * 100) / (n - 1));

            }

        }

        private void QuickSortWrapper(List<int> lista, IProgress<int> progreso)
        {
            QuickSort(lista, 0, lista.Count - 1, progreso);
        }

        private void QuickSort(List<int> lista, int izquierda, int derecha, IProgress<int> progreso)
        {
            if (cancelar) return;
            if (izquierda < derecha)
            {
                int pivote = lista[(izquierda + derecha) / 2];
                int i = izquierda, j = derecha;

                while (i <= j)
                {
                    while (lista[i] < pivote) i++;
                    while (lista[j] > pivote) j--;
                    if (i <= j)
                    {
                        int temp = lista[i];
                        lista[i] = lista[j];
                        lista[j] = temp;
                        i++; j--;
                    }
                }

                progreso.Report((int)((izquierda / (float)lista.Count) * 100));
                QuickSort(lista, izquierda, j, progreso);
                QuickSort(lista, i, derecha, progreso);
            }
        }

        private void MergeSortWrapper(List<int> lista, IProgress<int> progreso)
        {
            MergeSort(lista, 0, lista.Count - 1, progreso);
        }

        private void MergeSort(List<int> lista, int izquierda, int derecha, IProgress<int> progreso)
        {
            if (cancelar) return;
            if (izquierda < derecha)
            {
                int medio = (izquierda + derecha) / 2;
                MergeSort(lista, izquierda, medio, progreso);
                MergeSort(lista, medio + 1, derecha, progreso);
                Mezclar(lista, izquierda, medio, derecha);
                progreso.Report((int)((derecha / (float)lista.Count) * 100));
            }
        }

        private void Mezclar(List<int> lista, int izquierda, int medio, int derecha)
        {
            List<int> temp = new List<int>();
            int i = izquierda, j = medio + 1;
            while (i <= medio && j <= derecha)
            {
                if (lista[i] <= lista[j]) temp.Add(lista[i++]);
                else temp.Add(lista[j++]);
            }
            while (i <= medio) temp.Add(lista[i++]);
            while (j <= derecha) temp.Add(lista[j++]);
            for (int k = izquierda; k <= derecha; k++)
                lista[k] = temp[k - izquierda];
        }

        private void SelectionSort(List<int> lista, IProgress<int> progreso)
        {
            int n = lista.Count;
            for (int i = 0; i < n - 1 && !cancelar; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                    if (lista[j] < lista[min]) min = j;

                int temp = lista[min];
                lista[min] = lista[i];
                lista[i] = temp;

                progreso.Report((i * 100) / (n - 1));
            }
        }

        // -------------------- GUARDAR EN WORD --------------------
        private void GuardarIteracionesWord(string algoritmo, List<int> lista)
{
    try
    {
        // Crear la aplicación de Word
        var app = new Word.Application();
        var doc = app.Documents.Add();
        app.Visible = false;

        // Agregar título
        Word.Paragraph titulo = doc.Content.Paragraphs.Add();
        titulo.Range.Text = $"Iteraciones del algoritmo {algoritmo}";
        titulo.Range.Font.Bold = 1;
        titulo.Range.Font.Size = 16;
        titulo.Range.InsertParagraphAfter();

        // Agregar fecha y hora
        Word.Paragraph fecha = doc.Content.Paragraphs.Add();
        fecha.Range.Text = $"Generado el: {DateTime.Now}";
        fecha.Range.Font.Size = 11;
        fecha.Range.InsertParagraphAfter();

        // Agregar los datos ordenados
        Word.Paragraph contenido = doc.Content.Paragraphs.Add();
        contenido.Range.Text = "\nDatos ordenados:\n";
        contenido.Range.Font.Bold = 0;
        contenido.Range.Font.Size = 12;

        // Agregar los números en líneas de 10 por fila para mejor legibilidad
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < lista.Count; i++)
        {
            sb.Append(lista[i].ToString().PadLeft(5));
            if ((i + 1) % 10 == 0)
                sb.AppendLine();
        }

        contenido.Range.InsertAfter(sb.ToString());

        // Guardar el archivo con nombre único
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string path = System.IO.Path.Combine(desktop, $"Iteraciones_{algoritmo}_{DateTime.Now:HHmmss}.docx");

        doc.SaveAs2(path);
        doc.Close();
        app.Quit();

        // Confirmación
        this.Invoke((MethodInvoker)(() =>
            MessageBox.Show($"Archivo guardado en el escritorio:\n{path}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)));
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error al guardar Word ({algoritmo}): {ex.Message}");
    }
}

        // Agrega este método en la clase Form1 para manejar el evento DoWork del BackgroundWorker
        private void backgroundWorkerQuickSort_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Suponiendo que necesitas ordenar la lista 'datos' usando QuickSort en segundo plano
            var progreso = new Progress<int>(porcentaje =>
            {
                // Puedes actualizar la barra de progreso aquí si lo deseas, usando Invoke si es necesario
                if (progressQuick.InvokeRequired)
                {
                    progressQuick.Invoke(new Action(() =>
                    {
                        progressQuick.Value = porcentaje;
                        lblTiempoQuick.Text = $"QuickSort: {porcentaje}%";
                    }));
                }
                else
                {
                    progressQuick.Value = porcentaje;
                    lblTiempoQuick.Text = $"QuickSort: {porcentaje}%";
                }
            });

            // Ejecuta el método de ordenamiento
            QuickSortWrapper(new List<int>(datos), progreso);
        }
        // Agrega este método en la clase Form1 para manejar el evento ProgressChanged del BackgroundWorker
        private void backgroundWorkerQuickSort_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressQuick.Value = e.ProgressPercentage;
            lblTiempoQuick.Text = $"QuickSort: {e.ProgressPercentage}%";
        }

        // Agrega este método en la clase Form1 para manejar el evento RunWorkerCompleted del BackgroundWorker
        private void backgroundWorkerQuickSort_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            lblTiempoQuick.Text = "QuickSort: 100%";
            progressQuick.Value = 100;
            // Aquí puedes agregar lógica adicional si lo deseas, como mostrar el tiempo de ejecución
        }
    }
}
