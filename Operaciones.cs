using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosComplejos
{
    /// <summary>
    /// Se crea la clase de Números Complejos
    /// </summary>
    public class NComplejo
    {
        /// <summary>
        /// Se crea el método Sumar para realizar la suma de números imaginarios (a + c) + (b + d)i
        /// </summary>
        /// <param name="numeroa">Es un número real a</param>
        /// <param name="nimaginariob">Es un número imaginario b</param>
        /// <param name="numeroc">Es un número real c</param>
        /// <param name="nimaginariod">Es un número imaginario d</param>
        /// <returns>Retorna el resultado de la suma de los reales y la suma de los números imaginarios</returns>
        public static string Sumar(double numeroa, double nimaginariob, double numeroc, double nimaginariod)
        {
            try
            {
                double rreal = ((numeroa) + (numeroc));
                double rimaginario = ((nimaginariob) + (nimaginariod));
                return "(" + rreal.ToString() + "," + rimaginario + ")";
            }
            catch
            {
                throw new ExcepcionNumero("Numero NO Imaginario");
            }
        }
        /// <summary>
        /// Se crea el método Restar para realizar la resta de números imaginarios (a − c) + (b − d)i
        /// </summary>
        /// <param name="numeroa">Es un número real a</param>
        /// <param name="nimaginariob">Es un número imaginario b</param>
        /// <param name="numeroc">Es un número real c</param>
        /// <param name="nimaginariod">Es un número imaginario d</param>
        /// <returns>Retorna el resultado de la resta de los reales y la resta de los números imaginarios</returns>
        public static string Restar(double numeroa, double nimaginariob, double numeroc, double nimaginariod)
        {
            try
            {
                double rreal = ((numeroa) - (numeroc));
                double rimaginario = ((nimaginariob) - (nimaginariod));
                return "(" + rreal + "," + rimaginario + ")";
            }
            catch
            {
                throw new ExcepcionNumero("Numero NO Imaginario");
            }
        }
        /// <summary>
        /// Se crea el método para la multiplicación de números imaginarios (ac − bd) + (ad + bc)i
        /// </summary>
        /// <param name="numeroa">Es un número real a</param>
        /// <param name="nimaginariob">Es un número imaginario b</param>
        /// <param name="numeroc">Es un número real c</param>
        /// <param name="nimaginariod">Es un número imaginario d</param>
        /// <returns>Retorna el resultado de la Multiplicación  de los reales y la multiplicación  de los números imaginarios</returns>
        public static string Multiplicar(double numeroa, double nimaginariob, double numeroc, double nimaginariod)
        {
            try
            {
                double rreal1 = ((numeroa) * (numeroc));
                double rimag1 = (-((nimaginariob) * (nimaginariod)));
                double rreal2 = (-((numeroa) * (nimaginariod)));
                double rimag2 = ((nimaginariob) * (numeroc));

                double resulr = ((rreal1) + (-(rimag1)));
                double resuli = ((rreal2) + (rimag2));

                return "(" + resulr + "," + resuli + ")";
            }
            catch
            {
                throw new ExcepcionNumero("Numero NO Imaginario");
            }
        }
        /// <summary>
        /// Se crea el método para la División de números imganirios
        /// </summary>
        /// <param name="numeroa">Es un número real a</param>
        /// <param name="nimaginariob">Es un número imaginario b</param>
        /// <param name="numeroc">Es un número real c</param>
        /// <param name="nimaginariod">Es un número imaginario d</param>
        /// <returns>Retorna el resultado de la división de los reales y la división de los imaginarios</returns>
        public static string Dividir(double numeroa, double nimaginariob, double numeroc, double nimaginariod)
        {
            try
            {
                double resuln1 = ((numeroa) * (numeroc));
                double resuln2 = (-((nimaginariob) * (nimaginariod)));
                double resuln3 = ((nimaginariob) * (numeroc));
                double resuln4 = (+((nimaginariob) * (nimaginariod)));
                double resuln5 = ((resuln1) + (resuln4));
                double resuln6 = ((resuln2) + (resuln3));

                double resuld1 = ((numeroa) * (numeroc)) + ((nimaginariob) * (nimaginariod));

                double resulreal = (resuln5) / (resuld1);
                double resulimag = (resuln6) / (resuld1);

                return "(" + resulreal + "," + resulimag + ")";
            }
            catch
            {
                throw new ExcepcionNumero("Numero NO Imaginario");
            }
        }
    }
}
