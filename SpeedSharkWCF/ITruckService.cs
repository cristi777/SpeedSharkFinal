using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SpeedSharkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITruckService" in both code and config file together.
    [ServiceContract]
    public interface ITruckService
    {
        [OperationContract]
        void insertTruck(string status);

        [OperationContract]
        void updateTruck(int truckId, string status);

        [OperationContract]
        Truck getTruck(int truckId);

        [OperationContract]
        List<Truck> getTrucks();

        [OperationContract]
        List<int> getFunctionalTrucks();

        [OperationContract]
        List<int> getAvailableTrucks();

    
    }

    [DataContract]
    public class Truck
    {
        private int truckId;
        private string status;

        [DataMemberAttribute]
        public int TruckId
        {
            get { return truckId; }
            set { truckId = value; }
        }

        [DataMemberAttribute]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
