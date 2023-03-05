using ISP.Vehicles.Correct;
using ISP.Vehicles.Wrong;

var wrongCar = new WrongCarImplementation("Blue", 2022, 4.0, 2, 2);
var wrongMotorcycle = new WrongMotorcycleImplementation("Red", 2022, 4500);

var car = new Car("Blue", 2022, 4.0, 2, 2);
var motorCycle = new Motorcycle("Red", 2022, 4500);

Console.ReadKey();