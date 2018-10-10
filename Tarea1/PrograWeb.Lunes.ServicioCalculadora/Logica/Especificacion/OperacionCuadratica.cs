using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.ServicioCalculadora.Logica.Especificacion
{
    public class OperacionCuadratica
    {
        //<summary>
        /// Función para obtener el valor del discriminante
        /// </summary>
        /// <param name="variableA">de la fórmula ax^2 + bx + c</param>
        /// <param name="variableB">de la fórmula ax^2 + bx + c</param>
        /// <param name="variableC">de la fórmula ax^2 + bx + c</param>
        /// <returns>El valor del discriminante</returns>
        public double Discriminante(double variableA, double variableB, double variableC)
        {
            var accionDiscriminante = new Accion.OperacionCuadratica();
            var resultado = accionDiscriminante.calcularDiscriminante(variableA, variableB, variableC);
            return resultado;
        }

        ///<summary>
        /// Función para obtener el valor de la primera raíz 
        /// </summary>
        /// <param name="variableA">de la fórmula genelal</param>
        /// <param name="variableB">de la fórmula general</param>
        /// <param name="discriminante">de la fórmula general</param>
        /// <returns>El valor de la primera raíz</returns>
        public double primeraRaiz(double variableA, double variableB, double discriminante)
        {
            var accionPrimeraRaiz = new Accion.OperacionCuadratica();
            var resultado = accionPrimeraRaiz.calcularPrimeraRaiz(variableA, variableB, discriminante);
            return resultado;
        }

        ///<summary>
        /// Función para obtener el valor de la segunda raíz 
        /// </summary>
        /// <param name="variableA">de la fórmula genelal</param>
        /// <param name="variableB">de la fórmula general</param>
        /// <param name="discriminante">de la fórmula general</param>
        /// <returns>El valor de la segunda raíz</returns>
        public double segundaRaiz(double variableA, double variableB, double discriminante)
        {
            var accionSegundaRaiz = new Accion.OperacionCuadratica();
            var resultado = accionSegundaRaiz.calcularSegundaRaiz(variableA, variableB, discriminante);
            return resultado;
        }
        ///<summary>
        /// Función para obtener el valor del resultado
        /// </summary>
        /// <param name="variableA">de la fórmula genelal</param>
        /// <param name="discriminante">de la fórmula general</param>
        /// <returns>El valor de según el resultado</returns>
        public int valorResultado(double variableA, double discriminante)
        {
            var accionValorResultado = new Accion.OperacionCuadratica();
            var resultado = accionValorResultado.valorResultado(variableA, discriminante);
            return resultado;
        }
    }
}