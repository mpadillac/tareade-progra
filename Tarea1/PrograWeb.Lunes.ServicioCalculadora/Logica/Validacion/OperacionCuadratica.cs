using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.ServicioCalculadora.Logica.Validacion
{
    public class OperacionCuadratica
    {
        public bool ACorrecto(double a)
        {
            bool resultado = true;
            resultado = !(a == 0);
            return resultado;
        }

        public bool AYDiscriminanteCorrecto(double a, double discri)
        {
            bool resultado = true;
            resultado = !(a == 0 && discri < 0);
            return resultado;
        }

        public bool ResultadoCorrecto(int valorResultado, double primeraRaiz)
        {
            bool resultado0 = true;
            bool resultado1 = true;
            bool resultado2 = true;

            bool resultadoDado = Convert.ToBoolean(valorResultado);

            if (valorResultado == 0)
            {
                return resultado0;
            }
            else if (valorResultado == 1)
            {
                return resultado1;
            }
            else if (valorResultado == 2)
            {
                return resultado2;
            }

            return resultadoDado;

        }
    }
}