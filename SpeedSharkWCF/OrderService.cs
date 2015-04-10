using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SpeedSharkServer.Controller;

namespace SpeedSharkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in both code and config file together.
    public class OrderService : IOrderService
    {
        private static OrderController orderCtr = OrderController.OrderControllerInstance;

        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();
        private static readonly System.Object obj3 = new System.Object();
        private static readonly System.Object obj4 = new System.Object();
        private static readonly System.Object obj5 = new System.Object();
        private static readonly System.Object obj6 = new System.Object();
        
        
        public void insertOrder(string custCVR, double price, int sessionId, int cargoId, string status)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                    orderCtr.insertOrder(custCVR, price, sessionId, cargoId, status);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }

        public void updateOrder(int orderId, string custCVR, double price, int sessionId, int cargoId, string status)
        {
            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    orderCtr.updateOrder(orderId, custCVR, price, sessionId, cargoId, status);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }
        }

        public Order getOrder(int orderId)
        {
            Order serviceOrder = new Order();

            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {
                    serviceOrder.OrderId = orderCtr.getOrder(orderId).orderId;
                    serviceOrder.CustCvr = orderCtr.getOrder(orderId).custCVR;
                    serviceOrder.Price = orderCtr.getOrder(orderId).price;
                    serviceOrder.SessionId = orderCtr.getOrder(orderId).sessionId;
                    serviceOrder.CargoId = orderCtr.getOrder(orderId).cargoId;
                    serviceOrder.Status = orderCtr.getOrder(orderId).status;
                }
                catch (NullReferenceException)
                {

                }
                finally
                {
                    System.Threading.Monitor.Exit(obj3);
                }
            }

            return serviceOrder;
        }

        public List<Order> getOrders()
        {
            List<Order> orders = new List<Order>();

            if (System.Threading.Monitor.TryEnter(obj4, 45000))
            {
                try
                {
                    List<SpeedSharkServer.Model.Order> returnList = orderCtr.getOrders();

                    if (returnList.Count != 0)
                    {
                        foreach (SpeedSharkServer.Model.Order hostOrder in returnList)
                        {
                            Order serviceOrder = new Order();

                            serviceOrder.OrderId = hostOrder.orderId;
                            serviceOrder.CustCvr = hostOrder.custCVR;
                            serviceOrder.Price = hostOrder.price;
                            serviceOrder.SessionId = hostOrder.sessionId;
                            serviceOrder.CargoId = hostOrder.cargoId;
                            serviceOrder.Status = hostOrder.status;

                            orders.Add(serviceOrder);
                        }
                    }
                }
                catch (NullReferenceException)
                {

                }
                finally
                {
                    System.Threading.Monitor.Exit(obj4);
                }
            }

            return orders;
        }

        public List<Order> getComletedOrders()
        {
            List<Order> orders = new List<Order>();

            if (System.Threading.Monitor.TryEnter(obj5, 45000))
            {
                try
                {
                    List<SpeedSharkServer.Model.Order> returnList = orderCtr.getComletedOrders();

                    if (returnList.Count != 0)
                    {
                        foreach (SpeedSharkServer.Model.Order hostOrder in returnList)
                        {
                            Order serviceOrder = new Order();

                            serviceOrder.OrderId = hostOrder.orderId;
                            serviceOrder.CustCvr = hostOrder.custCVR;
                            serviceOrder.Price = hostOrder.price;
                            serviceOrder.SessionId = hostOrder.sessionId;
                            serviceOrder.CargoId = hostOrder.cargoId;
                            serviceOrder.Status = hostOrder.status;

                            orders.Add(serviceOrder);
                        }
                    }
                }
                catch (NullReferenceException)
                {

                }
                finally
                {
                    System.Threading.Monitor.Exit(obj5);
                }
            }

            return orders;
        }

        public void cancelOrder(int sessionId)
        {
            if (System.Threading.Monitor.TryEnter(obj6, 45000))
            {
                try
                {
                    orderCtr.cancelOrder(sessionId);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj6);
                }
            }
        }
    }
}
