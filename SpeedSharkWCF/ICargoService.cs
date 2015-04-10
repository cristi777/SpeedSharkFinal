using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SpeedSharkServer.Model;

namespace SpeedSharkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICargoService" in both code and config file together.
    [ServiceContract]
    public interface ICargoService
    {
        [OperationContract]
        void insertCargo(double weight);

        [OperationContract]
        Cargo getCargo(int cargoId);

        [OperationContract]
        void updateCargo(int cargoId, double weight);

        [OperationContract]
        List<Cargo> getCargoes();

        [OperationContract]
        int getMaxId();
    }

    [DataContract]
    public class Cargo
    {
        private int cargoId;
        private double weight;

        [DataMemberAttribute]
        public int CargoId
        {
            get { return cargoId; }
            set { cargoId = value; }
        }

        [DataMemberAttribute]
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
