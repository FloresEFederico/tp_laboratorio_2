using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using Excepciones;
using System.IO;
using Archivos;
namespace Testeos
{
    [TestClass]
    public class ExcepcionesTest
    {
        private Fabrica<Producto> fabricaTest;
        [TestInitialize]
        public void InicializarFabrica()
        {
            this.fabricaTest = new Fabrica<Producto>();
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArchivoNoEncontradoException))]
        public void PruebaArchivoNoEncontradoException()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            string fileName = "archivoNoExistente.txt";
            SerializadorXml<Fabrica<Producto>> serializador = new SerializadorXml<Fabrica<Producto>>(path,fileName);
            try
            {
                this.fabricaTest = serializador.Leer();
            }
            catch(ArchivoNoEncontradoException fileNotFound)
            {
                throw fileNotFound;
            }
        }
        
        [TestMethod]
        [ExpectedException(typeof(DatoInvalidoException))]
        public void PruebaDatoInvalidoException()
        {
            string nombre = "  ";
            
            if (nombre == "" || nombre.StartsWith(" "))
            {
                throw new DatoInvalidoException("No se ha ingresado un nombre valido!");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DirectorioInvalidoException))]
        public void PruebaDirectorioInvalidoException()
        {
            string path = "asdfasdfadf\\";
            string fileName = "archivoNoExistente.txt";
            ArchivoTexto<Fabrica<Producto>> textFile = new ArchivoTexto<Fabrica<Producto>>(path,fileName);
            try
            {
                textFile.GuardarTexto(this.fabricaTest);
            }catch(DirectorioInvalidoException d)
            {
                throw d;
            }
            
        }
        [TestMethod]
        public void PruebaElementoNullException()
        {
        }
        [TestMethod]
        public void PruebaListaNullException()
        {
        }
        [TestMethod]
        public void PruebaNoEspacioException()
        {
        }
        [TestMethod]
        public void pruebaProductosIgualesException()
        {
        }
    }
}
