using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.Vehicles
{
    internal interface IVehicle
    {
        string RegisterNumber { get; }
        Color Color { get;}
        int Wheels { get; }
    }
}
