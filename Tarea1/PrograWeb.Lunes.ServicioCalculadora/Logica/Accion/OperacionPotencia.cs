using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.ServicioCalculadora.Logica.Accion
{
    public class OperacionPotencia
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList <string> ListaDeErrores { get
            {
                return MiListaDeErrores;
            } 
             }

        internal double Potencia(double laBase, double elExponente)
        {
            // valide que los parámetros sean correctos
            var laValidacion = new Logica.Validacion.OperacionPotencia();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(laBase, elExponente))
                elResultado =  Math.Pow(laBase, elExponente);
            else
                MiListaDeErrores.Add("La potencia 0 no está definida para el exponente 0.");
            return elResultado;
        }
    }
}