Console.Write("What's your name? ");
string name = Console.ReadLine()!;

Console.Write("What's your age? ");
int age = int.Parse(Console.ReadLine()!);

Console.WriteLine("Hello " + name);
Console.WriteLine("You are " + age + " years old");

Console.ReadKey();