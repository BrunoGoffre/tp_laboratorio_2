using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public static class Calculadora
    {
        /// <summary>
        /// Verifica que el operador sea valido
        /// </summary>
        /// <param name="x"></param>
        /// <+></returns> Operador en x
        private static string ValidarOperador (string x)
        {
            if (x != "+" && x != "-" && x != "*" && x != "/")
            {
                return "+";
            }
            else
            {
                return x;
            }

        }
        /// <summary>
        /// Opera dos objetos de tipo Numero con el operador recibido
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <resultado>
        public static double Operar(Numero numero1,Numero numero2 , string operador)
        {
            string auxOperador;
            auxOperador = Calculadora.ValidarOperador(operador);            
            if (auxOperador == "+")
            {
                return numero1 + numero2;
            }
            else if (auxOperador == "-")
            {
                return numero1 - numero2;
            }
            else if (auxOperador == "/")
            {
                return numero1 / numero2;
            }
            else
            {
                return numero1 * numero2;
            }
        }
    }
}
