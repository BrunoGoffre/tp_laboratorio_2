using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivos<T>
    {
        public bool Guardar(string archivo, T dato)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                serializer.Serialize(writer, dato);
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        public bool Leer(string archivo, out T dato)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(archivo);
                XmlSerializer ser = new XmlSerializer(typeof(T));

                dato = (T)ser.Deserialize(reader);

                reader.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }

        }
    }
}
