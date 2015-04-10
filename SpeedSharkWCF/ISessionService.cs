using SpeedSharkServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SpeedSharkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISessionService" in both code and config file together.
    [ServiceContract]
    public interface ISessionService
    {
        [OperationContract]
        void CreateSession(int cargoId, string departureTime, string arrivalTime, int truckId, string destAddress,
            string destCity);

        [OperationContract]
        void UpdateSession(int sessionId, int cargoId, string departureTime, string arrivalTime, int truckId,
            string destAddress, string destCity);

        [OperationContract]
        Session GetSession(int sessionId);

        [OperationContract]
        List<Session> GetSessions();

        [OperationContract]
        List<Session> GetOngoingSession();
    }

    [DataContract]
    public class Session
    {
        private int sessionId;
        private int cargoId;
        private DateTime departureTime;
        private DateTime arrivalTime;
        private int truckId;
        private string destAddress;
        private string destCity;

        [DataMemberAttribute]
        public int CargoId
        {
            get { return cargoId; }
            set { cargoId = value; }
        }

        [DataMemberAttribute]
        public DateTime DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }

        [DataMemberAttribute]
        public DateTime ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; }
        }

        [DataMemberAttribute]
        public int TruckId
        {
            get { return truckId; }
            set { truckId = value; }
        }

        [DataMemberAttribute]
        public string DestAddress
        {
            get { return destAddress; }
            set { destAddress = value; }
        }

        [DataMemberAttribute]
        public string DestCity
        {
            get { return destCity; }
            set { destCity = value; }
        }

        [DataMemberAttribute]
        public int SessionId
        {
            get { return sessionId; }
            set { sessionId = value; }
        }
    }
}
