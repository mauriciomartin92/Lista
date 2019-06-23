namespace NumerosComplejos
{
    partial class VentanaOperaciones
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
            this.components = new System.ComponentModel.Container();
            this.txtBoxRe1 = new System.Windows.Forms.TextBox();
            this.txtBoxIm1 = new System.Windows.Forms.TextBox();
            this.txtBoxRe2 = new System.Windows.Forms.TextBox();
            this.txtBoxIm2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxResultado = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxRe1
            // 
            this.txtBoxRe1.Location = new System.Drawing.Point(10, 48);
            this.txtBoxRe1.Name = "txtBoxRe1";
            this.txtBoxRe1.Size = new System.Drawing.Size(56, 20);
            this.txtBoxRe1.TabIndex = 0;
            // 
            // txtBoxIm1
            // 
            this.txtBoxIm1.Location = new System.Drawing.Point(72, 48);
            this.txtBoxIm1.Name = "txtBoxIm1";
            this.txtBoxIm1.Size = new System.Drawing.Size(56, 20);
            this.txtBoxIm1.TabIndex = 1;
            // 
            // txtBoxRe2
            // 
            this.txtBoxRe2.Location = new System.Drawing.Point(134, 48);
            this.txtBoxRe2.Name = "txtBoxRe2";
            this.txtBoxRe2.Size = new System.Drawing.Size(56, 20);
            this.txtBoxRe2.TabIndex = 2;
            // 
            // txtBoxIm2
            // 
            this.txtBoxIm2.Location = new System.Drawing.Point(196, 48);
            this.txtBoxIm2.Name = "txtBoxIm2";
            this.txtBoxIm2.Size = new System.Drawing.Size(56, 20);
            this.txtBoxIm2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Re1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Im1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Re2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Im2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese dos numeros complejos";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(10, 117);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(56, 23);
            this.btnSuma.TabIndex = 9;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(134, 117);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(56, 23);
            this.btnResta.TabIndex = 10;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(72, 117);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(56, 23);
            this.btnMult.TabIndex = 11;
            this.btnMult.Text = "Mult";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(196, 117);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(56, 23);
            this.btnDiv.TabIndex = 12;
            this.btnDiv.Text = "Div";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Resultado";
            // 
            // txtBoxResultado
            // 
            this.txtBoxResultado.Location = new System.Drawing.Point(14, 193);
            this.txtBoxResultado.Name = "txtBoxResultado";
            this.txtBoxResultado.Size = new System.Drawing.Size(100, 20);
            this.txtBoxResultado.TabIndex = 14;
            // 
            // VentanaOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 370);
            this.Controls.Add(this.txtBoxResultado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxIm2);
            this.Controls.Add(this.txtBoxRe2);
            this.Controls.Add(this.txtBoxIm1);
            this.Controls.Add(this.txtBoxRe1);
            this.Name = "VentanaOperaciones";
            this.Text = "Operaciones";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxRe1;
        private System.Windows.Forms.TextBox txtBoxIm1;
        private System.Windows.Forms.TextBox txtBoxRe2;
        private System.Windows.Forms.TextBox txtBoxIm2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxResultado;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}