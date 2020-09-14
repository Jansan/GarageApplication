namespace GarageApplication
{
    public class Garage<TVehicle>
    {
        TVehicle[] vehicles;
        public Garage()
        {
            vehicles = new TVehicle[10];
        }
    }
}