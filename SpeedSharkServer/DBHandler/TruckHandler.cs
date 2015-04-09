using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using SpeedSharkServer.Model;

namespace SpeedSharkServer.DBHandler
{
    public static class TruckHandler
    {
        public static void CreateTruck(string status)
        {
            using (var db = new SpeedSharkModelDataContext())
            {
                var truck = new Truck();
                truck.status = status;
                db.Trucks.InsertOnSubmit(truck);

                db.SubmitChanges();
            }
        }

        public static void UpdateTruck(int truckId, string status)
        {
            var truck = new Truck();

            using (var db = new SpeedSharkModelDataContext())
            {
                truck = db.Trucks.SingleOrDefault(trk => trk.truckId == truckId);

                if (truck != null)
                {
                    truck.status = status;
                    db.SubmitChanges();
                }
            }
        }

        public static Truck GetTruck(int truckId)
        {
            var truck = new Truck();

            using (var db = new SpeedSharkModelDataContext())
            {
                truck = db.Trucks.SingleOrDefault(trk => trk.truckId == truckId);
            }

            return truck;
        }

        public static List<Truck> GetTrucks()
        {
            List<Truck> trucks = new List<Truck>();

            using (var db = new SpeedSharkModelDataContext())
            {
                var query = db.Trucks.ToList();
                trucks = query;
            }

            return trucks;
        }

        //get the trucks that are not currently in service
        public static List<Truck> GetFunctionalTrucks()
        {
            var trucks = new List<Truck>();

            using (var db = new SpeedSharkModelDataContext())
            {
                var query = db.Trucks.Where(trk => trk.status.Equals("Available") == true).ToList();
                trucks = query;
            }

            return trucks;
        }

        //get the trucks that are not in service and do not have any future session from now
        public static List<Truck> GetAvailableTrucks()
        {
            var availableTrucks = new List<Truck>();

            using (var db = new SpeedSharkModelDataContext())
            {
                var query1 =
                    db.Sessions.Where(sess => sess.arrivalTime < DateTime.Now)
                        .AsEnumerable()
                        .Select(sess => sess.truckId).Distinct()
                        .ToArray<int>();

                var query2 =
                    db.Sessions.Where(sess => sess.arrivalTime >= DateTime.Now)
                        .AsEnumerable()
                        .Select(sess => sess.truckId).Distinct()
                        .ToArray<int>();

                var array1 = query1;
                var array2 = query2;

                var arrayFinal = array1.Except(array2).ToArray<int>();

                foreach (int truckId in arrayFinal)
                {
                    var truck = new Truck();
                    truck = db.Trucks.SingleOrDefault(trk => trk.truckId == truckId && trk.status == "Available");
                    availableTrucks.Add(truck);
                }

            }

            return availableTrucks;
        }
    }
}
