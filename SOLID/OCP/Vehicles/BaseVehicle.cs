namespace OCP.Vehicles;

public class BaseVehicle
{
    protected readonly string Color;
    protected readonly int Year;
    protected readonly double Engine;

    protected BaseVehicle(string color, int year, double engine)
    {
        Color = color;
        Year = year;
        Engine = engine;
    }

    public virtual void Start()
    {
        Console.WriteLine("Starting vehicle...");
    }
}