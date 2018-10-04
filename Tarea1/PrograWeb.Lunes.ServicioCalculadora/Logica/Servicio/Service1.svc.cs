using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PrograWeb.Lunes.ServicioCalculadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ICalculadoraService
    {
        /// <summary>
        /// Función que devuelve el valor de una base elevada a una potencia
        /// </summary>
        /// <param name="laBase">la base de la operación</param>
        /// <param name="elExponente">el exponente de la operación</param>
        /// <returns>el valor de la base elevado a la potencia</returns>
        public double Potencia(double laBase, double elExponente)
        {
            // forma 1
            //var laEspecificacion = new Logica.Especificacion.OperacionPotencia();
            // forma 2
            Logica.Especificacion.OperacionPotencia laEspecificacion;
            laEspecificacion = new Logica.Especificacion.OperacionPotencia();
            var elResultado = laEspecificacion.Potencia(laBase, elExponente);
            return elResultado;

        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
