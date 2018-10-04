using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.ServicioCalculadora.Logica.Especificacion
{
    public class OperacionPotencia
    {
        /// <summary>
        /// Función que devuelve el valor de una base elevada a una potencia
        /// </summary>
        /// <param name="laBase">la base de la operación</param>
        /// <param name="elExponente">el exponente de la operación</param>
        /// <returns>el valor de la base elevado a la potencia</returns>

        public double Potencia(double laBase, double elExponente)
        {
            var laAccion = new PrograWeb.Lunes.ServicioCalculadora.Logica.Accion.OperacionPotencia();
            double elResultado = laAccion.Potencia(laBase, elExponente);
            return elResultado;
        }

    }
}