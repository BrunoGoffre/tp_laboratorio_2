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

        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.instructor = instructor;
            this.clase = clase;
        }

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
        public static bool operator ==(Jornada a, Alumno b)
        {
            return b == a.clase;
        }
        public static bool operator !=(Jornada a, Alumno b)
        {
            return !(a == b);
        }
        public static Jornada operator +(Jornada a, Alumno b)
        {
            if (a != b)
            {
                a.alumnos.Add(b);
            }
            return a;
        }
        public static bool Guardar(Jornada jornada)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Texto file = new Texto();
            return file.Guardar(path, jornada.ToString());
        }
        public static string Leer()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string texto = string.Empty;
            Texto file = new Texto();

            file.Leer(path, out texto);

            return texto;
        }
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
