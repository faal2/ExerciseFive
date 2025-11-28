using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.Vehicles
{
    public abstract class Vehicle : IVehicle
    {

        public Vehicle(string registerNumber, Color color, int wheels)
        {
            RegisterNumber = registerNumber;
            Color = color;
            Wheels = wheels;
        }

        public string RegisterNumber { get; set; }

        public Color Color { get; }
        public int Wheels { get; }
    }
}
