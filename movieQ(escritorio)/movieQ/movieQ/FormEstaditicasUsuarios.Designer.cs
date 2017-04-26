namespace movieQ
{
    partial class FormEstadisticasUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadisticasUsuarios));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonVolver = new System.Windows.Forms.ToolStripButton();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonMostrarEstadistica = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButtonVolver});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1030, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Añadir Usuario";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Buscar Usuario";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Eliminar Usuario";
            // 
            // toolStripButtonVolver
            // 
            this.toolStripButtonVolver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonVolver.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonVolver.Image")));
            this.toolStripButtonVolver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonVolver.Name = "toolStripButtonVolver";
            this.toolStripButtonVolver.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonVolver.Text = "Volver";
            this.toolStripButtonVolver.Click += new System.EventHandler(this.toolStripButtonVolver_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelNombre.Location = new System.Drawing.Point(37, 87);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 19);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(140, 84);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(219, 27);
            this.textBoxNombre.TabIndex = 2;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.BackColor = System.Drawing.Color.Transparent;
            this.labelContraseña.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelContraseña.Location = new System.Drawing.Point(37, 142);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(88, 19);
            this.labelContraseña.TabIndex = 3;
            this.labelContraseña.Text = "Contraseña";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(140, 139);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(219, 27);
            this.textBoxContraseña.TabIndex = 4;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.EnableHeadersVisualStyles = false;
            this.dataGridViewUsuarios.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(16, 230);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(593, 180);
            this.dataGridViewUsuarios.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(640, 87);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partidas";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(338, 300);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // buttonMostrarEstadistica
            // 
            this.buttonMostrarEstadistica.BackColor = System.Drawing.Color.Transparent;
            this.buttonMostrarEstadistica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMostrarEstadistica.BackgroundImage")));
            this.buttonMostrarEstadistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMostrarEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMostrarEstadistica.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarEstadistica.Location = new System.Drawing.Point(414, 87);
            this.buttonMostrarEstadistica.Name = "buttonMostrarEstadistica";
            this.buttonMostrarEstadistica.Size = new System.Drawing.Size(168, 33);
            this.buttonMostrarEstadistica.TabIndex = 12;
            this.buttonMostrarEstadistica.Text = "Mostrar Estadística";
            this.buttonMostrarEstadistica.UseVisualStyleBackColor = false;
            this.buttonMostrarEstadistica.Click += new System.EventHandler(this.buttonMostrarEstadistica_Click);
            // 
            // FormEstadisticasUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 422);
            this.Controls.Add(this.buttonMostrarEstadistica);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormEstadisticasUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.ToolStripButton toolStripButtonVolver;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonMostrarEstadistica;
    }
}