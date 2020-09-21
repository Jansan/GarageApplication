using System;
using System.Collections.Generic;

namespace GarageApplication
{
    internal class GarageManager
    {
        private GarageHandler handler;
        private UI ui;

        public GarageManager()
        {
            ui = new UI();


        }

        internal void Start()
        {
            FirstMeny();
            CreateGarage();
            do
            {
                MainMeny();

            } while (true);
        }

        private void FirstMeny()
        {
            ui.Print("Welcome to Garage Application");
            ui.Print("How big is the garage you want");

        }

        private void MainMeny()
        {
            ui.Print("Please navigate through the menu by inputting the number \n(1, 2, 3, 4, 5, 6, 7, 0) of your choice"
                  + "\n1. Create a new garage with your specified size"
                  + "\n2. Add and remove vehicles from the garage"
                  + "\n3. List vehicle types and how many of each are in the garage"
                  + "\n4. List all parked vehicles"
                  + "\n5. Opportunity to popularize the garage with a number of vehicles from the start"
                  + "\n6. Find a specific vehicle via the registration number."
                  + "\n7. Search for vehicles based on one property"
                  + "\n0. Exit the application");

            char input = ' ';
            try
            {
                input = Console.ReadLine()[0];
            }
            catch (IndexOutOfRangeException)
            {

                ui.Clear();
                ui.Print("Please enter some input!");
            }
            switch (input)
            {
                case '1':
                    CreateGarage();
                    break;
                case '2':
                    while (true)
                    {
                        ui.Print("Please navigate menu (1, 2, 0) of your choice"
                            + "\n1. Add Vehicle"
                            + "\n2. Remove Vehicle"
                            + "\n0. Exit");
                        char userInput = ' ';
                        try
                        {
                            userInput = Console.ReadLine()[0];
                        }
                        catch (IndexOutOfRangeException)
                        {

                            ui.Clear();
                            ui.Print("Please enter some input!");
                        }
                        switch (userInput)
                        {
                            case '1':
                                AddVehicle();
                                break;
                            case '2':
                                RemoveVehile();
                                break;
                            case '0':
                                return;
                                break;
                            default:
                                ui.Print("Please enter some valid input (1, 2, 0)");
                                break;
                        }
                    }
                    break;
                case '3':
                    break;
                case '4':
                    ListAllVehicles();
                    break;
                case '5':
                    break;
                case '6':
                    break;
                case '7':
                    break;
                // Exit the Application
                case '0':
                    Environment.Exit(0);
                    break;
                // wrong choise input user message
                default:
                    Console.WriteLine("Please enter some valid input (1, 2, 3, 4, 5, 6, 7, 0)");
                    break;
            }
        }

        // Remove Vehicle
        private void RemoveVehicle()
        {

            string inputReg = ui.GetStringInput("Vilken fordon vill tabort?");
            handler.RemoveVehicle(inputReg);
        }

