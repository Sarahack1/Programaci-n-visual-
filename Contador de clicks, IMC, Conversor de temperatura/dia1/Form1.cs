using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dia1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sumador = 0;
        private void Resultado_Click(object sender, EventArgs e)
        { 
            double peso, Altura;
            peso = double.Parse(pesot.Text);
            Altura = double.Parse(altura.Text);
            double resultado= peso/(Altura*Altura);

            if (resultado <16)
            {
                MessageBox.Show(" Delgadez muy severa ");
            }
            else if (resultado >= 16 && resultado<18.5)
            {
                MessageBox.Show(" Peso bajo ");
            }
            else if (resultado >= 18.5 && resultado < 25)
            {
                MessageBox.Show(" Peso Saludable ");
            }
            else if (resultado >=25 && resultado < 30)
            {
                MessageBox.Show(" Sobre peso ");
            }
            else if (resultado >= 30 && resultado <35)
            {
                MessageBox.Show(" Obesidad moderada ");
            }
            else
            {
                MessageBox.Show("Obesidad severa ");
            }
             Close();
        }

        private void clicks_Click(object sender, EventArgs e)
        {
            sumador++;
            contador.Text = sumador.ToString();
        }

        private void calculacelcius_Click(object sender, EventArgs e)
        { 

            if (!double.TryParse(Celcius.Text, out double celcs))
            {
                MessageBox.Show("Por favor ingrese un número válido.");
                Celcius.Clear();
                return;
            }

            double fare= (celcs * 1.8) + 32;
            MessageBox.Show(fare.ToString());

        }

        private void CalcularFahrenheit_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(Fahrenheit.Text, out double fare))
            {
                MessageBox.Show("Por favor ingrese un número válido.");
                Fahrenheit.Clear();
                return;
            }

            double cels = (fare - 32) *(5.0/9.0);
            MessageBox.Show(cels.ToString());

        }
    }
}
