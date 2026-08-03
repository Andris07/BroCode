// if statement = a basic form of decision making

Console.Write("Please enter your age: ");
int age = int.Parse(Console.ReadLine()!);

if (age > 100)
{
    Console.WriteLine("You are too old to sign up!");
}
else if (age >= 18)
{
    Console.WriteLine("You are now signed up!");
}
else if (age < 0)
{
    Console.WriteLine("You haven't been born yet!");
}
else
{
    Console.WriteLine("You must be 18+ to sign up!");
}

Console.Write("Please enter your name: ");
string name = Console.ReadLine()!;

if (name == "")
{
    Console.WriteLine("You did not enter your name!");
}
else
{
    Console.WriteLine("Hello " + name);
}

//if (name != "")
//{
//    Console.WriteLine("Hello " + name);
//}
//else
//{
//    Console.WriteLine("You did not enter your name!");
//}

Console.ReadKey();