using System;

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
            ui.Print("Welcome");
            ui.Print("How big is the garage");

        }

        private void MainMeny()
        {
            ui.Print("Please navigate through the menu by inputting the number \n(1, 2, 3, 4, 5, 6, 7, 0) of your choice"
                  + "\n1. List all parked vehicles"
                  + "\n2. List vehicle types and how many of each are in the garage"
                  + "\n3. Add and remove vehicles from the garage"
                  + "\n4. Create a new garage with your specified size"
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
                    ListAllVehicles();
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    CreateGarage();
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


        private void CreateGarage()
        {
            //Take size from user
            // UI.GetIntInput eller likande
            int size = 10;
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