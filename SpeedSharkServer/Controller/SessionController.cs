﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedSharkServer.DBHandler;
using SpeedSharkServer.Model;

namespace SpeedSharkServer.Controller
{
   public class SessionController
    {
        private static SessionController instance;    //Singleton]

        private SessionController()
        {

        }

        public static SessionController SessionControllerInstnance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SessionController();
                }
                return instance;
            }
        }

        public void insertSession(int cargoId, string departureTime, string arrivalTime, int truckId, string destAddress, string destCity)
        {
            SessionHandler.CreateSession(cargoId, departureTime, arrivalTime, truckId, destAddress, destCity);
        }

        public void updateSession(int sessionId, int cargoId, string departureTime, string arrivalTime, int truckId, string destAddress, string destCity)
        {
            SessionHandler.UpdateSession(sessionId, cargoId, departureTime, arrivalTime, truckId, destAddress, destCity);
        }

        public Session getSession(int sessionId)
        {
            return SessionHandler.GetSession(sessionId);
        }        
       
        public List<Session> getSessions()
        {
            return SessionHandler.GetSessions();
        }

        public List<Session> getOngoingSessions()
        {
            return SessionHandler.GetOngoingSession();
        }

        public int getMaxId()
        {
            return SessionHandler.GetMaxId();
        
        }
    }
}
