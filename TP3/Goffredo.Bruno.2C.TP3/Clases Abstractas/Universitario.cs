using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        int legajo;
        
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Universitario()
        {

        }
        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo,string nombre,string apellido,string dni,ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        /// <summary>
        /// Muestra todos los datos de la clase
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.ToString());
            sb.AppendFormat($"\nLegajo: {this.legajo}");

            return sb.ToString();
        }

        /// <summary>
        /// Muestra en que clases participa
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Retorno true o false comparando legajo y DNI de un atributo de tipo Universitario
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario a, Universitario b)
        {
            if (a.legajo == b.legajo || a.DNI == b.DNI)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Retorno true o false comparando legajo y DNI de un atributo de tipo Universitario
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario a, Universitario b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType() && (this == (Universitario)obj));
        }
    }
}
