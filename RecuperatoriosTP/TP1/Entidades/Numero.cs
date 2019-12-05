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
        /// <summary>
        /// Establece el campo numero por defecto 0,ç
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Asigna el campo numero con el calor ingresado
        /// </summary>
        /// <param name="dato"></param>
        public Numero(double dato)
        {
            this.numero = dato;
        }
        /// <summary>
        /// Asigna el campo numero validando que el string ingresado sea un numero
        /// </summary>
        /// <param name="dato"></param>
        public Numero(string dato)
        {
            this.SetNumero = dato;
        }

        #endregion

        #region Operadores
        /// <summary>
        /// Retorna la suma de dos objetos de tipo numero
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator +(Numero a, Numero b)
        {
            return a.numero + b.numero;
        }
        /// <summary>
        /// Retorna la resta de dos objetos de tipo numero
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator -(Numero a, Numero b)
        {
            return a.numero - b.numero;
        }
        /// <summary>
        /// Retorna la multiplicacion de dos objetos de tipo numero
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator *(Numero a, Numero b)
        {
            return a.numero * b.numero;
        }
        /// <summary>
        /// Retorna la divicion de dos objetos de tipo numero
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Convierte un numero numero binario en su equivalente decimal
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Convierte un numero decimal en su equivalente binario, en formato de string
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string strNumero)
        {
            double aux;
            string retorno = string.Empty;

            if (double.TryParse(strNumero, out aux))
            {
                retorno = Numero.DecimalBinario(aux);
            }
            else
            {
                retorno = "Valor invalido";
            }
            return retorno;
        }
        /// <summary>
        /// Convierte un numero decimal en su equivalente binario, en formato de double
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
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
                this.numero = this.ValidarNumero(value);
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
