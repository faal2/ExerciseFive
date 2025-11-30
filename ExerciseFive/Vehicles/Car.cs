using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.Vehicles
{
    internal class Car(string registerNumber, Color color, bool isElectric = false) : Vehicle(registerNumber, color, 4)
    {
        public bool isElectric { get; } = isElectric;

        public override string ToString()
        {
            return $"{base.ToString()}, Electric: {isElectric}";
        }

    }
}
