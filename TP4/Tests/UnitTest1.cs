using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListaPaquetesIntanciada()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);
        }
        [TestMethod]
        [ExpectedException(typeof(TranckingidRepetidoException))]
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
