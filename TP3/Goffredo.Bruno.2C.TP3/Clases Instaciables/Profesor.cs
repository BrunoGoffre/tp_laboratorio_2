﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases_Instaciables
{
    public sealed class Profesor : Universitario
    {
        Queue<Universidad.EClases> clasesDelDia;
        static Random random;

        static Profesor()
        {
            random = new Random();
        }
        private Profesor()
        {

        }
        public Profesor(int id,string nombre,string apellido,string dni, ENacionalidad nacionalidad) : base(id,nombre,apellido, dni, nacionalidad)
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
        }
        /// <summary>
        /// Muestra todos los datos de la clase
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{base.MostrarDatos()}\n");
            sb.AppendFormat(this.ParticiparEnClase());

            return sb.ToString();
        }
        /// <summary>
        /// Muestras las clases que tiene en el atributo clasesDelDia
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"CLASES DEL DIA:\n");
            foreach (Universidad.EClases item in clasesDelDia)
            {
                sb.AppendFormat(item.ToString()+ "\n");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Asigna dos clases random a la cola de profesor
        /// </summary>
        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
            System.Threading.Thread.Sleep(1000);
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
        }

        /// <summary>
        /// Compara igualdad entre profesor y Universidad.clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if (item == clase)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Compara igualdad entre profesor y Universidad.clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        /// <summary>
        /// Muestra todos los datos de la clase
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
