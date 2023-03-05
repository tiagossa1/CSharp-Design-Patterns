namespace ISP.Vehicles.Wrong;

public class WrongMotorcycleImplementation : IWrongVehicle
{
    private string _color;
    private int _year;
    private double _engine;

    public WrongMotorcycleImplementation(string color, int year, double engine)
    {
        ConfigureMotorcycle(color, year, engine);
    }

    // By having IWrongVehicle interface implemented, it's required that this class to implement this method, although it doesn't need it.
    // This breaks the Interface Segregation principle.
    public void ConfigureCar(string color, int year, double engine, int seats, int numberOfDoors)
    {
    }

    public void ConfigureMotorcycle(string color, int year, double engine)
    {
        _color = color;
        _year = year;
        _engine = engine;

        Console.WriteLine($"Motorcycle created successfully: color: {_color}, year: {_year} and engine {_engine}..");

        Start();
    }

    public void Start()
    {
        Console.WriteLine("Starting motorcycle...");
    }
}