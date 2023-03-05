namespace ISP.Vehicles.Correct;

// This interface could inherit IVehicle and remove it from whoever needs to implement this.
public interface IVehicleCar
{
    void Configure(string color, int year, double engine, int seats, int numberOfDoors);
}