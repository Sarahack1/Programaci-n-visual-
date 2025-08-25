using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerproyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = Acceso;
        }
        int fail_tries = 0; 

        private void Acceso_Click(object sender, EventArgs e)
        {
            string correctuser = "admin";
            string correct_passwd = "123as";
            int max_tries = 3;

            string username = usert.Text.ToLower();
            string user_psswd = keypass.Text;

            if (username == correctuser && user_psswd == correct_passwd)
            {
                MessageBox.Show(" * Bienvenido administrador *");
               
                fail_tries = 0;
            }
            else
            {
                fail_tries++;
                int tries_left = max_tries - fail_tries;

                if (fail_tries < max_tries)
                {
                    MessageBox.Show($"Incorrecto, verifique su usuario o contraseña.\nLe quedan {tries_left} intentos más.");
                    usert.Clear();
                    keypass.Clear();
                    usert.Focus();
                }
                else
                {
                    MessageBox.Show("BLOQUEADO\nDemasiados intentos fallidos.");
                    usert.Enabled = false;
                    keypass.Enabled = false;
                }
            }
        }

    }
}

