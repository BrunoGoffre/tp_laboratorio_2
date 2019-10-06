using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks : Producto
    {
        #region Constructores
        public Snacks(EMarca marca, string codigo, ConsoleColor color) : base(codigo,marca,color)            
        {
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna la cantidad de calorias
        /// </summary>
        protected new short CantidadCalorias
        {
            get
            {
                return 104;
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

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"CALORIAS : {this.CantidadCalorias}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
