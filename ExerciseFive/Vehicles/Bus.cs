using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.Vehicles
{
    internal class Bus : Vehicle
    {

        private int _seats;

        public Bus(string registerNumber, Color color, int seats = 25) : base(registerNumber, color, 4)
        {
            _seats = seats;
        }

        public int NumberOfSeats ()
        {
            return _seats;
        }

    }
}
