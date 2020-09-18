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
        private void RemoveVehile()
        {
            throw new NotImplementedException();
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
                        Console.WriteLine("Airplane");
                        
                        break;
                    case "2":
                        Console.WriteLine("Boat");

                        break;
                    case "3":
                        Console.WriteLine("Bus");

                        break;
                    case "4":
                        Console.WriteLine("Car");

                        break;
                    case "5":
                        Console.WriteLine("Motocycle");

                        break;
                    case "0":
                        Console.WriteLine("Exit");
                        return;
                    default:
                        break;
                }
            }
            string registrationNumber = "";
            string color = "";
            int numberOfWheels = 0;

            // RegistrationNumber
            while (registrationNumber.Length != 6)
            {
                ui.Print("Add the vehicle registration number Please enter 6 symbols");
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
            // while(numberOfWheels < 0 || numberOfWheels > 30)
            // {
            ui.Print("Please enter number of wheels");
            numberOfWheels = ui.GetIntInput("NumberOfWheels: ");
            //}

            Vehicle vehicle = new Vehicle(registrationNumber, color, numberOfWheels);

            handler.AddVehicle(vehicle);
            Console.WriteLine("Vehicle is Save");

        }

        private void CreateGarage()
        {

            //Take size from user
            // UI.GetIntInput eller likande
            int size = ui.GetIntInput("Garage size: ");
            handler = new GarageHandler(size);

        }

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