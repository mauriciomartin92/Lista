using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace NumerosComplejos
{
    /// <summary>
    /// Se crea la clase ExcepcionNumero para generar excepciones personalizadas, estas heredan de Exception
    /// </summary>
    [Serializable]

    internal class ExcepcionNumero : Exception
    {
        public ExcepcionNumero()
        {
        }

        public ExcepcionNumero(string message) : base(message)
        {
        }

        public ExcepcionNumero(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExcepcionNumero(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
