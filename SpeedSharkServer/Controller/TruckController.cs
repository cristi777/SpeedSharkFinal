using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedSharkServer.Model;
using SpeedSharkServer.DBHandler;

namespace SpeedSharkServer.Controller
{
   public class TruckController
    {
       //Singleton
       private static TruckController instance;

       private TruckController() { }

       public static TruckController TruckControllerInstance
       {
           get
           {
               if (instance == null)
               {
                   instance = new TruckController();
               }
               return instance;
           }
       }

       public void createTruck(string status)
       {
           TruckHandler.CreateTruck(status);
       }

       public void updateTruck(int truckId, string status)
       {
           TruckHandler.UpdateTruck(truckId, status);
       }

       public Truck getTruck(int truckId)
       {
           return TruckHandler.GetTruck(truckId);
       }

       //get all trucks
       public List<Truck> getTrucks()
       {
           return TruckHandler.GetTrucks();
       }

       public List<int> getFunctionalTrucks()
       {
           return TruckHandler.GetFunctionalTrucks();
       }

       public List<int> getAvailableTrucks()
       {
           return TruckHandler.GetAvailableTrucks();
       }
    }
}
