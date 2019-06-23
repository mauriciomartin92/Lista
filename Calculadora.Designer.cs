namespace NumerosComplejos
{
    partial class Calculadora
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
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.btnPasajes = new System.Windows.Forms.Button();
            this.btnSumaFasores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.Location = new System.Drawing.Point(66, 30);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(114, 47);
            this.btnOperaciones.TabIndex = 0;
            this.btnOperaciones.Text = "Operaciones";
            this.btnOperaciones.UseVisualStyleBackColor = true;
            this.btnOperaciones.Click += new System.EventHandler(this.BtnOperaciones_Click);
            // 
            // btnPasajes
            // 
            this.btnPasajes.Location = new System.Drawing.Point(66, 104);
            this.btnPasajes.Name = "btnPasajes";
            this.btnPasajes.Size = new System.Drawing.Size(114, 47);
            this.btnPasajes.TabIndex = 1;
            this.btnPasajes.Text = "Pasajes";
            this.btnPasajes.UseVisualStyleBackColor = true;
            this.btnPasajes.Click += new System.EventHandler(this.BtnPasajes_Click);
            // 
            // btnSumaFasores
            // 
            this.btnSumaFasores.Location = new System.Drawing.Point(66, 177);
            this.btnSumaFasores.Name = "btnSumaFasores";
            this.btnSumaFasores.Size = new System.Drawing.Size(114, 47);
            this.btnSumaFasores.TabIndex = 2;
            this.btnSumaFasores.Text = "SumaFasores";
            this.btnSumaFasores.UseVisualStyleBackColor = true;
            this.btnSumaFasores.Click += new System.EventHandler(this.BtnSumaFasores_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 257);
            this.Controls.Add(this.btnSumaFasores);
            this.Controls.Add(this.btnPasajes);
            this.Controls.Add(this.btnOperaciones);
            this.Name = "Calculadora";
            this.Text = " CalculadoraComplejos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOperaciones;
        private System.Windows.Forms.Button btnPasajes;
        private System.Windows.Forms.Button btnSumaFasores;
    }
}

