using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApplication
{
    class Motorcycle : Vehicle
    {
        private int cylinderVolume;

        public int CylinderVolume
        {
            get { return cylinderVolume; }
            set { cylinderVolume = value; }
        }
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

        public Motorcycle(string registrationNumber, string color, int numberOfWheels, int cylinderVolume, string fueltype, int numberOfSeats) : base(registrationNumber, color, numberOfWheels)
        {
            CylinderVolume = cylinderVolume;
            Fueltype = fueltype;
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return $"RegistrationNumber: {base.RegistrationNumber} " +
                $"Color: {base.Color} " +
                $"NumberOfWheels: {base.NumberOfWheels} " +
                $"Lenght: {CylinderVolume} " +
                $"Fueltype: {Fueltype} " +
                $"NumberOfSeats: {NumberOfSeats} ";
        }
    }
}
