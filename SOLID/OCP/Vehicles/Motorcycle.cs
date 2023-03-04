namespace OCP.Vehicles;

public class Motorcycle : BaseVehicle
{
    public Motorcycle(string color, int year, double engine) : base(color, year, engine)
    {
        Configure();
    }

    public void Configure()
    {
        Console.WriteLine($"Creating a motorcycle {Color} from {Year} with an {Engine} engine.");
        Start();
    }
}