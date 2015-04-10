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


        public void CreateSession(int cargoId, string departureTime, string arrivalTime, int truckId, string destAddress, string destCity)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                    sessionCtr.CreateSession( cargoId,  departureTime,  arrivalTime,  truckId,  destAddress,  destCity);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }

        public void UpdateSession(int sessionId, int cargoId, string departureTime, string arrivalTime, int truckId, string destAddress, string destCity)
        {
            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    sessionCtr.UpdateSession( sessionId,  cargoId,  departureTime,  arrivalTime,  truckId,  destAddress,  destCity);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }
        }

        public Session GetSession(int sessionId)
        {
            Session serviceSession = new Session();

            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {
                    serviceSession.SessionId = sessionCtr.GetSession(sessionId).sessionId;
                    serviceSession.CargoId = sessionCtr.GetSession(sessionId).cargoId;
                    serviceSession.DepartureTime = sessionCtr.GetSession(sessionId).departureTime;
                    serviceSession.ArrivalTime = sessionCtr.GetSession(sessionId).arrivalTime;
                    serviceSession.DestAddress = sessionCtr.GetSession(sessionId).destAddress;
                    serviceSession.DestCity = sessionCtr.GetSession(sessionId).destCity;
                    serviceSession.TruckId = sessionCtr.GetSession(sessionId).truckId;
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

        public List<Session> GetSessions()
        {
            List<Session> sessions = new List<Session>();

            if (System.Threading.Monitor.TryEnter(obj4, 45000))
            {
                try
                {
                    List<SpeedSharkServer.Model.Session> returnList = new List<SpeedSharkServer.Model.Session>();

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

        public List<Session> GetOngoingSession()
        {
            List<Session> sessions = new List<Session>();

            if (System.Threading.Monitor.TryEnter(obj5, 45000))
            {
                try
                {
                    List<SpeedSharkServer.Model.Session> returnList = new List<SpeedSharkServer.Model.Session>();

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
    }
}
