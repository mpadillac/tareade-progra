using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrograWeb.Lunes.ServicioCalculadora.Logica;

namespace PrograWeb.Lunes.CalculadoraTest
{
    [TestClass]
    public class Cuadratica
    {
        [TestMethod]
        public void constanteADiferenteCero_DiscriminanteMayorCero()
        {
            // preparación del escenario
            var consA = 5;
            var consB = 7;
            var consC = 2;
            //Datos esperados
            var discri = 9.0;
            var pRaiz = -0.4;
            var sRaiz = -1;
            var result = 0;
            //Datos reales
            var discriR = 0.0;
            var pRaizR = 0.0;
            var sRaizR = 0.0;
            var resultR = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método


            var elServicio = new ServicioCalculadora.Logica.Servicio.Service2();
            discriR = elServicio.obtenerEcuacion(consA, consB, consC).Discri;
            pRaizR = elServicio.obtenerEcuacion(consA, consB, consC).PrimeraRaiz;
            sRaizR = elServicio.obtenerEcuacion(consA, consB, consC).SegundaRaiz;
            resultR = elServicio.obtenerEcuacion(consA, consB, consC).CodResultado;

            // verificar el resultado obtenido
            Assert.AreEqual(discri, discriR);
            Assert.AreEqual(pRaiz, pRaizR);
            Assert.AreEqual(sRaiz, sRaizR);
            Assert.AreEqual(result, resultR);
        }
        [TestMethod]
        public void constanteADiferenteCeroDiscriminanteIgualCero()
        {
            // preparación del escenario
            var consA = 36;
            var consB = -60;
            var consC = 25;
            //Datos esperados
            var discri = 0.0;
            var pRaiz = 0.83333333333333337;
            var sRaiz = 0.83333333333333337;
            var result = 0;
            //Datos reales
            var discriR = 0.0;
            var pRaizR = 0.0;
            var sRaizR = 0.0;
            var resultR = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método

            var elServicio = new ServicioCalculadora.Logica.Servicio.Service2();
            discriR = elServicio.obtenerEcuacion(consA, consB, consC).Discri;
            pRaizR = elServicio.obtenerEcuacion(consA, consB, consC).PrimeraRaiz;
            sRaizR = elServicio.obtenerEcuacion(consA, consB, consC).SegundaRaiz;
            resultR = elServicio.obtenerEcuacion(consA, consB, consC).CodResultado;

            // verificar el resultado obtenido
            Assert.AreEqual(discri, discriR);
            Assert.AreEqual(pRaiz, pRaizR);
            Assert.AreEqual(sRaiz, sRaizR);
            Assert.AreEqual(result, resultR);

        }
    }
}