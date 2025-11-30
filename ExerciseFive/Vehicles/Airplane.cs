using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.Vehicles
{
    public class Airplane(string registerNumber, Color color, int wheels = 6) : Vehicle(registerNumber, color, wheels)
    {
        public int Lenght { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Lenght: {Lenght}";
        }

    }

    }
