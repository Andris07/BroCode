// exception = errors that occur during execution

//      try     = some code that is considered "dangerous"
//      catch   = catches and handles exceptions when they occur
//      finally = always executes regardless if exception is caught or not

double x;
double y;
double result;

try
{
    Console.Write("Enter in number 1: ");
    x = double.Parse(Console.ReadLine()!);

    Console.Write("Enter in number 2: ");
    y = double.Parse(Console.ReadLine()!);

    result = x / y;

    Console.WriteLine("Result: " + result);
}
catch (FormatException e)
{
    Console.WriteLine("Enter ONLY numbers PLEASE! " + e.Message);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("You can't divide by zero! IDIOT! " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Something went wrong! " + e.Message);
}
finally
{
    Console.WriteLine("Thanks for visiting!");
}

Console.ReadKey();