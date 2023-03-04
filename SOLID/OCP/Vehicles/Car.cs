namespace OCP.Vehicles;

public class Car : BaseVehicle
{
    private readonly int _seats;
    private readonly int _numberOfDoors;

    public Car(string color, int year, double engine, int seats, int numberOfDoors) : base(color, year, engine)
    {
        _seats = seats;
        _numberOfDoors = numberOfDoors;
        
        Configure();
    }

    public void Configure()
    {
        Console.WriteLine($"Creating a car {Color} from {Year} with an engine {Engine}, {_seats} and {_numberOfDoors} doors.");
        Start();
    }
}