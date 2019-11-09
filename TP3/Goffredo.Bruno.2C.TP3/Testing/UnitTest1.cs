using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using EntidadesAbstractas;
using Clases_Instaciables;
using Archivos;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void ExcepcionNacionalidad()
        {
            Universidad uni = new Universidad();
            Alumno a2 = new Alumno(2, "Juana", "Martinez", "12234458",
               EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
               Alumno.EEstadoCuenta.Deudor);
              uni += a2;
        }
        
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void ExcepcionAlumnoRepetido()
        {
            Universidad harvard = new Universidad();

            Alumno alumno = new Alumno(12, "Miguel", "Goffredo", "97845313",
            EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion,
            Alumno.EEstadoCuenta.AlDia);

            harvard += alumno;

            Alumno otroAlumno = new Alumno(13, "Bruno", "Gonzalez", "97845313",
            EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion,
            Alumno.EEstadoCuenta.AlDia);

            harvard += otroAlumno;
        }
        
        [TestMethod]
        public void ValidacionNumerica()
        {
            string esperado = "1234567";
            Alumno alumno = new Alumno(1, "Bruno", "Goffredo", "1234567", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            Assert.AreEqual(esperado, alumno.DNI.ToString());
        }

        [TestMethod]
        public void ValidacionNull()
        {
            Universidad UTN = new Universidad();

            Alumno a = new Alumno(8, "Guido", "Morales", "1234567",
            EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion,
            Alumno.EEstadoCuenta.AlDia);

            Profesor p = new Profesor(2, "Alejandro", "Perdomo", "3456789",
            EntidadesAbstractas.Persona.ENacionalidad.Argentino);

            UTN += a;
            UTN += p;

            Assert.IsNotNull(UTN.Alumnos[0]);
            Assert.IsNotNull(UTN.Profesores[0]);
        }

    }
}
