using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Dulce : Producto
    {
        #region Constructores
        public Dulce(EMarca marca, string codigo, ConsoleColor color) : base(codigo,marca,color)
        {
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna la cantidad de calorias de un dulce
        /// </summary>
        protected new short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestras todos los datos de el dulce incluyendo los de la base
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"CALORIAS : {this.CantidadCalorias}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
