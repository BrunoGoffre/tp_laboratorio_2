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
            string retorno;
            if (x != "+" && x != "-" && x != "*" && x != "/")
            {
                retorno = "+";
            }
            else
            {
                retorno = x;
            }
            return retorno;
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
            double retorno;
            auxOperador = Calculadora.ValidarOperador(operador);            
            if (auxOperador == "+")
            {
                retorno = numero1 + numero2;
            }
            else if (auxOperador == "-")
            {
                retorno = numero1 - numero2;
            }
            else if (auxOperador == "/")
            {
                retorno = numero1 / numero2;
            }
            else
            {
                retorno = numero1 * numero2;
            }

            return retorno;
        }
    }
}
