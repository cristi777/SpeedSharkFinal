using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SpeedSharkServer.Model;

namespace SpeedSharkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderService" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        void insertOrder(string custCVR, double price, int sessionId, int cargoId, string status);
   
        [OperationContract]
        void updateOrder(int orderId, string custCVR, double price, int sessionId, int cargoId, string status);
    
        [OperationContract]
        Order getOrder(int orderId);

        [OperationContract]
        List<Order> getOrders();

        [OperationContract]
        List<Order> getComletedOrders();

    }

    [DataContract]
    public class Order
    {
        private int orderId;
        private string custCVR;
        private double price;
        private int sessionId;
        private int cargoId;
        private string status;

        [DataMemberAttribute]
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        [DataMemberAttribute]
        public string CustCvr
        {
            get { return custCVR; }
            set { custCVR = value; }
        }

        [DataMemberAttribute]
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        [DataMemberAttribute]
        public int SessionId
        {
            get { return sessionId; }
            set { sessionId = value; }
        }

        [DataMemberAttribute]
        public int CargoId
        {
            get { return cargoId; }
            set { cargoId = value; }
        }

        [DataMemberAttribute]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
