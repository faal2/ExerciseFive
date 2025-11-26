using ExerciseFive.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExerciseFive.GarageWorld
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {

        private int _occupied = 0;
        private T[] _values;
        public Garage(int capacity)
        {
            _values = new T[capacity];

        }
        
        public bool AddVehicle(T value)
        {

            if (_occupied == _values.Length)
            {
                return false;
            }

            else 
            {
                for (int i = 0; i < _values.Length; i++)
                {
                    if (_values[i] == null)
                {
                        _values[i] = value;
                        _occupied++;
                        return true;
                    }
                }
                return false;

            }


        }
        


        public bool RemoveVehicle(T value)
        {

            for (int i = 0; i < _values.Length; i++)
            {
                if (_values[i] == value)
                {
                    _occupied--;
                    _values[i] = null;
                    return true;
                }
            }
            return false;

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _values.Length; i++)
            {
                if (_values[i] != null)
                {
                    yield return _values[i];
                }
            }
        }

        //For  backwards compatibility
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
