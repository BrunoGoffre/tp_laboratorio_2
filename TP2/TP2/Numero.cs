using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Numero
    {
        double numero;

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double a)
        {
            this.numero = a;
        }
        public Numero(string cadena)
        {
            double.TryParse(cadena, out this.numero);            
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

        public static string decimalBinario(string strNumero)
        {
            double aux;
            string retorno = string.Empty;

            if (double.TryParse(strNumero, out aux))
            {
                retorno = decimalBinario(aux);
            }
            else
            {
                retorno = "Valor invalido";
            }
            return retorno;                
        }
        public static string decimalBinario(double numero)
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

    }
}
