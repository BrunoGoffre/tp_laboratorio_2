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
        /// <summary>
        /// Cargar los atributos
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Producto(string codigo, EMarca marca, ConsoleColor color)
        {
            this.marca = marca;
            this.codigoDeBarras = codigo;
            this.colorPrimarioEmpaque = color;
        }
        /// <summary>
        /// ReadOnly: Retornará la cantidad de calorias de el producto
        /// </summary>
        public short CantidadCalorias
        {
            get;
        }
        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        /// <summary>
        /// Convierte un elemento tipo producto a un string con sus datos
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CODIGO DE BARRAS: {p.codigoDeBarras}\r");
            sb.AppendLine($"MARCA          : {p.marca.ToString()}\r");
            sb.AppendLine($"COLOR EMPAQUE  : {p.colorPrimarioEmpaque.ToString()}\r");
            sb.AppendLine("---------------------");

            return sb.ToString();
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
        /// <summary>
        /// Enumeracion de marcas
        /// </summary>
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
