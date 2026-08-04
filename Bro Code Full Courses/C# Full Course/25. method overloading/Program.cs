// method overloading = methods share same name, but different parameters
//                      name + parameters = signature
//                      methods must have a unique signature

double total2;
double total3;

total2 = Multiply2(2, 3);
total3 = Multiply3(2, 3, 4);

Console.WriteLine(total2);
Console.WriteLine(total3);

Console.ReadKey();

static double Multiply2(double a, double b)
{
    return a * b;
}

static double Multiply3(double a, double b, double c)
{
    return a * b * c;
}

// for some reason two Multiply methods will cause an error, so I renamed the 2 parameter Multiply method as Multiply2, and the 3 parameter Multiply method as Multiply3, but both Multiply method should work regardless of their name if they have different parameters