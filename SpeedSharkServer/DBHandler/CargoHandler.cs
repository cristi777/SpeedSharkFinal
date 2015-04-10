using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedSharkServer.Model;

namespace SpeedSharkServer.DBHandler
{
    public static class CargoHandler
    {
        public static void InsertCargo(double weight)
        {
            using (var db = new SpeedSharkModelDataContext())
            {
                var cargo = new Cargo();
                cargo.weight = weight;
                db.Cargos.InsertOnSubmit(cargo);

                db.SubmitChanges();
            }
        }

        public static void UpdateCargo(int cargoId, double weight)
        {
            var cargo = new Cargo();

            using (var db = new SpeedSharkModelDataContext())
            {
                cargo = db.Cargos.SingleOrDefault(carg => carg.cargoId == cargoId);

                if (cargo != null)
                {
                    cargo.weight = weight;

                    db.SubmitChanges();
                }
            }
        }

        public static Cargo GetCargo(int cargoId)
        {
            var cargo = new Cargo();

            using (var db = new SpeedSharkModelDataContext())
            {
                cargo = db.Cargos.SingleOrDefault(carg => carg.cargoId == cargoId);
            }

            return cargo;
        }

        public static List<Cargo> GetCargoes()
        {
            List<Cargo> cargoes = new List<Cargo>();

            using (var db = new SpeedSharkModelDataContext())
            {
                var query = db.Cargos.ToList();
                cargoes = query;
            }

            return cargoes;
        }

        public static int GetMaxId()
        {
            int maxId = 0;

            using(var db = new SpeedSharkModelDataContext())
            {
                var query = db.Cargos.OrderByDescending(carg => carg.cargoId).SingleOrDefault().cargoId;
                if (query != 0 && query != null)
                {
                    maxId = query;
                }
            }
            return maxId;
        }
    }
}
