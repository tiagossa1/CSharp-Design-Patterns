namespace OCP;

// This class attempts to have both car and motorcycle implementation in the same class, but it breaks SRP and OCP.
// If my program needs to have implement another type of vehicle like bike, I would have to change this class to add another method to create a bike object which breaks OCP.
// Check 'Vehicle' object for the correct approach.
public class WrongVehicleImplementation
{
    private readonly string _color;
    private readonly int _year;
    private readonly double _engine;
    private readonly int _seats;
    private readonly int _numberOfDoors;

    public WrongVehicleImplementation(string color, int year, double engine, int seats, int numberOfDoors)
    {
        _color = color;
        _year = year;
        _engine = engine;
        _seats = seats;
        _numberOfDoors = numberOfDoors;
    }

    public void Car()
    {
        Console.WriteLine($"Creating a car {_color} from {_year} with an engine {_engine}, {_seats} and {_numberOfDoors} doors.");
        StartVehicle();
    }
    
    public void Motorcycle()
    {
        Console.WriteLine($"Creating a motorcycle {_color} from {_year} with an {_engine} engine.");
        StartVehicle();
    }

    public void StartVehicle()
    {
        Console.WriteLine("Starting engine...");
    }
}