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

    public partial class Form1 : Form
    {
        public List<Estudiante> Estudiantes { get; private set; } = new List<Estudiante>();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form form2 = this.MdiChildren.FirstOrDefault(f => f is Form2);
            if (form2 == null)
            {
                form2 = new Form2();
                form2.MdiParent = this;
                form2.Show();
            }
            else
            {
                form2.Activate();
            }
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form form3 = this.MdiChildren.FirstOrDefault(f => f is Form3);
            if (form3 == null)
            {
                form3 = new Form3();
                form3.MdiParent = this;
                form3.Show();
            }
            else
            {
                form3.Activate();
            }
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            Form form4 = this.MdiChildren.FirstOrDefault(f => f is Form4);
            if (form4 == null)
            {
                form4 = new Form4();
                form4.MdiParent = this;
                form4.Show();
            }
            else
            {
                form4.Activate();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
