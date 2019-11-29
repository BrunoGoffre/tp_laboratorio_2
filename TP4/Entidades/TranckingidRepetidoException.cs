using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TranckingidRepetidoException : Exception
    {
        public TranckingidRepetidoException(string mensaje) : base (mensaje)
        {

        }
        public TranckingidRepetidoException(string mensaje, Exception inner) : base(mensaje,inner)
        {

        }
    }
}
