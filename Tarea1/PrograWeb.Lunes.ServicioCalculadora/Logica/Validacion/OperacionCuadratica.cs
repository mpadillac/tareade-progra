using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.ServicioCalculadora.Logica.Validacion
{
    public class OperacionCuadratica
    {
        public bool LosOperadoresSonCorrectos(double a, double b, double c)
        {
            bool Result = true;
            // se validaque A sea diferente de 0

            Result = !(a == 0);
            return Result;
        }
    }
}