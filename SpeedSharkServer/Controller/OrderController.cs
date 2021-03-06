﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedSharkServer.DBHandler;
using SpeedSharkServer.Model;

namespace SpeedSharkServer.Controller
{
    public class OrderController
    {
        //Singleton
        private static OrderController instance;

        private OrderController() { }

        public static OrderController OrderControllerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderController();
                }
                return instance;
            }
        }

        public void insertOrder(string custCVR, double price, int sessionId, int cargoId, string status)
        {
            OrderHandler.InsertOrder(custCVR, price, sessionId, cargoId, status);
        }

        public void updateOrder(int orderId, string custCVR, double price, int sessionId, int cargoId, string status)
        {
            OrderHandler.UpdateOrder(orderId, custCVR, price, sessionId, cargoId, status);
        }

        public Order getOrder(int orderId)
        {
            return OrderHandler.GetOrder(orderId);
        }

        public List<Order> getOrders()
        {
            return OrderHandler.GetOrders();
        }

        public List<Order> getComletedOrders()
        {
            return OrderHandler.GetCompletedOrders();
        }

        public void cancelOrder(int sessionId)
        {
            OrderHandler.CancelOrder(sessionId);
        }
    }
}
