namespace MDIEstudiante
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnForm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnForm3 = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDelEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnForm2,
            this.btnForm3,
            this.promedioDelEstudianteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnForm2
            // 
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(169, 24);
            this.btnForm2.Text = "Ingresar un estudiante";
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(117, 24);
            this.btnForm3.Text = "Ver estudiante";
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // promedioDelEstudianteToolStripMenuItem
            // 
            this.promedioDelEstudianteToolStripMenuItem.Name = "promedioDelEstudianteToolStripMenuItem";
            this.promedioDelEstudianteToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.promedioDelEstudianteToolStripMenuItem.Text = "Promedio del estudiante";
            this.promedioDelEstudianteToolStripMenuItem.Click += new System.EventHandler(this.btnForm4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(746, 457);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnForm2;
        private System.Windows.Forms.ToolStripMenuItem btnForm3;
        private System.Windows.Forms.ToolStripMenuItem promedioDelEstudianteToolStripMenuItem;
    }
}

