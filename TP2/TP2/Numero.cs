using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Numero
    {
        double numero;

        public Numero()
        {
            this.numero = 0;
        }

        private string SetNumero
        {
            set
            {
                this.numero = validarNumero(value);
            }
        }

        private double validarNumero(string strNumero)
        {
            double retorno = 0;
            double.TryParse(strNumero, out retorno);
            return retorno;
        }

        public static string binarioDecimal(string strNumero)
        {
            string retorno = "";
            int numero = 0;

            for (int i = 0; i < strNumero.Length; i++)
            {
                if (strNumero[i] == '1')
                {
                    numero += (int) Math.Pow(2, i);
                }               
            }
            retorno = numero.ToString();
            return retorno;
        }
    }
}
