using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedSharkServer.Model;

namespace SpeedSharkServer.DBHandler
{
    public static class OrderHandler
    {
        public static void CreateOrder(string custCVR, double price, int sessionId, int cargoId, string status)
        {
            using (var db = new SpeedSharkModelDataContext())
            {
                var order = new Order();

                int maxOrderId = 0;
                var query = db.Orders.OrderByDescending(ord => ord.orderId).SingleOrDefault().orderId;
                if (query != 0 && query != null)
                {
                    maxOrderId = query;
                }

                string orderNo = DateTime.Now.ToString("yy-MM-dd") + "/" + Convert.ToString(maxOrderId + 1);

                order.orderNo = orderNo;
                order.custCVR = custCVR;
                order.price = price;
                order.sessionId = sessionId;
                order.cargoId = cargoId;
                order.status = status;
                db.Orders.InsertOnSubmit(order);

                db.SubmitChanges();

            }
        }

        public static void UpdateOrder(int orderId, string custCVR, double price, int sessionId, int cargoId,
            string status)
        {
            var order = new Order();

            using (var db = new SpeedSharkModelDataContext())
            {
                order = db.Orders.SingleOrDefault(ord => ord.orderId == orderId);

                if (order != null)
                {
                    order.custCVR = custCVR;
                    order.price = price;
                    order.sessionId = sessionId;
                    order.cargoId = cargoId;
                    order.status = status;

                    db.SubmitChanges();
                }
            }
        }

        public static Order GetOrder(int orderId)
        {
            var order = new Order();

            using (var db = new SpeedSharkModelDataContext())
            {
                order = db.Orders.SingleOrDefault(ord => ord.orderId == orderId);
            }

            return order;
        }

        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();

            using (var db = new SpeedSharkModelDataContext())
            {
                var query = db.Orders.ToList();
                orders = query;
            }

            return orders;
        }

        public static List<Order> GetCompletedOrders()
        {
            List<Order> orders = new List<Order>();

            using (var db = new SpeedSharkModelDataContext())
            {
                var query = db.Orders.Where(ord => ord.status.Equals("Completed")).ToList();
                orders = query;
            }

            return orders;
        }
    }
}
