using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.Vehicles
{
    internal class Motorcycle(string registerNumber, Color color) : Vehicle(registerNumber, color, 2)
    {
    }
}
