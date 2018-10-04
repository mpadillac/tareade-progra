using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrograWeb.Lunes.ServicioCalculadora;

namespace PrograWeb.Lunes.CalculadoraTest
{
    [TestClass]
    public class Potencias
    {
        [TestMethod]
        public void BasePositivaPotenciaPositiva()
        {
            // preparación del escenario
            var miBase = 5.0;
            var miPotencia = 3.0;
            var miValorEsperado = 125.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new ServicioCalculadora.Service1();
            miValorReal = elServicio.Potencia(miBase, miPotencia);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);




        }
    }
}
