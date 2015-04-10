using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SpeedSharkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in both code and config file together.
    public class OrderService : IOrderService
    {
        public void DoWork()
        {
        }

        public void createOrder(string custCVR, double price, int sessionId, int cargoId, string status)
        {
            throw new NotImplementedException();
        }

        public void updateOrder(int orderId, string custCVR, double price, int sessionId, int cargoId, string status)
        {
            throw new NotImplementedException();
        }

        public Order getOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> getOrders()
        {
            throw new NotImplementedException();
        }

        public List<Order> getComletedOrders()
        {
            throw new NotImplementedException();
        }
    }
}
