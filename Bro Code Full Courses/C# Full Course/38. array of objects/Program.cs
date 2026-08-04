using _38._array_of_objects;

//Car[] garage = new Car[3];

//Car car1 = new Car("Mustang");
//Car car2 = new Car("Corvette");
//Car car3 = new Car("Lamborghini");

//garage[0] = car1;
//garage[1] = car2;
//garage[2] = car3;

Car[] garage =
{
    new Car("Mustang"),
    new Car("Corvette"),
    new Car("Lamborghini"),
};

//Console.WriteLine(garage[0].model);
//Console.WriteLine(garage[1].model);
//Console.WriteLine(garage[2].model);

foreach (var car in garage)
{
    Console.WriteLine(car.model);
}

Console.ReadKey();