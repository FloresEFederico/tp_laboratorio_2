using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Excepciones;
namespace Archivos
{
    public class SerializadorXml<T> where T: new()
    {
        private string rutaCompleta;
        private string ruta;
        public SerializadorXml(string ruta,string nombreArchivo)
        {
            if(ruta is null || nombreArchivo is null)
            {
                throw new ElementoNullException("Uno de los strings pasados al constructor SerializadorXml fue null");
            }
            this.rutaCompleta = ruta + nombreArchivo;
            this.ruta = ruta;
        }

        /// <summary>
        /// Crea un archivo xml y lo guarda.
        /// </summary>
        /// <param name="obj"></param>
        public void Guardar(T obj)
        {
            if(this.rutaCompleta is null)
            {
                throw new ElementoNullException("La ruta completa del archivo fue null");
            }
            if(!Directory.Exists(this.ruta))
            {
                throw new DirectorioInvalidoException("No se encontro la ruta en la que se desea guardar el archivo");
            }
            using (XmlTextWriter xmlTextWriter = new XmlTextWriter(this.rutaCompleta, Encoding.UTF8))
            {
                xmlTextWriter.Formatting = Formatting.Indented;
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                serializer.Serialize(xmlTextWriter, obj);
            }
        }

        /// <summary>
        /// Carga un archivo xml y retorna los datos obtenidos
        /// </summary>
        /// <returns></returns> los datos obtenidos del archivo xml
        public T Leer()
        {
            if(File.Exists(this.rutaCompleta))
            {
                using (XmlTextReader xmlTextReader = new XmlTextReader(this.rutaCompleta))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(xmlTextReader);
                }
            }
            else
            {
                throw new ArchivoNoEncontradoException("No se encontro la ruta del archivo");
            }
        }

    }
}
