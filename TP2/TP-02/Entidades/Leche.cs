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
        /// Cargar los atributos de la clase base y los de esta clase
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color, ETipo tipo) : base(codigo, marca, color)
        {
           this.tipo = tipo;
        }
        /// <summary>
        /// Cargar los atributos de la clase base y pasa Etipo.entera por defecto
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca,string codigo, ConsoleColor color) : this(marca,codigo,color,ETipo.Entera)
        {
            
        }
        /// <summary>
        /// Retorna cantidad de calorias
        /// </summary>
        protected new short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }
        /// <summary>
        /// Muestra todos los elementos incluyendo los de la clase base
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
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
