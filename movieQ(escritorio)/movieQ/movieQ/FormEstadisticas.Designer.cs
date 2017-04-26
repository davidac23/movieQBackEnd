namespace movieQ
{
    partial class FormEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadisticas));
            this.buttonEstadisticasUsuarios = new System.Windows.Forms.Button();
            this.buttonPartida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEstadisticasUsuarios
            // 
            this.buttonEstadisticasUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.buttonEstadisticasUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEstadisticasUsuarios.BackgroundImage")));
            this.buttonEstadisticasUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEstadisticasUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEstadisticasUsuarios.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstadisticasUsuarios.Location = new System.Drawing.Point(44, 113);
            this.buttonEstadisticasUsuarios.Name = "buttonEstadisticasUsuarios";
            this.buttonEstadisticasUsuarios.Size = new System.Drawing.Size(168, 33);
            this.buttonEstadisticasUsuarios.TabIndex = 8;
            this.buttonEstadisticasUsuarios.Text = "Estadísticas usuarios";
            this.buttonEstadisticasUsuarios.UseVisualStyleBackColor = false;
            this.buttonEstadisticasUsuarios.Click += new System.EventHandler(this.buttonEstadisticasUsuarios_Click);
            // 
            // buttonPartida
            // 
            this.buttonPartida.BackColor = System.Drawing.Color.Transparent;
            this.buttonPartida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPartida.BackgroundImage")));
            this.buttonPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPartida.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPartida.Location = new System.Drawing.Point(44, 211);
            this.buttonPartida.Name = "buttonPartida";
            this.buttonPartida.Size = new System.Drawing.Size(168, 33);
            this.buttonPartida.TabIndex = 9;
            this.buttonPartida.Text = "Estadísticas partida";
            this.buttonPartida.UseVisualStyleBackColor = false;
            this.buttonPartida.Click += new System.EventHandler(this.buttonPartida_Click);
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 410);
            this.Controls.Add(this.buttonPartida);
            this.Controls.Add(this.buttonEstadisticasUsuarios);
            this.Name = "FormEstadisticas";
            this.Text = "FormEstadisticas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEstadisticasUsuarios;
        private System.Windows.Forms.Button buttonPartida;
    }
}