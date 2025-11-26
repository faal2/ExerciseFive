using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.Vehicles
{
    public class Airplane : Vehicle
    {

        public Airplane (string registerNumber, Color color, int wheels = 6) : base (registerNumber, color, wheels)
        {

        }
    }
}
