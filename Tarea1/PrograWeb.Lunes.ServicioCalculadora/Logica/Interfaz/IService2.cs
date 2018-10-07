using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PrograWeb.Lunes.ServicioCalculadora.Logica.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService2" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]

        //cuadratica Cuad(double a, double b, double c);

        double Cuad(double a, double b, double c);
    }

    public class cuadratica
    {
        string praiz;
        string sraiz;
        string discri;
        string codSalida;

        [DataMember]
        public string Discri { get => discri; set => discri = value; }
        [DataMember]
        public string Sraiz { get => sraiz; set => sraiz = value; }
        [DataMember]
        public string Praiz { get => praiz; set => praiz = value; }
        [DataMember]
        public string CodSalida { get => codSalida; set => codSalida = value; }

    }
}
