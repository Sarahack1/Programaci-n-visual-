using System;
using System.Linq;
using System.Windows.Forms;

namespace MDIEstudiante
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante
            {
                Carnet = txtCarnet.Text,
                Nombre = txtNombre.Text
            };

            foreach (DataGridViewRow fila in dgvAsignaturas.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[1].Value != null)
                {
                    estudiante.Asignaturas.Add(new Asignatura
                    {
                        Nombre = fila.Cells[0].Value.ToString(),
                        Nota = Convert.ToDouble(fila.Cells[1].Value)
                    });
                }
            }

            // Calcular el promedio
            estudiante.Promedio = estudiante.Asignaturas.Count > 0
                ? estudiante.Asignaturas.Average(a => a.Nota)
                : 0;

            DatosCompartidos.EstudianteActual = estudiante;

            // Agregar el estudiante a la lista de Form1
            var form1 = this.MdiParent as Form1;
            if (form1 != null)
            {
                form1.Estudiantes.Add(estudiante);
            }

            MessageBox.Show("Datos guardados correctamente");
            this.Close();
        }
    }
}
