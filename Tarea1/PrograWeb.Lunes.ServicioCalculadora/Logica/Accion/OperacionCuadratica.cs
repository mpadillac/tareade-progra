using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.ServicioCalculadora.Logica.Accion
{
    public class OperacionCuadratica
    {
        private IList<string> ListaDeErrores = new List<string>(new string[] { });
        public IList<string> MiListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double calcularpRaiz(double a, double b, double discri)
        {
            var validacion = new Validacion.OperacionCuadratica();
            var primeraRaiz = 0.0;
            if (validacion.ACorrecto(a))
                primeraRaiz = ((-1 * b) + Math.Sqrt(discri)) / (2 * a);
            else
                MiListaDeErrores.Add("La constante A debe ser diferente a 0 y el discriminante mayor o igual a 0");

            return primeraRaiz;
        }

        internal double calcularsRaiz(double a, double b, double discri)
        {
            var validacion = new Validacion.OperacionCuadratica();
            var segundaRaiz = 0.0;
            if (validacion.AYDiscriminanteCorrecto(a, discri))
                segundaRaiz = ((-1 * b) - Math.Sqrt(discri)) / (2 * a);
            else

                MiListaDeErrores.Add("La constante A debe ser diferente a 0 y el discriminante mayor o igual a 0");
            return segundaRaiz;
        }

        internal double calcularDiscri(double a, double b, double c)
        {
            var validacionA = new Validacion.OperacionCuadratica();
            var resultado = 0.0;

            if (validacionA.ACorrecto(a))
                resultado = ((potencia(b)) - (4 * a * c));
            
            else
                MiListaDeErrores.Add("La variable A no puede ser 0");
            return resultado;
        }

        //prueba
        internal int Resultado(double a, double discri)
        {
            var resultado = 0;

            if (a != 0 && discri > 0)
            {
                resultado = 0;
            }

            if (a == 0)
                resultado = 1;
            else if (discri < 0)
                resultado = 2;

            return resultado;
        }




        internal double potencia(double laBase)
        {
            var resultado = 0.0;
            resultado = Math.Pow(laBase, 2);
            return resultado;
        }
    }
}