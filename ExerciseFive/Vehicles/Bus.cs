using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.Vehicles
{
    internal class Bus(string registerNumber, Color color, int seats = 25) : Vehicle(registerNumber, color, 4)
    {

        private int _seats = seats;

        public int NumberOfSeats ()
        {
            return _seats;
        }

    }
}
