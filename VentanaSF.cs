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
    public partial class VentanaSF : Form
    {
        public double Fase { get; private set; }

        public VentanaSF()
        {
            InitializeComponent();
        }

        //Funcion que transforma angulo a radianes
        public static double rad(double drag)
        {
            return ((drag / 180 * Math.PI));
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            double AmpAngF1 = Convert.ToDouble(mtxtBoxAmp1.Text);
            double AmpAngF2 = Convert.ToDouble(mtxtBoxAmp2.Text);
            string tipoF1 = Convert.ToString(txtBoxTipoFasor1.Text);
            string tipoF2 = Convert.ToString(txtBoxTipoFasor2.Text);
            double FAngF1 = Convert.ToDouble(mtxtBoxFrecAngF1.Text);
            double FAngF2 = Convert.ToDouble(mtxtBoxFrecAngF2.Text);
            double FaseF1 = Convert.ToDouble(mtxtBoxFaseF1.Text);
            double FaseF2 = Convert.ToDouble(mtxtBoxFaseF2.Text);

            // opero primer fasor
            while(tipoF1 == "Sen")
            {
                FaseF1 -= 90; //si  es una funcion senoidal paso a cosenoidal
                tipoF1 = "Cos";
            }
            if (tipoF1 != "Sen" & tipoF1 != "Cos") { MessageBox.Show("Ingrese 'Sen' o 'Cos' para tipo de Fasor"); }
            
            //opero segundo fasor

            while(tipoF2 == "Sen")
            {
                FaseF2 -= 90; //si  es una funcion senoidal paso a cosenoidal
                tipoF2 = "Cos";
            }
            if (tipoF2 != "Sen" & tipoF2 != "Cos") { MessageBox.Show("Ingrese 'Sen' o 'Cos' para tipo de Fasor"); }
            

            if (FAngF1 == FAngF2 & AmpAngF1 >= 0 & AmpAngF2 >= 0)
            {
                //Fasor 1
                double a1 = AmpAngF1 * Math.Cos(rad(FaseF1));
                double b1 = AmpAngF1 * Math.Sin(rad(FaseF1));
                //Fasor 2
                double a2 = AmpAngF2 * Math.Cos(rad(FaseF2));
                double b2 = AmpAngF2 * Math.Sin(rad(FaseF2));

                double resultRe = a1 + a2;
                double resultIm = b2 + b1;

                double resultAmp = Math.Sqrt(Math.Pow(resultRe, 2) + Math.Pow(resultIm, 2));

                //opero resultado segun cuadrante de numero complejo para obtener Fase
                double Fase;
                if(resultRe<0 & resultIm < 0)
                {
                     Fase = Math.Atan(rad(resultIm/resultRe)) - 1;
                }   if (resultRe < 0 & resultIm > 0)
                    {
                        Fase = Math.Atan(rad(resultIm / resultRe)) + 1;
                    } else {  Fase = Math.Atan((resultIm/resultRe)); }

                //Asigno resultado en cuadro
                labelResultAmp.Text = Convert.ToString("f(x)= "+ Math.Round(resultAmp,2) + "*Cos( " + FAngF1 + "*t+" + Math.Round(Fase,2) + ")");  

            }
            else { MessageBox.Show("Las frecuencias angulares no coinciden y/o amplitudes negativas"); }
            
        }

    }
}

