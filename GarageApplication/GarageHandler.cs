namespace GarageApplication
{
    internal abstract class GarageHandler
    {
        private Garage<Vehicle> garage;

        public GarageHandler()
        {
            garage = new Garage<Vehicle>(10);
        }
    }
}