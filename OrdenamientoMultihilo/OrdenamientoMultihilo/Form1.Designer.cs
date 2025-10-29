namespace OrdenamientoParalelo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.progressBubble = new System.Windows.Forms.ProgressBar();
            this.progressQuick = new System.Windows.Forms.ProgressBar();
            this.lblTiempoBubble = new System.Windows.Forms.Label();
            this.lblTiempoQuick = new System.Windows.Forms.Label();
            this.backgroundWorkerQuickSort = new System.ComponentModel.BackgroundWorker();
            this.chartTiempos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDetener = new System.Windows.Forms.Button();
            this.lblTiempoMerge = new System.Windows.Forms.Label();
            this.progressMerge = new System.Windows.Forms.ProgressBar();
            this.lblTiempoSelection = new System.Windows.Forms.Label();
            this.progressSelection = new System.Windows.Forms.ProgressBar();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.SeaShell;
            this.btnGenerar.Location = new System.Drawing.Point(37, 406);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(218, 40);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Datos";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.SeaShell;
            this.btnIniciar.Location = new System.Drawing.Point(350, 406);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(218, 40);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar Ordenamiento";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // progressBubble
            // 
            this.progressBubble.BackColor = System.Drawing.Color.SaddleBrown;
            this.progressBubble.ForeColor = System.Drawing.Color.PeachPuff;
            this.progressBubble.Location = new System.Drawing.Point(37, 76);
            this.progressBubble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBubble.Name = "progressBubble";
            this.progressBubble.Size = new System.Drawing.Size(261, 50);
            this.progressBubble.TabIndex = 2;
            // 
            // progressQuick
            // 
            this.progressQuick.BackColor = System.Drawing.Color.SaddleBrown;
            this.progressQuick.ForeColor = System.Drawing.Color.PeachPuff;
            this.progressQuick.Location = new System.Drawing.Point(390, 76);
            this.progressQuick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressQuick.Name = "progressQuick";
            this.progressQuick.Size = new System.Drawing.Size(261, 50);
            this.progressQuick.TabIndex = 3;
            // 
            // lblTiempoBubble
            // 
            this.lblTiempoBubble.AutoSize = true;
            this.lblTiempoBubble.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoBubble.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTiempoBubble.Location = new System.Drawing.Point(33, 152);
            this.lblTiempoBubble.Name = "lblTiempoBubble";
            this.lblTiempoBubble.Size = new System.Drawing.Size(85, 23);
            this.lblTiempoBubble.TabIndex = 4;
            this.lblTiempoBubble.Text = "Burbuja:";
            // 
            // lblTiempoQuick
            // 
            this.lblTiempoQuick.AutoSize = true;
            this.lblTiempoQuick.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoQuick.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTiempoQuick.Location = new System.Drawing.Point(386, 152);
            this.lblTiempoQuick.Name = "lblTiempoQuick";
            this.lblTiempoQuick.Size = new System.Drawing.Size(104, 23);
            this.lblTiempoQuick.TabIndex = 5;
            this.lblTiempoQuick.Text = "QuickSort:";
            // 
            // backgroundWorkerQuickSort
            // 
            this.backgroundWorkerQuickSort.WorkerReportsProgress = true;
            this.backgroundWorkerQuickSort.WorkerSupportsCancellation = true;
            this.backgroundWorkerQuickSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerQuickSort_DoWork);
            this.backgroundWorkerQuickSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerQuickSort_ProgressChanged);
            this.backgroundWorkerQuickSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerQuickSort_RunWorkerCompleted);
            // 
            // chartTiempos
            // 
            this.chartTiempos.BackColor = System.Drawing.Color.SaddleBrown;
            this.chartTiempos.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chartTiempos.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartTiempos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTiempos.Legends.Add(legend1);
            this.chartTiempos.Location = new System.Drawing.Point(721, 76);
            this.chartTiempos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartTiempos.Name = "chartTiempos";
            this.chartTiempos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTiempos.Series.Add(series1);
            this.chartTiempos.Size = new System.Drawing.Size(466, 286);
            this.chartTiempos.TabIndex = 6;
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.ForeColor = System.Drawing.Color.SeaShell;
            this.btnDetener.Location = new System.Drawing.Point(674, 406);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(218, 40);
            this.btnDetener.TabIndex = 7;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // lblTiempoMerge
            // 
            this.lblTiempoMerge.AutoSize = true;
            this.lblTiempoMerge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoMerge.ForeColor = System.Drawing.Color.Sienna;
            this.lblTiempoMerge.Location = new System.Drawing.Point(33, 307);
            this.lblTiempoMerge.Name = "lblTiempoMerge";
            this.lblTiempoMerge.Size = new System.Drawing.Size(102, 23);
            this.lblTiempoMerge.TabIndex = 8;
            this.lblTiempoMerge.Text = "MergeSort";
            // 
            // progressMerge
            // 
            this.progressMerge.BackColor = System.Drawing.Color.SaddleBrown;
            this.progressMerge.ForeColor = System.Drawing.Color.Chocolate;
            this.progressMerge.Location = new System.Drawing.Point(37, 232);
            this.progressMerge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressMerge.Name = "progressMerge";
            this.progressMerge.Size = new System.Drawing.Size(261, 50);
            this.progressMerge.TabIndex = 9;
            // 
            // lblTiempoSelection
            // 
            this.lblTiempoSelection.AutoSize = true;
            this.lblTiempoSelection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoSelection.ForeColor = System.Drawing.Color.Sienna;
            this.lblTiempoSelection.Location = new System.Drawing.Point(386, 307);
            this.lblTiempoSelection.Name = "lblTiempoSelection";
            this.lblTiempoSelection.Size = new System.Drawing.Size(123, 23);
            this.lblTiempoSelection.TabIndex = 10;
            this.lblTiempoSelection.Text = "SelectionSort";
            // 
            // progressSelection
            // 
            this.progressSelection.BackColor = System.Drawing.Color.SaddleBrown;
            this.progressSelection.ForeColor = System.Drawing.Color.Chocolate;
            this.progressSelection.Location = new System.Drawing.Point(390, 232);
            this.progressSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressSelection.Name = "progressSelection";
            this.progressSelection.Size = new System.Drawing.Size(261, 50);
            this.progressSelection.TabIndex = 11;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCantidad.Location = new System.Drawing.Point(477, 21);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(208, 23);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad de elementos:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.OldLace;
            this.txtCantidad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtCantidad.Location = new System.Drawing.Point(691, 22);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 25);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.Text = "(vacio)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1218, 477);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.progressSelection);
            this.Controls.Add(this.lblTiempoSelection);
            this.Controls.Add(this.progressMerge);
            this.Controls.Add(this.lblTiempoMerge);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.chartTiempos);
            this.Controls.Add(this.lblTiempoQuick);
            this.Controls.Add(this.lblTiempoBubble);
            this.Controls.Add(this.progressQuick);
            this.Controls.Add(this.progressBubble);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnGenerar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ProgressBar progressBubble;
        private System.Windows.Forms.ProgressBar progressQuick;
        private System.Windows.Forms.Label lblTiempoBubble;
        private System.Windows.Forms.Label lblTiempoQuick;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQuickSort;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTiempos;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label lblTiempoMerge;
        private System.Windows.Forms.ProgressBar progressMerge;
        private System.Windows.Forms.Label lblTiempoSelection;
        private System.Windows.Forms.ProgressBar progressSelection;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}

