using ExerciseFive.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.GarageWorld
{
    internal class GarageManager : IManager
    {
        private Garage<Vehicle> _garage;

        public void MakeGarageSize(int capcacity)
        {
            _garage = new Garage<Vehicle>(capcacity);
        }

        public IEnumerable<Vehicle> GetVehicles ()
        {
            foreach (Vehicle vehicle in _garage)
            {
                yield return vehicle;
            }
        }
        public bool IsRegisterNumberUnique(string registerNumber)
        {
            foreach (Vehicle previousVehicle in _garage)
            {
                if (previousVehicle.RegisterNumber == registerNumber)
                {
                    return false;
                }

            }
            return true;
        }

        public bool Park(Vehicle newVehicle)
        {
            return (_garage.AddVehicle(newVehicle));
        }

        public bool Depart(Vehicle oldVehicle)
        {
            foreach (Vehicle previousVehicle in _garage)
            {
                if (previousVehicle.RegisterNumber == oldVehicle.RegisterNumber)
                {
                    _garage.RemoveVehicle(oldVehicle);
                    return true;
                }

            }
            return false;
        }

        public void ToSeedData()
        {
            var hyrBil1 = new Car("1234ABC", Color.Red);
            _garage.AddVehicle(hyrBil1);
        }

    }
}
