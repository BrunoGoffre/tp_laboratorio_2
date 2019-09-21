using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Numero
    {
        private double numero;

        #region Constructores

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double dato)
        {
            this.numero = dato;
        }
        public Numero(string dato)
        {
            this.SetNumero = dato;
        }

        #endregion

        #region Operadores

        public static double operator +(Numero a, Numero b)
        {
            return a.numero + b.numero;
        }

        public static double operator -(Numero a, Numero b)
        {
            return a.numero - b.numero;
        }

        public static double operator *(Numero a, Numero b)
        {
            return a.numero * b.numero;
        }

        public static double operator /(Numero a, Numero b)
        {
            double retorno = 0;
            if (b.numero != 0)
            {
                retorno = a.numero / b.numero;
            }
            else
            {
                retorno = double.MinValue;
            }
            return retorno;
        }

        #endregion
        
        #region Convercion

        public static string BinarioDecimal(string strNumero)
        {
            int numero = 0;
            int potencia = strNumero.Length - 1;

            for (int i = 0; i < strNumero.Length; i++)
            {
                if (strNumero[i] == '1' || strNumero[i] == '0')
                {
                    if (strNumero[i] == '1')
                    {
                        numero += (int)Math.Pow(2, potencia);
                    }
                }
                else
                {
                    return "Valor invalido";
                }
                potencia--;
            }
            return numero.ToString();
        }
        public static string DecimalBinario(string strNumero)
        {
            double aux;
            string retorno = string.Empty;

            if (double.TryParse(strNumero, out aux))
            {
                retorno = DecimalBinario(aux);
            }
            else
            {
                retorno = "Valor invalido";
            }
            return retorno;
        }

        public static string DecimalBinario(double numero)
        {
            string retorno = string.Empty;
            int aux = (int)numero;
            do
            {
                if (aux % 2 == 0)
                {
                    retorno = "0" + retorno;
                }
                else
                {
                    retorno = "1" + retorno;
                }
                aux = aux / 2;
            } while (aux >= 1);
            return retorno;

        }

        #endregion

        /// <summary>
        /// Establece un numero en el atributo local.
        /// </summary>
        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Realiza la validacion de un string para utilizarce como numero
        /// </summary>
        /// <param name="strNumero"></param>
        /// <0></retorno numero>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            double.TryParse(strNumero, out retorno);
            return retorno;
        }





    }
}
