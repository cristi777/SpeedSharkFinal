using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedSharkServer.DBHandler;
using SpeedSharkServer.Model;

namespace SpeedSharkServer.Controller
{
    public class CargoController
    {
        //Singleton - all cargos
        private static CargoController instance;

        private CargoController(){}

        public static CargoController CargoControllerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CargoController();
                }
                return instance;
            }
        }

        public void insertCargo(double weight)
        {
            CargoHandler.InsertCargo(weight);
        }

        public Cargo getCargo(int cargoId)
        {
            return CargoHandler.GetCargo(cargoId);
        }

        public void updateCargo(int cargoId, double weight)
        {
            CargoHandler.UpdateCargo(cargoId, weight);
        }

        public List<Cargo> getCargoes()
        {
            return CargoHandler.GetCargoes();
        }

        public int getMaxId()
        {
            return CargoHandler.GetMaxId();
        }
    }
}
