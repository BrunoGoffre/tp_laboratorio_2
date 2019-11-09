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

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Persona()
        {

        }
        /// <summary>
        /// Constructor con todos los atributos menos DNI
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        /// <summary>
        /// Contructor que valida DNI como entero
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        /// <summary>
        /// Constructor que valida el DNI como string
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        /// <summary>
        /// Retorna o Setea atributo nombre
        /// </summary>
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
        /// <summary>
        /// Retorna o Setea atributo apellido
        /// </summary>
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
        /// <summary>
        /// Retorna y Setea atributo DNI validadolo 
        /// </summary>
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
        /// <summary>
        /// Retorna o Setea atributo Nacionalidad
        /// </summary>
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
        /// <summary>
        /// Retorna o Setea atributo DNI validandolo
        /// </summary>
        public string StringToDNI
        {
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }
        /// <summary>
        /// Valida dni como Segun nacionalidad
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        public int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            return ValidarDni(nacionalidad, dato.ToString());
        }
        /// <summary>
        /// Valida dni tipo string segun nacionalidad
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Valida que el atributo dato sean solo letras
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Convierte todos los datos en publicos
        /// </summary>
        /// <returns></returns>
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

