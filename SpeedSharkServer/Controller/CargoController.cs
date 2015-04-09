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

        public void createCargo(double weight)
        {
            CargoHandler.CreateCargo(weight);
        }

        public Cargo getCargo(int cargoId)
        {
            return CargoHandler.GetCargo(cargoId);
        }

        public void updateCargo(int cargoId, double weight)
        {
            CargoHandler.UpdateCargo(cargoId, weight);
        }

        public List<Cargo> GetCargoes()
        {
            return CargoHandler.GetCargoes();
        }
    }
}
