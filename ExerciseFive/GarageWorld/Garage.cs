using ExerciseFive.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExerciseFive.GarageWorld
{
    internal class Garage
    {

        private int _count = 0;
        public Vehicle[] Vehicles { get; set; }
        public Garage(int capacity)
        {
            Vehicles = new Vehicle[capacity];

        }

        public bool AddVehicle(Vehicle vehicle)
        {

            if (_count == Vehicles.Length)
            {
                return false;
            }

            else 
            {
                for (int i = 0; i < Vehicles.Length; i++)
                {
                    if (Vehicles[i] == null)
                {
                    Vehicles[i] = vehicle;
                        _count++;
                        return true;
                    }
                }
                return false;

            }


        }
        


        public bool RemoveVehicle(Vehicle vehicle)
        {

            for (int i = 0; i < Vehicles.Length; i++)
            {
                if (Vehicles[i] == vehicle)
                {
                    _count--;
                    Vehicles[i] = null;
                    return true;
                }
            }
            return false;

        }

    }
}
