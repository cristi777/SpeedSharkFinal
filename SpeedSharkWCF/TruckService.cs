using SpeedSharkServer.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SpeedSharkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TruckService" in both code and config file together.
    public class TruckService : ITruckService
    {
        private static TruckController truckCtr = TruckController.TruckControllerInstance;

        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();
        private static readonly System.Object obj3 = new System.Object();
        private static readonly System.Object obj4 = new System.Object();
        private static readonly System.Object obj5 = new System.Object();
        private static readonly System.Object obj6 = new System.Object();



        public void insertTruck(string status)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                   truckCtr.createTruck(status);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }
        //works
        public void updateTruck(int truckId, string status)
        {
            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    truckCtr.updateTruck(truckId, status);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }
        }
        //works
        public Truck getTruck(int truckId)
        {
            Truck serviceTruck = new Truck();

            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {
                    serviceTruck.TruckId = truckCtr.getTruck(truckId).truckId;
                    serviceTruck.Status = truckCtr.getTruck(truckId).status;
                }
                catch (NullReferenceException)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj3);
                }
            }

            return serviceTruck;
        }
        //no

        public List<Truck> getTrucks()
        {
            List<Truck> trucks = new List<Truck>();

            if (System.Threading.Monitor.TryEnter(obj4, 45000))
            {
                try
                {
                    List<SpeedSharkServer.Model.Truck> returnList = new List<SpeedSharkServer.Model.Truck>();

                    if (returnList.Count != 0)
                    {
                        foreach (SpeedSharkServer.Model.Truck hostedTruck in returnList)
                        {
                            Truck serviceTruck = new Truck();

                            serviceTruck.TruckId = hostedTruck.truckId;
                            serviceTruck.Status = hostedTruck.status;

                            trucks.Add(serviceTruck);
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

            return trucks;
        }
        //works

        public List<Truck> getFunctionalTrucks()
        {
            List<Truck> trucks = new List<Truck>();

            if (System.Threading.Monitor.TryEnter(obj5, 45000))
            {
                try
                {
                    List<SpeedSharkServer.Model.Truck> returnList = new List<SpeedSharkServer.Model.Truck>();

                    if (returnList.Count != 0)
                    {
                        foreach (SpeedSharkServer.Model.Truck hostedTruck in returnList)
                        {
                            Truck serviceTruck = new Truck();

                            serviceTruck.TruckId = hostedTruck.truckId;
                            serviceTruck.Status = hostedTruck.status;

                            trucks.Add(serviceTruck);
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
            return trucks;
        } 

//works

        public List<Truck> getAvailableTrucks()
        {
            List<Truck> trucks = new List<Truck>();

            if (System.Threading.Monitor.TryEnter(obj6, 45000))
            {
                try
                {
                    List<SpeedSharkServer.Model.Truck> returnList = new List<SpeedSharkServer.Model.Truck>();

                    if (returnList.Count != 0)
                    {
                        foreach (SpeedSharkServer.Model.Truck hostedTruck in returnList)
                        {
                            Truck serviceTruck = new Truck();

                            serviceTruck.TruckId = hostedTruck.truckId;
                            serviceTruck.Status = hostedTruck.status;

                            trucks.Add(serviceTruck);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj6);
                }
            }

            return trucks;
        }

        //done
    }
}
