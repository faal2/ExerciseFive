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

        public (bool, string) Park(Vehicle newVehicle)
        {
            if (IsRegisterNumberUnique(newVehicle.RegisterNumber))
            {
                 if (_garage.AddVehicle(newVehicle))
                {
                    return (true, "Succesfully added");
                }
                else
                {
                    return (false, "Failed due to garage full");
                }

                    
            }
            else
            { return (false, "Failed due to an existing register number in the garage."); }

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


        public IEnumerable<Vehicle> Search(string type, string registerNumber, string color, int wheels)
        {

            return _garage.Where(t =>

            (string.IsNullOrEmpty(type) || t.GetType().Name.ToLower().Contains(type.ToLower()))

            &&

            (string.IsNullOrEmpty(registerNumber) || t.RegisterNumber.ToLower().Contains(registerNumber.ToLower()))

            && 

            (string.IsNullOrEmpty(color) || t.Color.ToString().ToLower().Contains(color.ToLower()))

            && 

            (wheels == 0 || t.Wheels == wheels)

            );

            //return _garage.Where(t =>
            //    t.RegisterNumber.Contains(registerNumber) &&
            //    t.Color.ToString().Contains(color) &&
            //    t.Wheels == wheels
            //);
        }

        public void PrintDebugInfo()
        {
            Console.WriteLine("--- DEBUG: WHAT IS INSIDE _garage? ---");

            // _garage is the collection. "v" is the specific Vehicle object.
            foreach (Vehicle v in _garage)
            {
                Console.WriteLine($"OBJECT TYPE: {v.GetType().Name}"); // e.g., Car, Boat
                Console.WriteLine($"   Property 1 (RegisterNumber): '{v.RegisterNumber}'");
                Console.WriteLine($"   Property 2 (Color):          '{v.Color}'");
                Console.WriteLine($"   Property 3 (Wheels):         '{v.Wheels}'");
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}
