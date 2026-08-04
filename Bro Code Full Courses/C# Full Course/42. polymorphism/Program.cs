// polymorphism = Greek word that means to "have many forms"
//                Objects can be identified by more than one type
//                Ex. a Dog is also: Canine, Animal, Organism

using _42._polymorphism;

Car car = new Car();
Bicycle bicycle = new Bicycle();
Boat boat = new Boat();

Vehicle[] vehicles = { car, bicycle, boat };

foreach (var vehicle in vehicles)
{
    vehicle.Go();
}

Console.ReadKey();