using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Calculadora
    {
        private static string validarOperador (string x)
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

        public static double operar(double numero1, double numero2 , string operador)
        {
            string auxOperador;
            double retorno;
            auxOperador = Calculadora.validarOperador(operador);            
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
