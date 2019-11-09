using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Archivos;

namespace Clases_Instaciables
{
    public class Jornada
    {
        List<Alumno> alumnos;
        Universidad.EClases clase;
        Profesor instructor;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.instructor = instructor;
            this.clase = clase;
        }

        /// <summary>
        /// Retorna y setea atributo Alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }

        }

        /// <summary>
        /// Retorna y setea atributo clase
        /// </summary>
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        /// <summary>
        /// Retorna y setea atributo instructor
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        /// <summary>
        /// Compara una Jornada y un alumno
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada a, Alumno b)
        {
            return b == a.clase;
        }
        /// <summary>
        /// Compara una jornada y un alumno
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada a, Alumno b)
        {
            return !(a == b);
        }
        /// <summary>
        /// Agrega un alumno a una jornada
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada a, Alumno b)
        {
            if (a != b)
            {
                a.alumnos.Add(b);
            }
            return a;
        }
        /// <summary>
        /// Guarda la clase en un archivo de texto en el escritorio
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Texto file = new Texto();
            return file.Guardar(path, jornada.ToString());
        }
        /// <summary>
        /// Lee los datos de un archivo de texto de el escritorio
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string texto = string.Empty;
            Texto file = new Texto();

            file.Leer(path, out texto);

            return texto;
        }
        /// <summary>
        /// Muestra todos los datos de Jornada
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Jornada:");
            sb.AppendLine($"Clase del dia: {this.clase}");
            sb.AppendLine($"POR {this.Instructor.ToString()}");

            sb.AppendLine("Alumnos:");
            foreach (Alumno item in this.Alumnos)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("\n<------------------------------------------>\n");

            return sb.ToString();
        }
    }
}
