using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosComplejos
{
    public partial class VentanaOperaciones : Form
    {
        public VentanaOperaciones()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creacion de variables y asignaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void Button1_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(txtBoxRe1.Text);
            double I1 = Convert.ToDouble(txtBoxIm1.Text);
            double R2 = Convert.ToDouble(txtBoxRe2.Text);
            double I2 = Convert.ToDouble(txtBoxIm2.Text);

            txtBoxResultado.Text = NComplejo.Sumar(R1, I1, R2, I2);
        }
       

        private void BtnMult_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(txtBoxRe1.Text);
            double I1 = Convert.ToDouble(txtBoxIm1.Text);
            double R2 = Convert.ToDouble(txtBoxRe2.Text);
            double I2 = Convert.ToDouble(txtBoxIm2.Text);

            txtBoxResultado.Text = NComplejo.Multiplicar(R1, I1, R2, I2);

        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(txtBoxRe1.Text);
            double I1 = Convert.ToDouble(txtBoxIm1.Text);
            double R2 = Convert.ToDouble(txtBoxRe2.Text);
            double I2 = Convert.ToDouble(txtBoxIm2.Text);

            txtBoxResultado.Text = NComplejo.Restar(R1, I1, R2, I2);

        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(txtBoxRe1.Text);
            double I1 = Convert.ToDouble(txtBoxIm1.Text);
            double R2 = Convert.ToDouble(txtBoxRe2.Text);
            double I2 = Convert.ToDouble(txtBoxIm2.Text);

            txtBoxResultado.Text = NComplejo.Dividir(R1, I1, R2, I2);

        }
    }
} 
