﻿namespace GarageApplication
{
    public class Vehicle : IVehicle
    {
        private string registrationNumber;

        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private int numberOfWheels;

        public int NumberOfWheels
        {
            get { return numberOfWheels; }
            set { numberOfWheels = value; }
        }

        public Vehicle(string registrationNumber, string color, int numberOfWheels)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
        }

        public override string ToString()
        {
            return $"RegistrationNumber: {RegistrationNumber} " +
                $"Color: {Color} " +
                $"NumberOfWheels: {NumberOfWheels} ";
        }
    }
}