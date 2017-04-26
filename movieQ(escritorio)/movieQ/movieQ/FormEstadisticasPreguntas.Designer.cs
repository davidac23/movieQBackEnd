namespace movieQ
{
    partial class FormEstadisticasPreguntas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadisticasPreguntas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonMostrarEstadistica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(315, -4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Preguntas";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // buttonMostrarEstadistica
            // 
            this.buttonMostrarEstadistica.BackColor = System.Drawing.Color.Transparent;
            this.buttonMostrarEstadistica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMostrarEstadistica.BackgroundImage")));
            this.buttonMostrarEstadistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMostrarEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMostrarEstadistica.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarEstadistica.Location = new System.Drawing.Point(39, 40);
            this.buttonMostrarEstadistica.Name = "buttonMostrarEstadistica";
            this.buttonMostrarEstadistica.Size = new System.Drawing.Size(174, 33);
            this.buttonMostrarEstadistica.TabIndex = 8;
            this.buttonMostrarEstadistica.Text = "Mostrar estadística";
            this.buttonMostrarEstadistica.UseVisualStyleBackColor = false;
            this.buttonMostrarEstadistica.Click += new System.EventHandler(this.buttonMostrarEstadistica_Click);
            // 
            // FormEstadisticasPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 322);
            this.Controls.Add(this.buttonMostrarEstadistica);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEstadisticasPreguntas";
            this.Text = "FormEstadisticasPreguntas";
            this.Load += new System.EventHandler(this.FormEstadisticasPreguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonMostrarEstadistica;
    }
}