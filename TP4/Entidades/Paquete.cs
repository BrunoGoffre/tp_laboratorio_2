using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        public delegate void DelegadoEstado (object sernder, EventArgs e);
        string direccionEntrega;
        EEstado estado;
        string trackingID;
        public event DelegadoEstado InformarEstado;


        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return string.Format("{0} para {1}\n",((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionEntrega);
        }

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
        
        public void MockCicloDeVida()
        {
            int i = 0;
            do
            {
                this.Estado = (EEstado)i;
                i++;
                InformarEstado.Invoke(this,null);
                System.Threading.Thread.Sleep(4000);
            }
            while (this.estado != EEstado.Entregado);
            PaqueteDAO.Insertar(this);
        }
        public override string ToString()
        {
            return $"{MostrarDatos(this)} Estado: {this.estado}";
        }
        public static bool operator ==(Paquete p1,Paquete p2)
        {
            if (p1.TrackingID == p2.TrackingID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        public enum EEstado
        {
            ingresado,
            EnViaje,
            Entregado
        }
    }
}
