
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Prueba si la lista de paquetes se instancia correctamente
        /// </summary>
        [TestMethod]
        public void ListaPaquetesIntanciada()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);
        }
        /// <summary>
        /// Verifica que se lanza la exepcion cuando es requerido
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void SinRepeticionDePaquetes()
        {
            Paquete a = new Paquete("Lugar", "ID");
            Paquete b = new Paquete("Lugar", "ID");
            Correo correo = new Correo();

            correo += a;
            correo += b;

        }
    }
}