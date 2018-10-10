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
        /// <param name="constante A">de la ecuación cuadrática</param>
        /// <param name="constante B">de la ecuación cuadrática/param>
        /// <param name="constante C">de la ecuación cuadrática</param>
        /// <returns>El valor del discriminante</returns>
        public double Discriminante(double a, double b, double c)
        {
            var accionDiscriminante = new Accion.OperacionCuadratica();
            var resultado = accionDiscriminante.calcularDiscri(a, b, c);
            return resultado;
        }

        ///<summary>
        /// Función para obtener el valor de la primera raíz 
        /// </summary>
        /// <param name="constante A">de la fórmula</param>
        /// <param name="constante B">de la fórmula</param>
        /// <param name="discriminante">de la fórmula</param>
        /// <returns>El valor de la primera raíz</returns>
        public double pRaiz(double a, double b, double discri)
        {
            var accionPrimeraRaiz = new Accion.OperacionCuadratica();
            var resultado = accionPrimeraRaiz.calcularpRaiz(a, b, discri);
            return resultado;
        }

        ///<summary>
        /// Función para obtener el valor de la segunda raíz 
        /// </summary>
        /// <param name="constante A">de la fórmula</param>
        /// <param name="constante B">de la fórmula</param>
        /// <param name="discriminante">de la fórmula</param>
        /// <returns>El valor de la segunda raíz</returns>
        public double sRaiz(double a, double b, double discri)
        {
            var accionSegundaRaiz = new Accion.OperacionCuadratica();
            var resultado = accionSegundaRaiz.calcularsRaiz(a, b, discri);
            return resultado;
        }
        ///<summary>
        /// Función para obtener el valor del resultado
        /// </summary>
        /// <param name="constante A">de la fórmula genelal</param>
        /// <param name="discriminante">de la fórmula general</param>
        /// <returns>El valor según el resultado</returns>
        public int valorResultado(double a, double discri)
        {
            var accionValorResultado = new Accion.OperacionCuadratica();
            var resultado = accionValorResultado.Resultado(a, discri);
            return resultado;
        }
    }
}