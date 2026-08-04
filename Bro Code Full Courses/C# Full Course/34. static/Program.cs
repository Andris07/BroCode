// static = modifier to declare a static member, which belongs to the class itself
//          rather than to any specific object

using _34._static;

Car car1 = new Car("Mustang");
Car car2 = new Car("Corvette");
Car car3 = new Car("Lamborghini");

Console.WriteLine(Car.numberOfCars);
Car.StartRace();

Console.ReadKey();