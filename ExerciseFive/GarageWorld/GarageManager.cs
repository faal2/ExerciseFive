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


    }
}
