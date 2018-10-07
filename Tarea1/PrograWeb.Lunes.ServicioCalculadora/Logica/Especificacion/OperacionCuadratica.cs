using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.ServicioCalculadora.Logica.Especificacion
{
    public class OperacionCuadratica
    {
        /// <summary>
        /// Función que devuelve el valor de una operación cuadrática
        /// </summary>
        /// <param name="a">primer constante * x al cuadrado</param>
        /// <param name="b">segunda constante * x</param>
        /// <param name="c">tercera constante</param>
        /// <returns>el valor de las soluciones</returns>

        public double Cuadratica(double a, double b, double c)
        {
            var laAccion = new PrograWeb.Lunes.ServicioCalculadora.Logica.Accion.OperacionCuadratica();

            double Resultado = laAccion.Cuadratica(a, b, c);

            return Resultado;
        }
    }
}