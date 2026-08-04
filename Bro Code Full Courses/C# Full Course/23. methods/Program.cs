// method = performs a section of code, whenever it's called "invoked".
//          benefit = Let's us reuse code w/o writing it multiple times

string name = "Bro";
int age = 21;

singHappyBirthday(name, age);

static void singHappyBirthday(string birthdayBoy, int yearsOld)
{
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine($"Happy birthday dear {birthdayBoy}!");
    Console.WriteLine($"You are {yearsOld} years old!");
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine();
}

Console.ReadKey();