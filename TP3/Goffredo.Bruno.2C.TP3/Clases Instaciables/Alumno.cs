using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases_Instaciables
{
    public sealed class Alumno : Universitario
    {
        Universidad.EClases claseQueToma;
        EEstadoCuenta estadoCuenta;

        public Alumno()
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.MostrarDatos() + "\n");
            sb.AppendFormat(this.ParticiparEnClase());
            sb.AppendFormat($"Estado de cuenta: {this.estadoCuenta}\n");

            return sb.ToString();
        }

        protected override string ParticiparEnClase()
        {
            return $"TOMA CLASE DE {this.claseQueToma}\n";
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static bool operator ==(Alumno a, Universidad.EClases b)
        {
            if (a.claseQueToma == b && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Alumno a, Universidad.EClases b)
        {
            if (a.claseQueToma != b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
    }
}
 