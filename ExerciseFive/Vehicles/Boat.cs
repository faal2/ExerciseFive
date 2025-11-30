using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.Vehicles
{
    internal class Boat(string registerNumber, Color color, bool hasRoof = false) : Vehicle(registerNumber, color, 0)
    {
        public bool HasRoof { get; } = hasRoof;

        public override string ToString()
        {
            return $"{base.ToString()}, Roof: {HasRoof}";
        }

    }
    
    }
