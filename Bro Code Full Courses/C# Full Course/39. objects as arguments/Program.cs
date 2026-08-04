using _39._objects_as_arguments;

Car car1 = new Car("Mustang", "red");
Car car2 = Copy(car1);

ChangeColor(car2, "silver");

Console.WriteLine($"{car1.model} {car1.color}");
Console.WriteLine($"{car2.model} {car2.color}");

static void ChangeColor(Car car, string color)
{
    car.color = color;
}

static Car Copy(Car car)
{
    return new Car(car.model, car.color);
}

Console.ReadKey();