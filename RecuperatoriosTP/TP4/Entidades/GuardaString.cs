using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        /// <summary>
        /// Guarda el texto recibido en un archivo de texto en el escritorio
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static bool Guardar(this String texto, string archivo)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo;
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(texto);
                }
            }
            catch(FileNotFoundException ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
