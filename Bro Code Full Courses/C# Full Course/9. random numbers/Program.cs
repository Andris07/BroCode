Random random = new Random();

// int num = random.Next(1, 7); // random whole integer [1, 7[
// double num = random.NextDouble(); // random decimal value [0, 1[

int num1 = random.Next(1, 7);
int num2 = random.Next(1, 7);
int num3 = random.Next(1, 7);

Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);

Console.ReadKey();