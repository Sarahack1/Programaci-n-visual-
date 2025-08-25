namespace dia1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.barracontrol = new System.Windows.Forms.TabControl();
            this.Contadordecliks = new System.Windows.Forms.TabPage();
            this.loquehace = new System.Windows.Forms.Label();
            this.clicks = new System.Windows.Forms.Button();
            this.contador = new System.Windows.Forms.Label();
            this.IMC = new System.Windows.Forms.TabPage();
            this.texto = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Button();
            this.altura = new System.Windows.Forms.TextBox();
            this.alturati = new System.Windows.Forms.Label();
            this.pesot = new System.Windows.Forms.TextBox();
            this.Peso = new System.Windows.Forms.Label();
            this.Conversortemp = new System.Windows.Forms.TabPage();
            this.Fahrenheit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcularFahrenheit = new System.Windows.Forms.Button();
            this.Celcius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculacelcius = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.barracontrol.SuspendLayout();
            this.Contadordecliks.SuspendLayout();
            this.IMC.SuspendLayout();
            this.Conversortemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // barracontrol
            // 
            this.barracontrol.Controls.Add(this.Contadordecliks);
            this.barracontrol.Controls.Add(this.IMC);
            this.barracontrol.Controls.Add(this.Conversortemp);
            this.barracontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barracontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barracontrol.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barracontrol.Location = new System.Drawing.Point(0, 0);
            this.barracontrol.Name = "barracontrol";
            this.barracontrol.SelectedIndex = 0;
            this.barracontrol.Size = new System.Drawing.Size(847, 450);
            this.barracontrol.TabIndex = 0;
            // 
            // Contadordecliks
            // 
            this.Contadordecliks.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Contadordecliks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Contadordecliks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contadordecliks.Controls.Add(this.loquehace);
            this.Contadordecliks.Controls.Add(this.clicks);
            this.Contadordecliks.Controls.Add(this.contador);
            this.Contadordecliks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Contadordecliks.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contadordecliks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Contadordecliks.Location = new System.Drawing.Point(4, 26);
            this.Contadordecliks.Name = "Contadordecliks";
            this.Contadordecliks.Padding = new System.Windows.Forms.Padding(3);
            this.Contadordecliks.Size = new System.Drawing.Size(839, 420);
            this.Contadordecliks.TabIndex = 0;
            this.Contadordecliks.Text = "Contador de clicks";
            // 
            // loquehace
            // 
            this.loquehace.AutoSize = true;
            this.loquehace.BackColor = System.Drawing.Color.SeaShell;
            this.loquehace.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loquehace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loquehace.Location = new System.Drawing.Point(314, 220);
            this.loquehace.Name = "loquehace";
            this.loquehace.Size = new System.Drawing.Size(154, 22);
            this.loquehace.TabIndex = 2;
            this.loquehace.Text = "Numero de clicks ";
            // 
            // clicks
            // 
            this.clicks.BackColor = System.Drawing.Color.Linen;
            this.clicks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clicks.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clicks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clicks.Location = new System.Drawing.Point(301, 90);
            this.clicks.Name = "clicks";
            this.clicks.Size = new System.Drawing.Size(191, 109);
            this.clicks.TabIndex = 1;
            this.clicks.Text = "CLICK";
            this.clicks.UseVisualStyleBackColor = false;
            this.clicks.Click += new System.EventHandler(this.clicks_Click);
            // 
            // contador
            // 
            this.contador.AutoSize = true;
            this.contador.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.contador.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contador.Location = new System.Drawing.Point(383, 260);
            this.contador.Name = "contador";
            this.contador.Size = new System.Drawing.Size(24, 25);
            this.contador.TabIndex = 0;
            this.contador.Text = "0";
            // 
            // IMC
            // 
            this.IMC.BackColor = System.Drawing.Color.OldLace;
            this.IMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IMC.Controls.Add(this.texto);
            this.IMC.Controls.Add(this.Resultado);
            this.IMC.Controls.Add(this.altura);
            this.IMC.Controls.Add(this.alturati);
            this.IMC.Controls.Add(this.pesot);
            this.IMC.Controls.Add(this.Peso);
            this.IMC.Location = new System.Drawing.Point(4, 26);
            this.IMC.Name = "IMC";
            this.IMC.Padding = new System.Windows.Forms.Padding(3);
            this.IMC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IMC.Size = new System.Drawing.Size(839, 420);
            this.IMC.TabIndex = 1;
            this.IMC.Text = "IMC";
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.ForeColor = System.Drawing.Color.SaddleBrown;
            this.texto.Location = new System.Drawing.Point(249, 52);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(346, 25);
            this.texto.TabIndex = 5;
            this.texto.Text = "INDICE DE MASA CORPORAL";
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.Color.PapayaWhip;
            this.Resultado.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Resultado.Location = new System.Drawing.Point(346, 268);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(149, 52);
            this.Resultado.TabIndex = 4;
            this.Resultado.Text = "CALCULAR";
            this.Resultado.UseVisualStyleBackColor = false;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // altura
            // 
            this.altura.BackColor = System.Drawing.Color.PapayaWhip;
            this.altura.ForeColor = System.Drawing.SystemColors.MenuText;
            this.altura.Location = new System.Drawing.Point(328, 195);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(227, 25);
            this.altura.TabIndex = 3;
            // 
            // alturati
            // 
            this.alturati.AutoSize = true;
            this.alturati.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.alturati.ForeColor = System.Drawing.Color.SaddleBrown;
            this.alturati.Location = new System.Drawing.Point(190, 201);
            this.alturati.Name = "alturati";
            this.alturati.Size = new System.Drawing.Size(121, 19);
            this.alturati.TabIndex = 2;
            this.alturati.Text = "ALTURA (0.0)m";
            // 
            // pesot
            // 
            this.pesot.BackColor = System.Drawing.Color.PapayaWhip;
            this.pesot.ForeColor = System.Drawing.SystemColors.MenuText;
            this.pesot.Location = new System.Drawing.Point(328, 129);
            this.pesot.Name = "pesot";
            this.pesot.Size = new System.Drawing.Size(227, 25);
            this.pesot.TabIndex = 1;
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Peso.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Peso.Location = new System.Drawing.Point(198, 130);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(113, 19);
            this.Peso.TabIndex = 0;
            this.Peso.Text = "PESO (00.0)kg";
            // 
            // Conversortemp
            // 
            this.Conversortemp.BackColor = System.Drawing.Color.LightCyan;
            this.Conversortemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Conversortemp.Controls.Add(this.Fahrenheit);
            this.Conversortemp.Controls.Add(this.label2);
            this.Conversortemp.Controls.Add(this.CalcularFahrenheit);
            this.Conversortemp.Controls.Add(this.Celcius);
            this.Conversortemp.Controls.Add(this.label1);
            this.Conversortemp.Controls.Add(this.calculacelcius);
            this.Conversortemp.Controls.Add(this.titulo);
            this.Conversortemp.Location = new System.Drawing.Point(4, 26);
            this.Conversortemp.Name = "Conversortemp";
            this.Conversortemp.Size = new System.Drawing.Size(839, 420);
            this.Conversortemp.TabIndex = 2;
            this.Conversortemp.Text = "Conversor de temperatura";
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fahrenheit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fahrenheit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Fahrenheit.Location = new System.Drawing.Point(330, 283);
            this.Fahrenheit.Multiline = true;
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(164, 42);
            this.Fahrenheit.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(177, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "De Fahrenheit";
            // 
            // CalcularFahrenheit
            // 
            this.CalcularFahrenheit.BackColor = System.Drawing.Color.Azure;
            this.CalcularFahrenheit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.CalcularFahrenheit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularFahrenheit.ForeColor = System.Drawing.Color.DarkCyan;
            this.CalcularFahrenheit.Location = new System.Drawing.Point(517, 283);
            this.CalcularFahrenheit.Name = "CalcularFahrenheit";
            this.CalcularFahrenheit.Size = new System.Drawing.Size(141, 42);
            this.CalcularFahrenheit.TabIndex = 10;
            this.CalcularFahrenheit.Text = "a Celcius";
            this.CalcularFahrenheit.UseVisualStyleBackColor = false;
            this.CalcularFahrenheit.Click += new System.EventHandler(this.CalcularFahrenheit_Click);
            // 
            // Celcius
            // 
            this.Celcius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Celcius.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Celcius.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Celcius.Location = new System.Drawing.Point(330, 155);
            this.Celcius.Multiline = true;
            this.Celcius.Name = "Celcius";
            this.Celcius.Size = new System.Drawing.Size(164, 42);
            this.Celcius.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(204, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "De Celcius";
            // 
            // calculacelcius
            // 
            this.calculacelcius.BackColor = System.Drawing.Color.Azure;
            this.calculacelcius.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.calculacelcius.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculacelcius.ForeColor = System.Drawing.Color.DarkCyan;
            this.calculacelcius.Location = new System.Drawing.Point(517, 155);
            this.calculacelcius.Name = "calculacelcius";
            this.calculacelcius.Size = new System.Drawing.Size(141, 43);
            this.calculacelcius.TabIndex = 7;
            this.calculacelcius.Text = "a Fahrenheit";
            this.calculacelcius.UseVisualStyleBackColor = false;
            this.calculacelcius.Click += new System.EventHandler(this.calculacelcius_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.titulo.Location = new System.Drawing.Point(221, 44);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(383, 25);
            this.titulo.TabIndex = 6;
            this.titulo.Text = "CONVERSOR DE TEMPERATURA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.barracontrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.barracontrol.ResumeLayout(false);
            this.Contadordecliks.ResumeLayout(false);
            this.Contadordecliks.PerformLayout();
            this.IMC.ResumeLayout(false);
            this.IMC.PerformLayout();
            this.Conversortemp.ResumeLayout(false);
            this.Conversortemp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl barracontrol;
        private System.Windows.Forms.TabPage Contadordecliks;
        private System.Windows.Forms.TabPage IMC;
        private System.Windows.Forms.TabPage Conversortemp;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.TextBox pesot;
        private System.Windows.Forms.Button Resultado;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.Label alturati;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Button clicks;
        private System.Windows.Forms.Label contador;
        private System.Windows.Forms.Label loquehace;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button calculacelcius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Celcius;
        private System.Windows.Forms.TextBox Fahrenheit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalcularFahrenheit;
    }
}

