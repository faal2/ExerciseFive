using ExerciseFive.Vehicles;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            Console.WriteLine($"HERE {capcacity} and {_garage}");
        }

        public IEnumerable<Vehicle> GetVehicles ()
        {
            foreach (Vehicle vehicle in _garage)
            {
                yield return vehicle;
            }
        }

        public bool Park(Vehicle newVehicle)
        {
            foreach (Vehicle previousVehicle in _garage)
            {
                if (newVehicle.RegisterNumber == previousVehicle.RegisterNumber)
                    return false;
            }
            _garage.AddVehicle(newVehicle);
            return true;
        }

        public bool Depart(Vehicle oldVehicle)
        {
            foreach (Vehicle previousVehicle in _garage)
            {
                if (oldVehicle.RegisterNumber == previousVehicle.RegisterNumber)
                {
                    _garage.RemoveVehicle(oldVehicle);
                    return true;
                }

            }
            return false;
        }



    }
}
