using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.PeerResolvers;
using System.Text;
using SpeedSharkServer.Controller;

namespace SpeedSharkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SessionService" in both code and config file together.
    public class SessionService : ISessionService
    {
        private static SessionController sessionCtr = SessionController.SessionControllerInstnance;

        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();
        private static readonly System.Object obj3 = new System.Object();
        private static readonly System.Object obj4 = new System.Object();
        private static readonly System.Object obj5 = new System.Object();
        private static readonly System.Object obj6 = new System.Object();


        public void insertSession(int cargoId, string departureTime, string arrivalTime, int truckId, string destAddress, string destCity)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                    
                    sessionCtr.insertSession( cargoId,  departureTime,  arrivalTime,  truckId,  destAddress,  destCity);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }

        public void updateSession(int sessionId, int cargoId, string departureTime, string arrivalTime, int truckId, string destAddress, string destCity)
        {
            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    sessionCtr.updateSession( sessionId,  cargoId,  departureTime,  arrivalTime,  truckId,  destAddress,  destCity);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }
        }

        public Session getSession(int sessionId)
        {
            Session serviceSession = new Session();

            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {
                    serviceSession.SessionId = sessionCtr.getSession(sessionId).sessionId;
                    serviceSession.CargoId = sessionCtr.getSession(sessionId).cargoId;
                    serviceSession.DepartureTime = sessionCtr.getSession(sessionId).departureTime;
                    serviceSession.ArrivalTime = sessionCtr.getSession(sessionId).arrivalTime;
                    serviceSession.DestAddress = sessionCtr.getSession(sessionId).destAddress;
                    serviceSession.DestCity = sessionCtr.getSession(sessionId).destCity;
                    serviceSession.TruckId = sessionCtr.getSession(sessionId).truckId;
                }
                catch (NullReferenceException)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj3);
                }
            }

            return serviceSession;
        }

        public List<Session> getSessions()
        {
            List<Session> sessions = new List<Session>();

            if (System.Threading.Monitor.TryEnter(obj4, 45000))
            {
                try
                {
                    List<SpeedSharkServer.Model.Session> returnList = sessionCtr.getSessions();

                    if (returnList.Count != 0)
                    {
                        foreach (SpeedSharkServer.Model.Session hostSession in returnList)
                        {
                            Session serviceSession = new Session();

                            serviceSession.SessionId = hostSession.sessionId;
                            serviceSession.CargoId = hostSession.cargoId;
                            serviceSession.DepartureTime = hostSession.departureTime;
                            serviceSession.ArrivalTime = hostSession.arrivalTime;
                            serviceSession.DestAddress = hostSession.destAddress;
                            serviceSession.DestCity = hostSession.destCity;
                            serviceSession.TruckId = hostSession.truckId;

                            sessions.Add(serviceSession);
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

            return sessions;
        }

        public List<Session> getOngoingSessions()
        {
            List<Session> sessions = new List<Session>();

            if (System.Threading.Monitor.TryEnter(obj5, 45000))
            {
                try
                {
                    List<SpeedSharkServer.Model.Session> returnList = sessionCtr.getOngoingSessions();

                    if (returnList.Count != 0)
                    {
                        foreach (SpeedSharkServer.Model.Session hostSession in returnList)
                        {
                            Session serviceSession = new Session();

                            serviceSession.SessionId = hostSession.sessionId;
                            serviceSession.CargoId = hostSession.cargoId;
                            serviceSession.DepartureTime = hostSession.departureTime;
                            serviceSession.ArrivalTime = hostSession.arrivalTime;
                            serviceSession.DestAddress = hostSession.destAddress;
                            serviceSession.DestCity = hostSession.destCity;
                            serviceSession.TruckId = hostSession.truckId;

                            sessions.Add(serviceSession);
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

            return sessions;
        }

        public int getMaxId()
        {
            int maxId = 0;

            if (System.Threading.Monitor.TryEnter(obj6, 45000))
            {
                try
                {
                    maxId = sessionCtr.getMaxId();
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj6);
                }
            }

            return maxId;
        }
    }
}
