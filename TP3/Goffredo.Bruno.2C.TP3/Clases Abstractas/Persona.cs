using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        ENacionalidad nacionalidad;
        int dni;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
        public string StringToDNI
        {
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }
        public int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            return ValidarDni(nacionalidad, dato.ToString());
        }
        public int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;

            if (dato.Length < 9 && int.TryParse(dato, out dni))
            {
                if ((nacionalidad == ENacionalidad.Argentino && dni >= 1 && dni <= 89999999)
                     || nacionalidad == ENacionalidad.Extranjero && dni >= 90000000 && dni <= 99999999)
                {
                    return dni;
                }
                else
                {
                    throw new NacionalidadInvalidaException("La nacionalidad no se condice con el numero de DNI");
                }
            }
            else
            {
                throw new DniInvalidoException();
            }
        }
        public string ValidarNombreApellido(string dato)
        {
            for (int i = 0; i < dato.Length; i++)
            {
                if ((i >= 'a' && i <= 'z') || (i >= 'A' && i <= 'Z'))
                {
                    return "";
                }
            }
            return dato;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE COMPLETO: {this.apellido}, {this.nombre}");
            sb.AppendLine($"NACIONALIDAD: {this.nacionalidad}");
            return sb.ToString();
        }
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}

