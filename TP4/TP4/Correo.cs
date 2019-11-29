using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        List<Thread> mockPaquetes;
        List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }
        public void FinEntrega()
        {
            foreach (Thread item in this.mockPaquetes)
            {
                item.Abort();
            }
        }
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            string retorno = string.Empty;
            foreach (Paquete p in ((Correo)elementos).Paquetes)
            {
                retorno += $"{p.TrackingID} para {p.DireccionEntrega} ({p.Estado.ToString()})";
            }
            return retorno;
        }
        public static Correo operator +(Correo c, Paquete p)
        {

            foreach (Paquete item in c.Paquetes)
            {
                if (item == p)
                {
                    throw new TranckingidRepetidoException("Paquete repetido");
                }
            }
            c.Paquetes.Add(p);
            Thread hilo = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(hilo);
            hilo.Start();
            return c;
        }
    }
}
