namespace ISP.Vehicles.Wrong;

public class WrongCarImplementation : IWrongVehicle
{
    private string _color;
    private int _year;
    private double _engine;
    private int _seats;
    private int _numberOfDoors;

    public WrongCarImplementation(string color, int year, double engine, int seats, int numberOfDoors)
    {
        ConfigureCar(color, year, engine, seats, numberOfDoors);
    }

    public void ConfigureCar(string color, int year, double engine, int seats, int numberOfDoors)
    {
        _color = color;
        _year = year;
        _engine = engine;
        _seats = seats;
        _numberOfDoors = numberOfDoors;

        Console.WriteLine($"Car created successfully: color: {_color}, year: {_year}, engine {_engine}, seats {_seats} and number of doors {_numberOfDoors}.");

        Start();
    }

    // By having IWrongVehicle interface implemented, it's required that this class to implement this method, although it doesn't need it.
    // This breaks the Interface Segregation principle.
    public void ConfigureMotorcycle(string color, int year, double engine)
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        Console.WriteLine("Starting car...");
    }
}