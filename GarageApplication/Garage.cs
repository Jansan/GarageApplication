using System;
using System.Collections;
using System.Collections.Generic;

namespace GarageApplication
{
    public class Garage <T> : IEnumerable<T> where T : IVehicle
    {
        private T[] vehicles;
        public Garage(int size)
        {

            vehicles = new T[size];
        }


        public void Park(T vehile)
        {
            // Check if full 
            // return bool 
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is null)
                {
                    vehicles[i] = vehile;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            //Fixa till så det går att köra linq/foreach på en garage instans
            //Hämta ut alla parkerade fordon
            //Yield returna alla
            foreach (var item in vehicles)
            {
                yield return item;
            }
        }

        internal void RemoveVehicle(string inputReg)
        {
            foreach (var vehicle in vehicles)
            {
               
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}