namespace ISP.Vehicles.Correct;

public class Car : IVehicle, IVehicleCar
{
    private string _color;
    private int _year;
    private double _engine;
    private int _seats;
    private int _numberOfDoors;

    public Car(string color, int year, double engine, int seats, int numberOfDoors)
    {
        Configure(color, year, engine, seats, numberOfDoors);
    }

    public void Start()
    {
        Console.WriteLine("Starting car...");
    }

    public void Configure(string color, int year, double engine, int seats, int numberOfDoors)
    {
        _color = color;
        _year = year;
        _engine = engine;
        _seats = seats;
        _numberOfDoors = numberOfDoors;

        Console.WriteLine($"Car created successfully: color: {_color}, year: {_year}, engine {_engine}, seats {_seats} and number of doors {_numberOfDoors}.");

        Start();
    }
}