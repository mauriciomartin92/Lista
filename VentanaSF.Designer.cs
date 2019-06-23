namespace NumerosComplejos
{
    partial class VentanaSF
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
            this.mtxtBoxAmp1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBoxFrecAngF1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBoxFaseF1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBoxAmp2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mtxtBoxFrecAngF2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBoxFaseF2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTipoFasor1 = new System.Windows.Forms.TextBox();
            this.txtBoxTipoFasor2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mtxtBoxAmp1
            // 
            this.mtxtBoxAmp1.Location = new System.Drawing.Point(122, 31);
            this.mtxtBoxAmp1.Mask = "99999";
            this.mtxtBoxAmp1.Name = "mtxtBoxAmp1";
            this.mtxtBoxAmp1.Size = new System.Drawing.Size(39, 20);
            this.mtxtBoxAmp1.TabIndex = 3;
            this.mtxtBoxAmp1.ValidatingType = typeof(int);
            // 
            // mtxtBoxFrecAngF1
            // 
            this.mtxtBoxFrecAngF1.Location = new System.Drawing.Point(238, 31);
            this.mtxtBoxFrecAngF1.Mask = "99999";
            this.mtxtBoxFrecAngF1.Name = "mtxtBoxFrecAngF1";
            this.mtxtBoxFrecAngF1.Size = new System.Drawing.Size(39, 20);
            this.mtxtBoxFrecAngF1.TabIndex = 4;
            this.mtxtBoxFrecAngF1.ValidatingType = typeof(int);
            // 
            // mtxtBoxFaseF1
            // 
            this.mtxtBoxFaseF1.Location = new System.Drawing.Point(290, 31);
            this.mtxtBoxFaseF1.Mask = "99999";
            this.mtxtBoxFaseF1.Name = "mtxtBoxFaseF1";
            this.mtxtBoxFaseF1.Size = new System.Drawing.Size(39, 20);
            this.mtxtBoxFaseF1.TabIndex = 6;
            this.mtxtBoxFaseF1.ValidatingType = typeof(int);
            // 
            // mtxtBoxAmp2
            // 
            this.mtxtBoxAmp2.Location = new System.Drawing.Point(122, 69);
            this.mtxtBoxAmp2.Mask = "99999";
            this.mtxtBoxAmp2.Name = "mtxtBoxAmp2";
            this.mtxtBoxAmp2.Size = new System.Drawing.Size(39, 20);
            this.mtxtBoxAmp2.TabIndex = 7;
            this.mtxtBoxAmp2.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sumar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // mtxtBoxFrecAngF2
            // 
            this.mtxtBoxFrecAngF2.Location = new System.Drawing.Point(238, 69);
            this.mtxtBoxFrecAngF2.Mask = "99999";
            this.mtxtBoxFrecAngF2.Name = "mtxtBoxFrecAngF2";
            this.mtxtBoxFrecAngF2.Size = new System.Drawing.Size(39, 20);
            this.mtxtBoxFrecAngF2.TabIndex = 12;
            this.mtxtBoxFrecAngF2.ValidatingType = typeof(int);
            // 
            // mtxtBoxFaseF2
            // 
            this.mtxtBoxFaseF2.Location = new System.Drawing.Point(290, 69);
            this.mtxtBoxFaseF2.Mask = "99999";
            this.mtxtBoxFaseF2.Name = "mtxtBoxFaseF2";
            this.mtxtBoxFaseF2.Size = new System.Drawing.Size(39, 20);
            this.mtxtBoxFaseF2.TabIndex = 13;
            this.mtxtBoxFaseF2.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amplitudes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo Fasor\r\nSen o Cos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Frec. Ang.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fases";
            // 
            // txtBoxResultado
            // 
            this.txtBoxResultado.Location = new System.Drawing.Point(32, 181);
            this.txtBoxResultado.Name = "txtBoxResultado";
            this.txtBoxResultado.Size = new System.Drawing.Size(268, 20);
            this.txtBoxResultado.TabIndex = 18;
            this.txtBoxResultado.TextChanged += new System.EventHandler(this.TxtBoxResultado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "PRIMER FASOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "SEGUNDO FASOR";
            // 
            // txtBoxTipoFasor1
            // 
            this.txtBoxTipoFasor1.Location = new System.Drawing.Point(175, 31);
            this.txtBoxTipoFasor1.Name = "txtBoxTipoFasor1";
            this.txtBoxTipoFasor1.Size = new System.Drawing.Size(39, 20);
            this.txtBoxTipoFasor1.TabIndex = 21;
            this.txtBoxTipoFasor1.Text = "Sen\r\nCos";
            // 
            // txtBoxTipoFasor2
            // 
            this.txtBoxTipoFasor2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxTipoFasor2.Location = new System.Drawing.Point(175, 69);
            this.txtBoxTipoFasor2.Name = "txtBoxTipoFasor2";
            this.txtBoxTipoFasor2.Size = new System.Drawing.Size(39, 20);
            this.txtBoxTipoFasor2.TabIndex = 23;
            this.txtBoxTipoFasor2.Text = "Sen\r\nCos";
            // 
            // VentanaSF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 225);
            this.Controls.Add(this.txtBoxTipoFasor2);
            this.Controls.Add(this.txtBoxTipoFasor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxResultado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxtBoxFaseF2);
            this.Controls.Add(this.mtxtBoxFrecAngF2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtxtBoxAmp2);
            this.Controls.Add(this.mtxtBoxFaseF1);
            this.Controls.Add(this.mtxtBoxFrecAngF1);
            this.Controls.Add(this.mtxtBoxAmp1);
            this.Name = "VentanaSF";
            this.Text = "Suma de fasores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mtxtBoxAmp1;
        private System.Windows.Forms.MaskedTextBox mtxtBoxFrecAngF1;
        private System.Windows.Forms.MaskedTextBox mtxtBoxFaseF1;
        private System.Windows.Forms.MaskedTextBox mtxtBoxAmp2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtxtBoxFrecAngF2;
        private System.Windows.Forms.MaskedTextBox mtxtBoxFaseF2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxTipoFasor1;
        private System.Windows.Forms.TextBox txtBoxTipoFasor2;
    }
}