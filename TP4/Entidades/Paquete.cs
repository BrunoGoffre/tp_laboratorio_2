using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        public delegate void DelegadoEstado(object sender, EventArgs e);
        string direccionEntrega;
        EEstado estado;
        string trackingID;
        public event DelegadoEstado InformaEstado;

        /// <summary>
        /// Devuelve campo direccionEntrega
        /// </summary>
        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }
        /// <summary>
        /// Devuelve campo estado
        /// </summary>
        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        /// <summary>
        /// Devuelve capo trackinID
        /// </summary>
        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }
        /// <summary>
        /// Inicializa atributos
        /// </summary>
        /// <param name="direccionEntrega"></param>
        /// <param name="trackingID"></param>
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.trackingID = trackingID;
            this.direccionEntrega = direccionEntrega;
        }
        /// <summary>
        /// Implemente metodo de interfaz retornarnado al informacion de el objeto
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return string.Format("{0} para {1}", ((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionEntrega);
        }
        /// <summary>
        /// Devuelve los datos de el objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }
        public enum EEstado
        {
            Ingresando,
            EnViaje,
            Entregado
        }
        /// <summary>
        /// Compara dos paquetes en base a su atrisbuto trackingID
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Paquete a, Paquete b)
        {
            if (a.trackingID == b.trackingID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Compara dos paquetes
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Paquete a, Paquete b)
        {
            return !(a == b);
        }
        /// <summary>
        /// Cambia el estado del paquete cada 4 segundos y lo sube a la base de datos el paquete en el que se encuntra
        /// </summary>
        public void MockCicloDeVida()
        {
            for (int i = 0; i < 3; i++)
            {
                this.estado = (EEstado)i;
                this.InformaEstado.Invoke(this,null);
                System.Threading.Thread.Sleep(4000);
            } 
            PaqueteDAO.Insertar(this);
        }
    }
}
