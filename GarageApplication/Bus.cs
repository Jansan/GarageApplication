using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApplication
{
    class Bus : Vehicle
    {
        private string fueltype;

        public string Fueltype
        {
            get { return fueltype; }
            set { fueltype = value; }
        }
        private int numberOfSeats;

        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set { numberOfSeats = value; }
        }
        private double lenght;

        public double Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }

        public Bus(string registrationNumber, string color, int numberOfWheels, string fueltype, int numberOfSeats, double lenght) : base(registrationNumber, color, numberOfWheels)
        {
            Fueltype = fueltype;
            NumberOfSeats = NumberOfSeats;
            Lenght = lenght;
        }
    }
}
