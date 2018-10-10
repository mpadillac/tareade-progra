using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.ServicioCalculadora.Logica.Accion
{
    public class OperacionCuadratica
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return ListaDeErrores;
            }
        }

        internal double calcularPrimeraRaiz(double variableA, double variableB, double discriminante)
        {
            var validacion = new Validacion.OperacionCuadratica();
            var primeraRaiz = 0.0;
            if (validacion.elementoADiscriminanteCorrecto(variableA, discriminante))
                primeraRaiz = ((-1 * variableB) + Math.Sqrt(discriminante)) / (2 * variableA);
            else
                ListaDeErrores.Add("La variable a debe ser diferente a cero y el discriminante mayor o igual a cero.");

            return primeraRaiz;
        }

        internal double calcularSegundaRaiz(double variableA, double variableB, double discriminante)
        {
            var validacion = new Validacion.OperacionCuadratica();
            var segundaRaiz = 0.0;
            if (validacion.elementoADiscriminanteCorrecto(variableA, discriminante))
                segundaRaiz = ((-1 * variableB) - Math.Sqrt(discriminante)) / (2 * variableA);
            else

                ListaDeErrores.Add("La variable a debe ser diferente a cero y el discriminante mayor o igual a cero.");
            return segundaRaiz;
        }

        internal double calcularDiscriminante(double variableA, double variableB, double variableC)
        {
            var validacionA = new Validacion.OperacionCuadratica();
            var resultado = 0.0;
            if (validacionA.elementoACorrecto(variableA))
                resultado = ((potencia(variableB)) - (4 * variableA * variableC));
            //resultado = (Math.Pow(variableB, 2)) - (4 * variableA * variableC);
            else
                ListaDeErrores.Add("La variable a no puede tener como valor el 0.");
            return resultado;
        }

        //Incompleto o malo
        internal int valorResultado(double variableA, double discriminante)
        {
            var resultado = 0;

            if (variableA != 0 && discriminante > 0)
            {
                resultado = 0;
            }

            if (variableA == 0)
                resultado = 1;
            else if (discriminante < 0)
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