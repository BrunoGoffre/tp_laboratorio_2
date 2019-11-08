using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivos<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter open = new StreamWriter(archivo))
                {
                    open.WriteLine(datos);
                }
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader leer = new StreamReader(archivo))
                {
                    datos = leer.ReadToEnd();
                }
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    }
}
