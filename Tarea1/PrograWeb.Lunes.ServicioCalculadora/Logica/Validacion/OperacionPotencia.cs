using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.ServicioCalculadora.Logica.Validacion
{
    public class OperacionPotencia
    {
        public bool LosOperadoresSonCorrectos (double laBase, double elExponente)
        {
            bool elResultado = true;
            // valido que los valores de los parámetros no arrojen un error matemático
            //elResultado = (laBase != 0.0 || elExponente != 0.0);
            elResultado = !(laBase == 0 && elExponente == 0);
            return elResultado;
        }
    }
}