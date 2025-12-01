using ExerciseFive.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.GarageWorld
{
    internal interface IManager
    {

        void MakeGarageSize(int capactiy);
        void ToSeedData();

        IEnumerable<Vehicle> Search(string type, string registerNumber, string color, int wheels);
        bool Depart(string registerNumber);

        (bool, string) Park(Vehicle newVehicle);

        bool IsRegisterNumberUnique(string registerNumber);

        bool DoStringsMatch(string first, string second);
        IEnumerable<Vehicle> GetVehicles();

    }
}
