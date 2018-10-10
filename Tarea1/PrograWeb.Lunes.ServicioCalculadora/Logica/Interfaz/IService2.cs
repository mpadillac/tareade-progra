using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PrograWeb.Lunes.ServicioCalculadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOperacioncuadratica
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        Formula obtenerEcuacion(double a, double b, double c);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Formula
    {
        private double discri;
        private double pRaiz;
        private double sRaiz;
        private int cod_Resultado;

        [DataMember]
        public double Discri
        {
            get { return discri; }
            set { discri = value; }
        }

        [DataMember]
        public double PrimeraRaiz
        {
            get { return pRaiz; }
            set { pRaiz = value; }
        }

        [DataMember]
        public double SegundaRaiz
        {
            get { return sRaiz; }
            set { sRaiz = value; }
        }

        [DataMember]
        public int CodResultado
        {
            get { return cod_Resultado; }
            set { cod_Resultado = value; }
        }
    }
}
