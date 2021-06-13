using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using System.Collections.Generic;

namespace Testeos
{
    [TestClass]
    public class JuegoDeMesaTest
    {
        private JuegoDeMesa juego;

        /// <summary>
        /// Se instancia el atributo JuegoDeMesa
        /// </summary>
        [TestInitialize]
        public void InstanciarJuegoDeMesa()
        {
            this.juego = new JuegoDeMesa("OCA", 8, "El juego de la oca ya empezo iha iha oh", new List<EElementos>() { { EElementos.Dados }, { EElementos.Piezas } }, true, "Ganar");

        }

        /// <summary>
        /// Prueba del metodo CrearCaja()
        /// </summary>
        [TestMethod]
        public void PruebaCrearCaja()
        {

            string textoEsperado = new JuegoDeMesa("testJuego", 3, "testDescr", new List<EElementos>() { { EElementos.Cartas }, { EElementos.Dados } }, true, "Perder").CrearCaja();
            string textoResultado = this.juego.CrearCaja();

            Assert.AreEqual(textoResultado, textoEsperado);
        }

        /// <summary>
        /// Prueba de instancia de un JuegoDeMesa.
        /// </summary>
        [TestMethod]
        public void PruebaJuegoDeMesaInstancia()
        {
            JuegoDeMesa test = new JuegoDeMesa("testJuego", 3, "testDescr", new List<EElementos>() { { EElementos.Cartas }, { EElementos.Dados } }, true, "Perder");
            Assert.IsNotNull(test);
        }
    }
}
