using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MDIEstudiante
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var form1 = this.MdiParent as Form1;
            if (form1 == null) return;

            var mejores = form1.Estudiantes
                .OrderByDescending(est => est.Promedio) 
                .Take(5)
                .ToList();

            chart1.Series.Clear();
            var serie = new Series("Promedios");
            serie.ChartType = SeriesChartType.Column;

            foreach (var est in mejores)
            {
                serie.Points.AddXY(est.Nombre, est.Promedio);
            }

            chart1.Series.Add(serie);
        }
    }
}
