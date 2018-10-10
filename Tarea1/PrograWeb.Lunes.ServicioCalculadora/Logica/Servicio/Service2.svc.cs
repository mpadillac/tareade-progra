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
        /// <param name="constante A">de la ecuación cuadrática/param>
        /// <param name="constante B">de la ecuación cuadrática</param>
        /// <param name="constante C">de la ecuación cuadrática</param>
        /// <returns>El valor de la fórmula general</returns>
        public Formula obtenerEcuacion(double a, double b, double c)
        {
            var compformula = new Formula ();
            Logica.Especificacion.OperacionCuadratica laEspecificacion;
            laEspecificacion = new Logica.Especificacion.OperacionCuadratica();
            var discri = laEspecificacion.Discriminante(a, b, c);

            compformula.CodResultado = laEspecificacion.valorResultado(a, compformula.Discri);
            if (compformula.CodResultado == 0)
            {
                compformula.Discri = discri;
                compformula.PrimeraRaiz = laEspecificacion.pRaiz(a, b, discri);
                compformula.SegundaRaiz = laEspecificacion.sRaiz(a, b, compformula.Discri);

            }
            else
            {
                compformula.PrimeraRaiz = 0;
                compformula.SegundaRaiz = 0;
            }

            return compformula;
        }



        public string GetData(int value)
        {
            throw new NotImplementedException();
        }
    }
}
