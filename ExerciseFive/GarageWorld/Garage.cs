using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ExerciseFive.Vehicles;

namespace ExerciseFive.GarageWorld
{
    internal class Garage
    {

        private Vehicle[] _vehicles;

        public Vehicle[] Vehicles
        {
            get
            {
                return _vehicles;
            }
            set
            {
                _vehicles = value;
            }
        }

        public int Slots {get; set;}
        public Garage(int capacity)
        {
            Vehicles = new Vehicle[capacity];
            Slots = capacity;

        }

        public void AddVehicle(Vehicle vehicle)
        {
            if (Slots ==0)
            {
                Console.WriteLine("FULL");

            }
            else if (Slots > 0)
            {
                Vehicles[Slots] = vehicle;
                Slots--;

            }


        }

    }
}
