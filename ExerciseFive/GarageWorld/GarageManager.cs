using ExerciseFive.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.GarageWorld
{
    internal class GarageManager : IManager
    {
        private Garage<Vehicle> _garage;

        public void MakeGarageSize(int capcacity)
        {
            _garage = new Garage<Vehicle>(capcacity);
        }

        public IEnumerable<Vehicle> GetVehicles ()
        {
            return _garage;
        }

        public bool DoStringsMatch(string first, string second)
        {
            if (first.ToLower() == second.ToLower())
                return true;
            return false;
        }
        public bool IsRegisterNumberUnique(string registerNumber)
        {
            foreach (Vehicle previousVehicle in _garage)
            {
                if (DoStringsMatch(previousVehicle.RegisterNumber, registerNumber))
                {
                    return false;
                }

            }
            return true;
        }

        public bool Park(Vehicle newVehicle)
        {
            return (_garage.AddVehicle(newVehicle));
        }


        public bool Depart(string registerNumber)
        {
            foreach (Vehicle previousVehicle in _garage)
            {
                if (DoStringsMatch(previousVehicle.RegisterNumber, registerNumber))
                {
                    _garage.RemoveVehicle(previousVehicle);
                    return true;
                }

            }
            return false;
        }

        public void ToSeedData()
        {
            var hyrBil1 = new Car("1234ABC", Color.Red);
            _garage.AddVehicle(hyrBil1);
        }


        public IEnumerable<Vehicle> Search(string registerNumber, string color, int wheels)
        {
            return _garage.Where(t =>
                t.RegisterNumber.Contains(registerNumber) &&
                t.Color.ToString().Contains(color) &&
                t.Wheels == wheels
            );
        }
    }
}
