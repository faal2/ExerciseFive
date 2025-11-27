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
        private static HashSet<string> _uniqueRegisterNumber = new();


        private string _registerNumber;


        public Vehicle(string registerNumber, Color color, int wheels)
        {
            RegisterNumber = registerNumber;
            Color = color;
            Wheels = wheels;
        }

        public string RegisterNumber {
        
            get
            {
                return _registerNumber;
            }
            [MemberNotNull(nameof(_registerNumber))]
            set
            {
                bool addRegisterNumber = _uniqueRegisterNumber.Add(value);
                if (addRegisterNumber)
                {
                    _registerNumber = value;
                }
                else
                {
                    throw new ArgumentException($"This register number already exists {value}", nameof(value));
                }
                
            }
        }

        public Color Color { get; }
        public int Wheels { get; }

        public override string ToString()
        {
            return $"Number: {RegisterNumber}, Color: {Color}, Wheels: {Wheels}";
        }
    }
}
