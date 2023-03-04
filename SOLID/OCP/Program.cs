using OCP;
using OCP.Vehicles;

// Using wrong vehicle implementation.
var vehicleType = TypeVehicle.Car;

if (vehicleType == TypeVehicle.Car)
{
    var car = new WrongVehicleImplementation("Black", 2020, 2.0, 4, 5);
    car.Car();
}
else
{
    var motorcycle = new WrongVehicleImplementation("Black", 2020, 250, 1, 0);
    motorcycle.Motorcycle();
}

// With the correct approach.
var newMotorcycle = new Motorcycle("Black", 2020, 250);

Console.ReadKey();