        // Add Vehicle
        private void AddVehicle()
        {
            while (true)
            {
                ui.Print("Please navigate menu inputting the number\n(1, 2, 3, 4, 5, 0"
                    + "\n1. Airplane"
                    + "\n2. Boat"
                    + "\n3. Bus"
                    + "\n4. Car"
                    + "\n5. Motorcycle"
                    + "\n0. Exit"
                    );
                string input = "";
                try
                {
                    input = ui.GetStringInput("Choose: ");
                }
                catch (IndexOutOfRangeException)
                {
                    ui.Clear();
                    ui.Print("Please enter some input!");
                }
                switch (input)
                {
                    case "1":

                        AddAirplane();
                        break;
                    case "2":

                        AddBoat();
                        break;
                    case "3":

                        AddBus();
                        break;
                    case "4":

                        AddCar();
                        break;
                    case "5":

                        AddMotocycle();
                        break;
                    case "0":

                        return;
                    default:
                        break;
                }
            }


        }
        // Add Motocycle
        private void AddMotocycle()
        {
            string registrationNumber = "";
            string color = "";
            int numberOfWheels = 0;
            int cylinderVolume = 0;
            string fueltype = "";
            int numberOfSeats = 0;


            // RegistrationNumber
            while (registrationNumber.Length != 6)
            {
                ui.Print("Add the registration number Please enter 6 symbols");
                registrationNumber = ui.GetStringInput("RegistrationNumber: ").ToUpper();
                if (registrationNumber.Length != 6)
                    ui.Print("Registrationnumber is 6 symbols without spaces!");
            }

            // Color
            ui.Print("What color is the vehicle");
            color = ui.GetStringInput("Color: ").ToUpper();
            if (color == "")
                ui.Print("Unknow color");

            // NumberOfWheels
            ui.Print("Please enter number of wheels");
            numberOfWheels = ui.GetIntInput("NumberOfWheels: ");

            // NumberOfWheels
            ui.Print("Please enter cylinderVolume");
            cylinderVolume = ui.GetIntInput("cylinderVolume: ");

            // Fueltype
            ui.Print("Add the fueltype");
            fueltype = ui.GetStringInput("Fueltype: ");

            // numberOfSeats
            ui.Print("Add the number Of Seats");
            numberOfSeats = ui.GetIntInput("numberOfSeats: ");

           

            Motorcycle motorcycle = new Motorcycle(registrationNumber, color, numberOfWheels,cylinderVolume, fueltype, numberOfSeats);
            handler.AddVehicle(motorcycle);
            ui.Print($"You success added Motorcycle");
        }
        // Add Car
        private void AddCar()
        {
            string registrationNumber = "";
            string color = "";
            int numberOfWheels = 0;
            string fueltype = "";
            int numberOfSeats = 0;
            double lenght = 0;


            // RegistrationNumber
            while (registrationNumber.Length != 6)
            {
                ui.Print("Add the registration number Please enter 6 symbols");
                registrationNumber = ui.GetStringInput("RegistrationNumber: ").ToUpper();
                if (registrationNumber.Length != 6)
                    ui.Print("Registrationnumber is 6 symbols without spaces!");
            }

            // Color
            ui.Print("What color is the vehicle");
            color = ui.GetStringInput("Color: ").ToUpper();
            if (color == "")
                ui.Print("Unknow color");

            // NumberOfWheels
            ui.Print("Please enter number of wheels");
            numberOfWheels = ui.GetIntInput("NumberOfWheels: ");

            // lenght
            ui.Print("Add the cylinderVolume");
            lenght = ui.GetDoubleInput("cylinderVolume: ");
            // Fueltype
            ui.Print("Add the fueltype");
            fueltype = ui.GetStringInput("Fueltype: ");

            // numberOfSeats
            ui.Print("Add the number Of Seats");
            numberOfSeats = ui.GetIntInput("numberOfSeats: ");


            Car car = new Car(registrationNumber, color, numberOfWheels, fueltype, numberOfSeats, lenght);
            handler.AddVehicle(car);
            ui.Print($"You success added car");
        }
        // Add Bus
        private void AddBus()
        {
            string registrationNumber = "";
            string color = "";
            int numberOfWheels = 0;
            string fueltype = "";
            int numberOfSeats = 0;
            double lenght = 0;


            // RegistrationNumber
            while (registrationNumber.Length != 6)
            {
                ui.Print("Add the registration number Please enter 6 symbols");
                registrationNumber = ui.GetStringInput("RegistrationNumber: ").ToUpper();
                if (registrationNumber.Length != 6)
                    ui.Print("Registrationnumber is 6 symbols without spaces!");
            }

            // Color
            ui.Print("What color is the vehicle");
            color = ui.GetStringInput("Color: ").ToUpper();
            if (color == "")
                ui.Print("Unknow color");

            // NumberOfWheels
            ui.Print("Please enter number of wheels");
            numberOfWheels = ui.GetIntInput("NumberOfWheels: ");

            // Fueltype
            ui.Print("Add the fueltype");
            fueltype = ui.GetStringInput("Fueltype: ");

            // numberOfSeats
            ui.Print("Add the number Of Seats");
            numberOfSeats = ui.GetIntInput("numberOfSeats: ");

            // lenght
            ui.Print("Add the lenght");
            lenght = ui.GetDoubleInput("lenght: ");

            Bus bus = new Bus(registrationNumber, color, numberOfWheels, fueltype, numberOfSeats, lenght);
            handler.AddVehicle(bus);

            ui.Print($"You success added bus");
        }
        // Add Boat
        private void AddBoat()
        {
            string registrationNumber = "";
            string color = "";
            int numberOfWheels = 0;
            int numberOfEngines = 0;
            int cylinderVolume = 0;
            string fueltype = "";

            // RegistrationNumber
            while (registrationNumber.Length != 6)
            {
                ui.Print("Add the registration number Please enter 6 symbols");
                registrationNumber = ui.GetStringInput("RegistrationNumber: ").ToUpper();
                if (registrationNumber.Length != 6)
                    ui.Print("Registrationnumber is 6 symbols without spaces!");
            }

            // Color
            ui.Print("What color is the vehicle");
            color = ui.GetStringInput("Color: ").ToUpper();
            if (color == "")
                ui.Print("Unknow color");

            // NumberOfWheels
            ui.Print("Please enter number of wheels");
            numberOfWheels = ui.GetIntInput("NumberOfWheels: ");

            // NumberOfEngines
            ui.Print("Add the number Of Engines");
            numberOfEngines = ui.GetIntInput("NumberOfEngines: ");

            // cylinderVolume
            ui.Print("Add the cylinderVolume");
            cylinderVolume = ui.GetIntInput("cylinderVolume: ");


            // Fueltype
            ui.Print("Add the fueltype");
            fueltype = ui.GetStringInput("Fueltype: ");

            Boat boat = new Boat(registrationNumber, color, numberOfWheels, numberOfEngines, cylinderVolume, fueltype);
            handler.AddVehicle(boat);

            ui.Print($"You success added boat");
        }
        // Add Airplane
        private void AddAirplane()
        {
            string registrationNumber = "";
            string color = "";
            int numberOfWheels = 0;
            int numberOfEngines = 0;
            int cylinderVolume = 0;
            string fueltype = "";

            // RegistrationNumber
            while (registrationNumber.Length != 6)
            {
                ui.Print("Add the registration number Please enter 6 symbols");
                registrationNumber = ui.GetStringInput("RegistrationNumber: ").ToUpper();
                if (registrationNumber.Length != 6)
                    ui.Print("Registrationnumber is 6 symbols without spaces!");
            }

            // Color
            ui.Print("What color is the");
            color = ui.GetStringInput("Color: ").ToUpper();
            if (color == "")
                ui.Print("Unknow color");

            // NumberOfWheels
            ui.Print("Please enter number of wheels");
            numberOfWheels = ui.GetIntInput("NumberOfWheels: ");

            // NumberOfEngines
            ui.Print("Add the number Of Engines");
            numberOfEngines = ui.GetIntInput("NumberOfEngines: ");

            // cylinderVolume
            ui.Print("Add the cylinderVolume");
            cylinderVolume = ui.GetIntInput("cylinderVolume: ");


            // fueltype
            ui.Print("Add the fueltype");
            fueltype = ui.GetStringInput("Fueltype: ");

            Airplane airplane = new Airplane(registrationNumber, color, numberOfWheels, numberOfEngines, cylinderVolume, fueltype);
            handler.AddVehicle(airplane);

            ui.Print($"You success added airplane");

        }
        // CreateGarage
        private void CreateGarage()
        {

            //Take size from user
            // UI.GetIntInput eller likande
            int size = ui.GetIntInput("Garage size: ");
            handler = new GarageHandler(size);

        }
        //ListAllVehicles
        private void ListAllVehicles()
        {
            var allVehicles = handler.GetAll();
            foreach (var vehicle in allVehicles)
            {
                ui.Print(vehicle.ToString());

            }
        }
    }
}