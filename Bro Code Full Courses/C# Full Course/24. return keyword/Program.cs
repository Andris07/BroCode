// return = returns data back to the place where a method is invoked

double x;
double y;
double result;

Console.Write("Enter in number 1: ");
x = double.Parse(Console.ReadLine()!);

Console.Write("Enter in number 2: ");
y = double.Parse(Console.ReadLine()!);

result = Multiply(x, y);
Console.WriteLine(result);

static double Multiply(double x, double y)
{
    return x * y;
}

Console.ReadKey();