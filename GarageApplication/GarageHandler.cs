using System;
using System.Collections.Generic;
using System.Linq;

namespace GarageApplication
{
    internal  class GarageHandler
    {
        private Garage<Vehicle> garage;

        //Take size as parameter
        public GarageHandler(int size)
        {
            garage = new Garage<Vehicle>(size);
        }

        //public bool Park(Vehicle vehicle)
        //{
        //    garage.Park(garage);
        //}

        internal IEnumerable<Vehicle> GetAll()
        {
            //Fungerar ej innnan du implemeterat GetEnumerator i garaet för att det är linq!
            return garage.ToList();
        }
    }
}