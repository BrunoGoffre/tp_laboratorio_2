using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        ETipo tipo;            

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color) : base(codigo, marca, color)
        {
            this.tipo = ETipo.Entera;
        }
        public Leche(EMarca marca,string codigo, ConsoleColor color, ETipo tipo) : this(marca,codigo,color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected new short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"CALORIAS: {this.CantidadCalorias}");
            sb.AppendLine($"TIPO: {this.tipo}");            
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        public enum ETipo
        {
            Entera,
            Descremada
        }
    }
}
