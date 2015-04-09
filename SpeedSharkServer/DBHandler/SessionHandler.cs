using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedSharkServer.Model;

namespace SpeedSharkServer.DBHandler
{
    public static class SessionHandler
    {
        public static void CreateSession(int cargoId, string departureTime, string arrivalTime, int truckId,
            string destAddress, string destCity)
        {
            
            using (var db = new SpeedSharkModelDataContext())
            {
                var session = new Session();

                var deparTime = Convert.ToDateTime(departureTime);
                var arriTime = Convert.ToDateTime(arrivalTime);

                session.cargoId = cargoId;
                session.departureTime = deparTime;
                session.arrivalTime = arriTime;
                session.truckId = truckId;
                session.destCity = destCity;
                session.destAddress = destAddress;
                db.Sessions.InsertOnSubmit(session);

                db.SubmitChanges();
           }
        }

        public static void UpdateSession(int sessionId, int cargoId, string departureTime, string arrivalTime,
            int truckId, string destAddress, string destCity)
        {
            var session = new Session();

            using (var db = new SpeedSharkModelDataContext())
            {
                session = db.Sessions.SingleOrDefault(sess => sess.sessionId == sessionId);
                if (session != null)
                {
                    var deparTime = Convert.ToDateTime(departureTime);
                    var arriTime = Convert.ToDateTime(arrivalTime);

                    session.cargoId = cargoId;
                    session.departureTime = deparTime;
                    session.arrivalTime = arriTime;
                    session.truckId = truckId;
                    session.destCity = destCity;
                    session.destAddress = destAddress;

                    db.SubmitChanges();
                }
            }
        }

        public static Session GetSession(int sessionId)
        {
            var session = new Session();

            using (var db = new SpeedSharkModelDataContext())
            {
                session = db.Sessions.SingleOrDefault(sess => sess.sessionId == sessionId);
            }

            return session;
        }

        public static List<Session> GetSessions()
        {
            var sessions = new List<Session>();

            using (var db = new SpeedSharkModelDataContext())
            {
                var query = db.Sessions.ToList();
                sessions = query;
            }

            return sessions;
        }

        public static List<Session> GetOngoingSession()
        {
            var sessions = new List<Session>();

            using (var db = new SpeedSharkModelDataContext())
            {
                var query = db.Sessions.Where(sess => sess.arrivalTime >= DateTime.Now).ToList();
                sessions = query;
            }

            return sessions;
        }
    }
}
