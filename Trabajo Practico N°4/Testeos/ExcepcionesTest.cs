using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using Excepciones;
using System.IO;
using Archivos;
using System.Collections.Generic;

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
        [ExpectedException(typeof(ElementoNullException))]
        public void PruebaElementoNullException()
        {
            string path = null;
            if(path is null)
            {
                throw new ElementoNullException("test message");
            }
        }
        [TestMethod]
        [ExpectedException(typeof(ListaNullException))]
        public void PruebaListaNullException()
        {
            this.fabricaTest.JuegosFabricados = null;
            if(this.fabricaTest.JuegosFabricados is null)
            {
                throw new ListaNullException("Lista null!");
            }
        }
        [TestMethod]
        [ExpectedException(typeof(NoEspacioException))]
        public void PruebaNoEspacioException()
        {
            this.fabricaTest = new Fabrica<Producto>("Fabrica test", 2);
            try
            {
                this.fabricaTest += new VideoJuego("VideoJuego", 3, "Very good", ETipoVideoJuego.Accion, new List<EPlataforma>() { EPlataforma.PC }, EFormato.Ambos, 3);
                this.fabricaTest += new VideoJuego("VideoJuego2", 3, "Very average", ETipoVideoJuego.Aventura, new List<EPlataforma>() { EPlataforma.SmartPhone }, EFormato.Digital, 4);
                this.fabricaTest += new VideoJuego("VideoJuego3", 4, "Va a tirar exception", ETipoVideoJuego.Carreras, new List<EPlataforma>() { EPlataforma.SmartPhone }, EFormato.Digital, 2);
            }
            catch(NoEspacioException e)
            {
                throw e;
            }
            

        }
        [TestMethod]
        [ExpectedException(typeof(ProductosIgualesException))]
        public void pruebaProductosIgualesException()
        {
            this.fabricaTest = new Fabrica<Producto>("Fabrica test", 2);
            try
            {
                this.fabricaTest += new VideoJuego("VideoJuego", 3, "Igualito", ETipoVideoJuego.Accion, new List<EPlataforma>() { EPlataforma.PC }, EFormato.Ambos, 3);
                this.fabricaTest += new VideoJuego("VideoJuego", 3, "Igualito", ETipoVideoJuego.Accion, new List<EPlataforma>() { EPlataforma.PC }, EFormato.Ambos, 3);
            }catch(ProductosIgualesException e)
            {
                throw e;
            }
        }
    }
}
