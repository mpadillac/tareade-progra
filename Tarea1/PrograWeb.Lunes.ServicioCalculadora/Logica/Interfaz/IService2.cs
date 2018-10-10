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
        Formula obtenerEcuacion(double variableA, double variableB, double variableC);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Formula
    {
        private double discriminante;
        private double primeraRaiz;
        private double segundaRaiz;
        private int codResultado;

        [DataMember]
        public double Discriminante
        {
            get { return discriminante; }
            set { discriminante = value; }
        }

        [DataMember]
        public double PrimeraRaiz
        {
            get { return primeraRaiz; }
            set { primeraRaiz = value; }
        }

        [DataMember]
        public double SegundaRaiz
        {
            get { return segundaRaiz; }
            set { segundaRaiz = value; }
        }

        [DataMember]
        public int CodResultado
        {
            get { return codResultado; }
            set { codResultado = value; }
        }
    }
}
