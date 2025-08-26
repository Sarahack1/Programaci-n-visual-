using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = Igual_btn;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            calculadoraEncendida = false;
            Pantalla.Enabled = false;  
            Pantalla.Text = "";

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = false;       
                }
            }

            Encender.Enabled = true;   
            Apagar.Enabled = true;      
        }

        string operador = "";
        double num1 = 0;
        double num2 = 0, temporal =0, Memoria=0;
        bool calculadoraEncendida = false;


        private void btnCE_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            Pantalla.Text = "0";
            num1= 0;
            num2= 0;
            operador = "";
        }

        private void btnBA_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            if (Pantalla.TextLength == 1) Pantalla.Text = "0";
            else Pantalla.Text =Pantalla.Text.Substring(0, Pantalla.Text.Length - 1);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            if (Pantalla.Text == "0" ) Pantalla.Text = " ";
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            if (Pantalla.Text == "0") Pantalla.Text = " ";
            Pantalla.Text = Pantalla.Text + "2";
        }


        private void btn_3_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            if (Pantalla.Text == "0") Pantalla.Text = " ";
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            if (Pantalla.Text == "0") Pantalla.Text = " ";
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            if (Pantalla.Text == "0") Pantalla.Text = " ";
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            if (Pantalla.Text == "0") Pantalla.Text = " ";
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            if (Pantalla.Text == "0") Pantalla.Text = " ";
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            if (Pantalla.Text == "0") Pantalla.Text = " ";
            Pantalla.Text = Pantalla.Text + "8";

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            if (Pantalla.Text == "0") Pantalla.Text = " ";
            Pantalla.Text = Pantalla.Text + "9";
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            if (Pantalla.Text == "0") Pantalla.Text = " ";
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void Suna_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            operador = "+";
            num1= Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "0";

        }

        private void Resta_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            operador = "-";
            num1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "0";
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            operador = "*";
            num1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "0";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            operador = "/";
            num1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "0";
        }

        private void Igual_btn_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            num2 = Convert.ToDouble(Pantalla.Text);
            switch (operador)
            {
                case "+":
                    Pantalla.Text = $"{num1 + num2}";
                    break;
                case "-":
                    Pantalla.Text = $"{num1 - num2}";
                    break;
                case "*":
                    Pantalla.Text = $"{num1 * num2}";
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        Pantalla.Text = $"{num1 / num2}";
                    }
                    else Pantalla.Text = "ERROR";
                    break;
                case "√":
                    if (num1 == 0)
                    {
                        Pantalla.Text = $"{Math.Sqrt(num2)}";
                    }
                    else Pantalla.Text = $"{num1 * (Math.Sqrt(num2))}";
                    break;
                case "^":
                    Pantalla.Text = $"{Math.Pow(num1, num2)}";
                    break;
                case "L":

                    if (num2 > 0)
                    {
                        if (num1 == 0)
                        {
                            Pantalla.Text = $"{Math.Log10(num2)}";
                        }
                        else Pantalla.Text = $"{num1 * (Math.Log(num2))}";

                    }
                    else Pantalla.Text = "ERROR";

                     break;

                default:
                    Pantalla.Text = Pantalla.Text;
                break;
            }
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            temporal = Convert.ToDouble(Pantalla.Text);

            if (temporal != 0)
            {
                Pantalla.Text = $"{temporal * Math.E} ";
            }
            else
            {
                Pantalla.Text = Math.E.ToString();
            }
            temporal = 0;
            operador = "e";
        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            temporal = Convert.ToDouble(Pantalla.Text);

            if (temporal != 0)
            {
                Pantalla.Text = $"{temporal * Math.PI} ";
            }
            else
            {
                Pantalla.Text = Math.PI.ToString();
            }
            temporal = 0;
            operador = "P";
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "√";
            }
            else
            {
                num1 = Convert.ToDouble(Pantalla.Text);
            }
            Pantalla.Text = "0";
            operador = "√";
        }

        private void btnExponente_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            num1 = Convert.ToDouble(Pantalla.Text);
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "";
                Pantalla.Text = "^";
 
            }
            else
            {

                Pantalla.Text = "^";
                
            }
            Pantalla.Text = "0";

            operador = "^";
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            num1 = Convert.ToDouble(Pantalla.Text);
            if (Pantalla.Text == "0") {
                Pantalla.Text = " ";
                Pantalla.Text = "Log(";
            }
            else
            {
                Pantalla.Text = Pantalla.Text+ "Log(";

            }
            operador = "L";
           
            Pantalla.Text= "0";
              


        }

        private void Encender_Click(object sender, EventArgs e)
        {
            calculadoraEncendida = true;
            Pantalla.Enabled = true; 
            Pantalla.Text = "0";     

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true; 
                }
            }

            Encender.Enabled = false;       
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            calculadoraEncendida = false;
            Pantalla.Enabled = false;
            Pantalla.Text = "";

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = false;
                }
            }

            Encender.Enabled = true;
            Apagar.Enabled = true;
        }

        private void btm_menos_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            Memoria -= Convert.ToDouble(Pantalla.Text);

        }

        private void btmc_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            Memoria = 0;
        }

        private void btmr_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            if (Pantalla.Text == "0") Pantalla.Text = " ";
            Pantalla.Text = Memoria.ToString() ;
        }

        private void btM_mas_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            Memoria +=Convert.ToDouble(Pantalla.Text);
        }

        private void btn_porcentaje_Click(object sender, EventArgs e)
        {
            if (!calculadoraEncendida) return;
            temporal = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = $"{temporal / 100} ";
            temporal = 0;
            operador = "%";
        }

    }
}
