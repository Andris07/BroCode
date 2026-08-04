// foreach loop = a simpler way to iterate over an array, but it's less flexible

string[] cars = { "BMW", "Mustang", "Corvette" };

//for (int i = 0; i < cars.Length; i++)
//{
//    Console.WriteLine(cars[i]);
//}

foreach (var car in cars)
{
    Console.WriteLine(car);
}

Console.ReadKey();