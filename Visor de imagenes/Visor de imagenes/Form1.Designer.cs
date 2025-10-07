namespace Visor_de_imagenes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNormal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEscalaGrises = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCentrada = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAjustada = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZoom = new System.Windows.Forms.ToolStripButton();
            this.comboBoxImagenes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkNormal = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.girar90ALaIzquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girar90ALaDerechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbCentrada = new System.Windows.Forms.RadioButton();
            this.rbAjustar = new System.Windows.Forms.RadioButton();
            this.rbZoom = new System.Windows.Forms.RadioButton();
            this.chkEscalaGrises = new System.Windows.Forms.CheckBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.groupBoxVISION = new System.Windows.Forms.GroupBox();
            this.groupBoxTamano = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxVISION.SuspendLayout();
            this.groupBoxTamano.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.visionToolStripMenuItem,
            this.tamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo&";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.CheckedChanged += new System.EventHandler(this.salirToolStripMenuItem_Click);
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // visionToolStripMenuItem
            // 
            this.visionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.escalaDeGrisesToolStripMenuItem});
            this.visionToolStripMenuItem.Name = "visionToolStripMenuItem";
            this.visionToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.visionToolStripMenuItem.Text = "Vision&";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.escalaDeGrisesToolStripMenuItem.Text = "Escala de grises";
            this.escalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click);
            // 
            // tamaToolStripMenuItem
            // 
            this.tamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centradaToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.ajustadaToolStripMenuItem});
            this.tamaToolStripMenuItem.Name = "tamaToolStripMenuItem";
            this.tamaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.tamaToolStripMenuItem.Text = "Tamaño&";
            // 
            // centradaToolStripMenuItem
            // 
            this.centradaToolStripMenuItem.Name = "centradaToolStripMenuItem";
            this.centradaToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.centradaToolStripMenuItem.Text = "Centrada";
            this.centradaToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonCentrada_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.zoomToolStripMenuItem.Text = "zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonZoom_Click);
            // 
            // ajustadaToolStripMenuItem
            // 
            this.ajustadaToolStripMenuItem.Name = "ajustadaToolStripMenuItem";
            this.ajustadaToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ajustadaToolStripMenuItem.Text = "Ajustada";
            this.ajustadaToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonAjustada_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Thistle;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNormal,
            this.toolStripButtonEscalaGrises,
            this.toolStripButtonCentrada,
            this.toolStripButtonAjustada,
            this.toolStripButtonZoom});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNormal
            // 
            this.toolStripButtonNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNormal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNormal.Image")));
            this.toolStripButtonNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNormal.Name = "toolStripButtonNormal";
            this.toolStripButtonNormal.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonNormal.Text = "toolStripButton1";
            this.toolStripButtonNormal.Click += new System.EventHandler(this.toolStripButtonNormal_Click);
            // 
            // toolStripButtonEscalaGrises
            // 
            this.toolStripButtonEscalaGrises.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEscalaGrises.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEscalaGrises.Image")));
            this.toolStripButtonEscalaGrises.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEscalaGrises.Name = "toolStripButtonEscalaGrises";
            this.toolStripButtonEscalaGrises.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonEscalaGrises.Text = "toolStripButton2";
            this.toolStripButtonEscalaGrises.Click += new System.EventHandler(this.toolStripButtonEscalaGrises_Click);
            // 
            // toolStripButtonCentrada
            // 
            this.toolStripButtonCentrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCentrada.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCentrada.Image")));
            this.toolStripButtonCentrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCentrada.Name = "toolStripButtonCentrada";
            this.toolStripButtonCentrada.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonCentrada.Text = "toolStripButton3";
            this.toolStripButtonCentrada.Click += new System.EventHandler(this.toolStripButtonCentrada_Click);
            // 
            // toolStripButtonAjustada
            // 
            this.toolStripButtonAjustada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAjustada.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAjustada.Image")));
            this.toolStripButtonAjustada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAjustada.Name = "toolStripButtonAjustada";
            this.toolStripButtonAjustada.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonAjustada.Text = "toolStripButton4";
            this.toolStripButtonAjustada.Click += new System.EventHandler(this.toolStripButtonAjustada_Click);
            // 
            // toolStripButtonZoom
            // 
            this.toolStripButtonZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZoom.Image")));
            this.toolStripButtonZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoom.Name = "toolStripButtonZoom";
            this.toolStripButtonZoom.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonZoom.Text = "toolStripButton5";
            this.toolStripButtonZoom.Click += new System.EventHandler(this.toolStripButtonZoom_Click);
            // 
            // comboBoxImagenes
            // 
            this.comboBoxImagenes.FormattingEnabled = true;
            this.comboBoxImagenes.Location = new System.Drawing.Point(325, 189);
            this.comboBoxImagenes.Name = "comboBoxImagenes";
            this.comboBoxImagenes.Size = new System.Drawing.Size(159, 24);
            this.comboBoxImagenes.TabIndex = 2;
            this.comboBoxImagenes.SelectedIndexChanged += new System.EventHandler(this.comboBoxImagenes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imagen actual";
            // 
            // chkNormal
            // 
            this.chkNormal.AutoSize = true;
            this.chkNormal.Location = new System.Drawing.Point(84, 45);
            this.chkNormal.Name = "chkNormal";
            this.chkNormal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkNormal.Size = new System.Drawing.Size(73, 20);
            this.chkNormal.TabIndex = 5;
            this.chkNormal.Text = "Normal";
            this.chkNormal.UseVisualStyleBackColor = true;
            this.chkNormal.CheckedChanged += new System.EventHandler(this.chkNormal_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Thistle;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 16);
            // 
            // pictureBox
            // 
            this.pictureBox.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox.Location = new System.Drawing.Point(188, 219);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(424, 195);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girar90ALaIzquierdaToolStripMenuItem,
            this.girar90ALaDerechaToolStripMenuItem,
            this.copiarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(231, 76);
            // 
            // girar90ALaIzquierdaToolStripMenuItem
            // 
            this.girar90ALaIzquierdaToolStripMenuItem.Name = "girar90ALaIzquierdaToolStripMenuItem";
            this.girar90ALaIzquierdaToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.girar90ALaIzquierdaToolStripMenuItem.Text = "Girar 90\' a la izquierda";
            this.girar90ALaIzquierdaToolStripMenuItem.Click += new System.EventHandler(this.rotarIzquierdaToolStripMenuItem_Click);
            // 
            // girar90ALaDerechaToolStripMenuItem
            // 
            this.girar90ALaDerechaToolStripMenuItem.Name = "girar90ALaDerechaToolStripMenuItem";
            this.girar90ALaDerechaToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.girar90ALaDerechaToolStripMenuItem.Text = "Girar 90\' a la derecha";
            this.girar90ALaDerechaToolStripMenuItem.Click += new System.EventHandler(this.rotarDerechaToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.copiarToolStripMenuItem.Text = "Copiar al portapapeles";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // rbCentrada
            // 
            this.rbCentrada.AutoSize = true;
            this.rbCentrada.Location = new System.Drawing.Point(18, 36);
            this.rbCentrada.Name = "rbCentrada";
            this.rbCentrada.Size = new System.Drawing.Size(83, 20);
            this.rbCentrada.TabIndex = 9;
            this.rbCentrada.TabStop = true;
            this.rbCentrada.Text = "Centrada";
            this.rbCentrada.UseVisualStyleBackColor = true;
            this.rbCentrada.CheckedChanged += new System.EventHandler(this.rbCentrada_CheckedChanged);
            // 
            // rbAjustar
            // 
            this.rbAjustar.AutoSize = true;
            this.rbAjustar.Location = new System.Drawing.Point(18, 71);
            this.rbAjustar.Name = "rbAjustar";
            this.rbAjustar.Size = new System.Drawing.Size(81, 20);
            this.rbAjustar.TabIndex = 10;
            this.rbAjustar.TabStop = true;
            this.rbAjustar.Text = "Ajustada";
            this.rbAjustar.UseVisualStyleBackColor = true;
            this.rbAjustar.CheckedChanged += new System.EventHandler(this.rbAjustar_CheckedChanged);
            // 
            // rbZoom
            // 
            this.rbZoom.AutoSize = true;
            this.rbZoom.Location = new System.Drawing.Point(18, 107);
            this.rbZoom.Name = "rbZoom";
            this.rbZoom.Size = new System.Drawing.Size(63, 20);
            this.rbZoom.TabIndex = 11;
            this.rbZoom.TabStop = true;
            this.rbZoom.Text = "Zoom";
            this.rbZoom.UseVisualStyleBackColor = true;
            this.rbZoom.CheckedChanged += new System.EventHandler(this.rbZoom_CheckedChanged);
            // 
            // chkEscalaGrises
            // 
            this.chkEscalaGrises.AutoSize = true;
            this.chkEscalaGrises.Location = new System.Drawing.Point(339, 46);
            this.chkEscalaGrises.Name = "chkEscalaGrises";
            this.chkEscalaGrises.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkEscalaGrises.Size = new System.Drawing.Size(130, 20);
            this.chkEscalaGrises.TabIndex = 13;
            this.chkEscalaGrises.Text = "Escala de grises";
            this.chkEscalaGrises.UseVisualStyleBackColor = true;
            this.chkEscalaGrises.CheckedChanged += new System.EventHandler(this.chkEscalaGrises_CheckedChanged);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.Plum;
            this.btnPrimero.FlatAppearance.BorderSize = 0;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrimero.Location = new System.Drawing.Point(100, 431);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(124, 30);
            this.btnPrimero.TabIndex = 14;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Plum;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnterior.Location = new System.Drawing.Point(256, 431);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(124, 30);
            this.btnAnterior.TabIndex = 15;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Plum;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSiguiente.Location = new System.Drawing.Point(414, 431);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(124, 30);
            this.btnSiguiente.TabIndex = 16;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.Plum;
            this.btnUltimo.FlatAppearance.BorderSize = 0;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUltimo.Location = new System.Drawing.Point(568, 431);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(124, 30);
            this.btnUltimo.TabIndex = 17;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // groupBoxVISION
            // 
            this.groupBoxVISION.Controls.Add(this.chkEscalaGrises);
            this.groupBoxVISION.Controls.Add(this.chkNormal);
            this.groupBoxVISION.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxVISION.Location = new System.Drawing.Point(35, 73);
            this.groupBoxVISION.Name = "groupBoxVISION";
            this.groupBoxVISION.Size = new System.Drawing.Size(556, 91);
            this.groupBoxVISION.TabIndex = 18;
            this.groupBoxVISION.TabStop = false;
            this.groupBoxVISION.Text = "Vision";
            // 
            // groupBoxTamano
            // 
            this.groupBoxTamano.Controls.Add(this.rbAjustar);
            this.groupBoxTamano.Controls.Add(this.rbCentrada);
            this.groupBoxTamano.Controls.Add(this.rbZoom);
            this.groupBoxTamano.Location = new System.Drawing.Point(639, 73);
            this.groupBoxTamano.Name = "groupBoxTamano";
            this.groupBoxTamano.Size = new System.Drawing.Size(128, 140);
            this.groupBoxTamano.TabIndex = 19;
            this.groupBoxTamano.TabStop = false;
            this.groupBoxTamano.Text = "Tamaño";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.groupBoxTamano);
            this.Controls.Add(this.groupBoxVISION);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxImagenes);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxVISION.ResumeLayout(false);
            this.groupBoxVISION.PerformLayout();
            this.groupBoxTamano.ResumeLayout(false);
            this.groupBoxTamano.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustadaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNormal;
        private System.Windows.Forms.ToolStripButton toolStripButtonEscalaGrises;
        private System.Windows.Forms.ToolStripButton toolStripButtonCentrada;
        private System.Windows.Forms.ToolStripButton toolStripButtonAjustada;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoom;
        private System.Windows.Forms.ComboBox comboBoxImagenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkNormal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton rbCentrada;
        private System.Windows.Forms.RadioButton rbAjustar;
        private System.Windows.Forms.RadioButton rbZoom;
        private System.Windows.Forms.CheckBox chkEscalaGrises;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.GroupBox groupBoxVISION;
        private System.Windows.Forms.GroupBox groupBoxTamano;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girar90ALaIzquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girar90ALaDerechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
    }
}

