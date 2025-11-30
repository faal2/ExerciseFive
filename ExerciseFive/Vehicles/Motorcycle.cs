using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.Vehicles
{
    internal class Motorcycle(string registerNumber, Color color, bool hasPillionSeat = false) : Vehicle(registerNumber, color, 2)
    {
        public bool HasPillionSeat { get;} = hasPillionSeat;

        public override string ToString()
        {
            return $"{base.ToString()}, Seat for passanger: {HasPillionSeat}";
        }
    }
}
