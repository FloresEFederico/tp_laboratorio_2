using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Entidades;
using Archivos;
namespace Testeos
{
    [TestClass]
    public class Archivos_Test
    {
        private Fabrica<Producto> fabrica;
        [TestInitialize]
        public void InicializarFabrica()
        {
            this.fabrica = new Fabrica<Producto>("Fabrica Test",5);
        }
        [TestMethod]
        public void PruebaDeGuardadoYCargadoTexto()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            ArchivoTexto<Fabrica<Producto>> archivoText = new ArchivoTexto<Fabrica<Producto>>(path, "ArchivoTest.txt");
            string lectura = null;
            
            archivoText.GuardarTexto(this.fabrica);
            lectura = archivoText.LeerTexto();

            Assert.IsNotNull(lectura);
        }

        [TestMethod]
        public void PruebaDeGuardadoYCargadoXml()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            SerializadorXml<Fabrica<Producto>> archivoXml = new SerializadorXml<Fabrica<Producto>>(path, "ArchivoXmlTest.txt");
            archivoXml.Guardar(this.fabrica);
            this.fabrica = null;
            this.fabrica = archivoXml.Leer();

            Assert.IsNotNull(this.fabrica);
        }
    }
}
