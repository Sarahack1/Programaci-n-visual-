
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIEstudiante
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            if (DatosCompartidos.EstudianteActual != null)
            {
                txtCarnet.Text = DatosCompartidos.EstudianteActual.Carnet;
                txtNombre.Text = DatosCompartidos.EstudianteActual.Nombre;

                dgvDatos.Rows.Clear();
                foreach (var asig in DatosCompartidos.EstudianteActual.Asignaturas)
                {
                    dgvDatos.Rows.Add(asig.Nombre, asig.Nota);
                }
            }
            else
            {
                MessageBox.Show("No hay datos de estudiante cargados.");
            }
        }
    }

}
