using ExerciseFive.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExerciseFive.GarageWorld
{
    internal class Garage<T> where T : Vehicle
    {

        private int _occupied = 0;
        public T[] Values { get; set; }
        public Garage(int capacity)
        {
            Values = new T[capacity];

        }
        
        public bool AddVehicle(T value)
        {

            if (_occupied == Values.Length)
            {
                return false;
            }

            else 
            {
                for (int i = 0; i < Values.Length; i++)
                {
                    if (Values[i] == null)
                {
                    Values[i] = value;
                        _occupied++;
                        return true;
                    }
                }
                return false;

            }


        }
        


        public bool RemoveVehicle(T value)
        {

            for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i] == value)
                {
                    _occupied--;
                    Values[i] = null;
                    return true;
                }
            }
            return false;

        }

    }
}
