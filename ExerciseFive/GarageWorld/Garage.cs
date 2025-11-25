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

        public Vehicle[] Vehicles { get; }
        public Garage(int capacity)
        {
            Vehicles = new Vehicle[capacity];

        }
    }
}
