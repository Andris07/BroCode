// generic = "not specific to a particular data type"
//           add <T> to: classes, methods, fields, etc.
//           allows for code reusability for different data types

int[] intArray = { 1, 2, 3 };
double[] doubleArray = { 1.0, 2.0, 3.0 };
string[] stringArray = { "1", "2", "3" };

displayElements(intArray);
displayElements(doubleArray);
displayElements(stringArray);

Console.ReadKey();

static void displayElements<Thing>(Thing[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}