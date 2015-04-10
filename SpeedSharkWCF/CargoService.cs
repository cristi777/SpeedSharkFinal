using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SpeedSharkServer.Controller;

namespace SpeedSharkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CargoService" in both code and config file together.
    public class CargoService : ICargoService
    {
        private static CargoController cargoCtr = CargoController.CargoControllerInstance;

        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();
        private static readonly System.Object obj3 = new System.Object();
        private static readonly System.Object obj4 = new System.Object();

        public void insertCargo(double weight)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                    cargoCtr.insertCargo(weight);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }

        public Cargo getCargo(int cargoId)
        {
            Cargo serviceCargo = new Cargo();

            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    serviceCargo.CargoId = cargoCtr.getCargo(cargoId).cargoId;
                    serviceCargo.Weight = cargoCtr.getCargo(cargoId).weight;
                }
                catch (NullReferenceException)
                {

                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }
            return serviceCargo;
        }

        public void updateCargo(int cargoId, double weight)
        {
            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {
                    cargoCtr.updateCargo(cargoId, weight);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj3);
                }
            }
        }

        public List<Cargo> getCargoes()
        {
            List<Cargo> cargoes = new List<Cargo>();

            if (System.Threading.Monitor.TryEnter(obj4, 45000))
            {
                try
                {
                    List<SpeedSharkServer.Model.Cargo> returnList = cargoCtr.getCargoes();

                    if (returnList.Count != 0)
                    {
                        foreach (SpeedSharkServer.Model.Cargo hostCargo in returnList)
                        {
                            Cargo serviceCargo = new Cargo();

                            serviceCargo.CargoId = hostCargo.cargoId;
                            serviceCargo.Weight = hostCargo.weight;
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
            return cargoes;
        }

    }
}
