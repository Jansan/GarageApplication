using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GarageApplication
{
    interface IVehicle
    {
        public string RegistrationNumber { get; set; }
        public string  Color { get; set; }
        public int NumberOfWheels { get; set; }

    }
}
