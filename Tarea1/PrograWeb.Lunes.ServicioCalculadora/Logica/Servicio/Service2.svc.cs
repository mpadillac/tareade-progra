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
    public class Service2 : IService2
    {
        /// <summary>
        /// Función que devuelve el valor de una operación cuadrática
        /// </summary>
        /// <param name="a">primer constante * x al cuadrado</param>
        /// <param name="b">segunda constante * x</param>
        /// <param name="c">tercera constante</param>
        /// <returns>el valor de las soluciones</returns>
        /// 
        public double Cuad(double a, double b, double c)
        {
            Logica.Especificacion.OperacionCuadratica laEspecificacion;
            laEspecificacion = new Logica.Especificacion.OperacionCuadratica();
            var Resultado = laEspecificacion.Cuadratica(a, b, c);
            return Resultado;

            //throw new NotImplementedException();
        }

        public void DoWork()
        {
        }
    }
}
