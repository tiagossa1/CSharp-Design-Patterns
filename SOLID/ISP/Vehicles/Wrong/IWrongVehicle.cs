namespace ISP.Vehicles.Wrong;

public interface IWrongVehicle
{
    void ConfigureCar(string color, int year, double engine, int seats, int numberOfDoors);
    void ConfigureMotorcycle(string color, int year, double engine);
    void Start();
}