using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.Vehicles
{
    public class Vehicle
    {
        public string RegisterNumber { get; }

        public Color Color { get; }

        public int Wheels { get; }
        public Vehicle(string registerNumber, Color color, int wheels)
        {
            RegisterNumber = registerNumber;
            Color = color;
            Wheels = wheels;
            
        }
        public override string ToString()
        {
            return $"Number: {RegisterNumber}, Color: {Color}, Wheels: {Wheels}";
        }
    }
}
