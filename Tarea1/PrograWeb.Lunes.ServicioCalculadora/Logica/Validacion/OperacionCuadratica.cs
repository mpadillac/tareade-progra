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
            bool Resultado = true;
            // se valida que el valor de a sea diferente a 0
            
            Resultado = !(a == 0);
            return Resultado;
        }
    }
}