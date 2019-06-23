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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void BtnOperaciones_Click(object sender, EventArgs e)
        {
            Form VentanaOperaciones = new VentanaOperaciones();
            VentanaOperaciones.Show();
        }

        private void BtnPasajes_Click(object sender, EventArgs e)
        {
            Form VentanaPasajes = new VentanaPasajes();
            VentanaPasajes.Show();

        }

        private void BtnSumaFasores_Click(object sender, EventArgs e)
        {
            Form VentanaSF = new VentanaSF();
            VentanaSF.Show();

        }
    }
}
