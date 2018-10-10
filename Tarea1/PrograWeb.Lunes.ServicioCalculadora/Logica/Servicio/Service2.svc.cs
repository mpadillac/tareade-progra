using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PrograWeb.Lunes.ServicioCalculadora.Logica.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service2" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service2.svc o Service2.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service2 : IOperacioncuadratica
    {
        

        //<summary>
        /// Función para resolver la ecuación cuadratica por medio de la fórmula general
        /// </summary>
        /// <param name="variableA">de la fórmula ax^2 + bx + c</param>
        /// <param name="variableB">de la fórmula ax^2 + bx + c</param>
        /// <param name="variableC">de la fórmula ax^2 + bx + c</param>
        /// <returns>El valor de la fórmula general</returns>
        public Formula obtenerEcuacion(double variableA, double variableB, double variableC)
        {
            var composicionFG = new Formula ();
            Logica.Especificacion.OperacionCuadratica laEspecificacion;
            laEspecificacion = new Logica.Especificacion.OperacionCuadratica();
            var discri = laEspecificacion.Discriminante(variableA, variableB, variableC);

            composicionFG.CodResultado = laEspecificacion.valorResultado(variableA, composicionFG.Discriminante);
            if (composicionFG.CodResultado == 0)
            {
                composicionFG.Discriminante = discri;
                composicionFG.PrimeraRaiz = laEspecificacion.primeraRaiz(variableA, variableB, discri);
                composicionFG.SegundaRaiz = laEspecificacion.segundaRaiz(variableA, variableB, composicionFG.Discriminante);

            }
            else
            {
                composicionFG.PrimeraRaiz = 0;
                composicionFG.SegundaRaiz = 0;
            }

            return composicionFG;
        }



        public string GetData(int value)
        {
            throw new NotImplementedException();
        }
    }
}
