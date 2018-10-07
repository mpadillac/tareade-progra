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
                return MiListaDeErrores;
            }
        }

        internal double Cuadratica(double a, double b, double c)
        {
            // valide que los parámetros sean correctos
            var laValidacion = new Logica.Validacion.OperacionCuadratica();
            double Resultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(a, b, c))
                

                //Falta validar el resultado

                Resultado = 0;

            else
                MiListaDeErrores.Add("El valor de a no puede poseer valor 0.");
            return Resultado;
        }
    }
}