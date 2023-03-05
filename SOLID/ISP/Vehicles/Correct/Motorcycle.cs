using ISP.Vehicles.Wrong;

namespace ISP.Vehicles.Correct;

public class Motorcycle : IVehicle, IVehicleMotorcycle
{
    private string _color;
    private int _year;
    private double _engine;

    public Motorcycle(string color, int year, double engine)
    {
        Configure(color, year, engine);
    }

    public void Start()
    {
        Console.WriteLine("Starting motorcycle...");
    }

    public void Configure(string color, int year, double engine)
    {
        _color = color;
        _year = year;
        _engine = engine;

        Console.WriteLine($"Motorcycle created successfully: color: {_color}, year: {_year} and engine {_engine}..");

        Start();
    }
}