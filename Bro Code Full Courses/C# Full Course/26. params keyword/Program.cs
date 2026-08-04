// params keyword = a method paramter that takes a variable number of arguments.
//                  The parameter type must be a single - dimensional array

double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

Console.WriteLine(total);

Console.ReadKey();

static double CheckOut(params double[] prices)
{
    double total = 0;

    foreach (var price in prices)
    {
        total += price;
    }

    return total;
}