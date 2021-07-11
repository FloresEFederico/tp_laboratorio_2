using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
using Entidades;
namespace Archivos
{
    public class ArchivoTexto<T> where T: Fabrica<Producto>, new()
    {
        private string ruta;
        private string nombreDelArchivo;

        public ArchivoTexto(string ruta,string nombreDelArchivo)
        {
            if (ruta is null || nombreDelArchivo is null)
            {
                throw new ElementoNullException("Uno de los strings pasados al constructor SerializadorXml fue null");
            }
            this.ruta = ruta;
            this.nombreDelArchivo = nombreDelArchivo;
        }

        /// <summary>
        /// Crea y guarda un archivo de texto.
        /// </summary>
        /// <param name="obj"></param>
        public void GuardarTexto(T obj)
        {
            if (this.ruta is null || this.nombreDelArchivo is null)
            {
                throw new ElementoNullException("La ruta completa del archivo fue null");
            }
            if (!Directory.Exists(this.ruta))
            {
                throw new DirectorioInvalidoException("No se encontro la ruta en la que se desea guardar el archivo");
            }
            string rutaCompleta = ruta + nombreDelArchivo;
            using(StreamWriter writer = new StreamWriter(rutaCompleta))
            {
                writer.WriteLine(obj.MostrarDatosDeLaFabrica());
            }
        }

        /// <summary>
        /// Lee y retorna un archivo de texto
        /// </summary>
        /// <returns></returns> un string con los datos del archivo
        public string LeerTexto()
        {
            string rutaCompleta = ruta + nombreDelArchivo;
            if (File.Exists(rutaCompleta))
            {
                using (StreamReader reader = new StreamReader(rutaCompleta))
                {
                    return reader.ReadToEnd();
                }
            }
            else
            {
                throw new ArchivoNoEncontradoException("No se encontro la ruta del archivo");
            }
        }
    }
}
