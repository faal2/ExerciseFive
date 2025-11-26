using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.Vehicles
{
    public abstract class Vehicle(string registerNumber, Color color, int wheels)
    {
        public string RegisterNumber { get; } = registerNumber;
        public Color Color { get; } = color;
        public int Wheels { get; } = wheels;

        public override string ToString()
        {
            return $"Number: {RegisterNumber}, Color: {Color}, Wheels: {Wheels}";
        }
    }
}
