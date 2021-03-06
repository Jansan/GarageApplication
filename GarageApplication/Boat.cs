﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApplication
{
    class Boat : Vehicle
    {
        private int numberOfEngines;

        public int NumberOfEngines
        {
            get { return numberOfEngines; }
            set { numberOfEngines = value; }
        }
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

        public Boat(string registrationNumber, string color, int numberOfWheels, int numberOfEngines, int cylinderVolume, string fueltype) : base(registrationNumber, color, numberOfWheels)
        {
            NumberOfEngines = numberOfEngines;
            CylinderVolume = cylinderVolume;
            Fueltype = fueltype;

        }

        public override string ToString()
        {
            return $"RegistrationNumber: {base.RegistrationNumber} " +
                $"Color: {base.Color} " +
                $"NumberOfWheels: {base.NumberOfWheels} " +
                $"NumberOfEngines: {NumberOfEngines} " +
                $"CylinderVolume: {CylinderVolume} " +
                $"Fueltype: {Fueltype} ";
        }
    }
}
