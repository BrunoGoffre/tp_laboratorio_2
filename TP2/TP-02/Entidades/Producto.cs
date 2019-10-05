using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        EMarca marca;
        string codigoDeBarras;
        ConsoleColor colorPrimarioEmpaque;        

        public Producto(string codigo, EMarca marca, ConsoleColor color)
        {
            this.marca = marca;
            this.codigoDeBarras = codigo;
            this.colorPrimarioEmpaque = color;
        }
        /// <summary>
        /// ReadOnly: Retornará la cantidad de ruedas del vehículo
        /// </summary>
        public short CantidadCalorias
        {
            get;
        }
        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CODIGO DE BARRAS: {this.codigoDeBarras}\r");
            sb.AppendLine($"MARCA          : {this.marca.ToString()}\r");
            sb.AppendLine($"COLOR EMPAQUE  : {this.colorPrimarioEmpaque.ToString()}\r");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.Mostrar();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            return (v1.codigoDeBarras == v2.codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1 == v2);
        }

        public enum EMarca
        {
            Serenisima,
            Campagnola,
            Arcor,
            Ilolay,
            Sancor,
            Pepsico
        }
    }
}
