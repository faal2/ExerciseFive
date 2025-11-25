using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.Vehicles
{
    public abstract class Vehicle
    {
        public int RegisterNumber { get; }

        public Color Color { get; }

        public int Wheels { get; }
        public Vehicle(int registerNumber, Color color, int wheels)
        {
            RegisterNumber = registerNumber;
            Color = color;
            Wheels = wheels;
            
        }
    }
}
