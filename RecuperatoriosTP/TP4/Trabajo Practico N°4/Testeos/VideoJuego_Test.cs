using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using System.Collections.Generic;

namespace Testeos
{
    [TestClass]
    public class VideoJuego_Test
    {
        private VideoJuego juego;

        /// <summary>
        /// Se instancia el atributo juego
        /// </summary>
        [TestInitialize]
        public void Inicializar()
        {
            this.juego = new VideoJuego("Need for Speed Underground", 13, "Juegazo de fuchibol", ETipoVideoJuego.Carreras, new List<EPlataforma>() { EPlataforma.Playstation }, EFormato.Fisico, 40);
        }
        /// <summary>
        /// pruba de instancia
        /// </summary>
        [TestMethod]
        public void PruebaDeInstancia()
        {
            this.juego = new VideoJuego("Crash Bandicoot", 40, "test descr", ETipoVideoJuego.Plataformas, new List<EPlataforma>() { EPlataforma.Playstation }, EFormato.Fisico, 4);
            Assert.IsNotNull(juego);
        }
        /// <summary>
        /// Prueba de el metodo CalcularPesoJuego
        /// </summary>
        [TestMethod]
        public void PruebaCalcularPesoJuego()
        {
            int pesoEsperado = this.juego.Duracion * 2;
            string textoEsperado = $"El juego pesa {pesoEsperado}GB. No incluye artwork digital.";
            string textoResultado = juego.CalcularPesoDelJuego();

            Assert.AreEqual(textoEsperado, textoResultado);
        }

        /// <summary>
        /// Prueba del metodoFixearBugs()
        /// </summary>
        [TestMethod]
        public void PruebaDeFixearBugs()
        {
            bool isTrue = false;
            this.juego.BugsDeFabrica = 13;
            isTrue = this.juego.FixearBugs();
            Assert.IsTrue(isTrue);
        }
    }
}
