Random random = new Random();
bool playAgain = true;
string response;
int min = 1;
int max = 100;
int number;
int guess;
int guesses;

while (playAgain)
{
    number = random.Next(min, max + 1);
    guess = 0;
    guesses = 0;
    response = "";

    while (guess != number)
    {
        Console.Write("Guess a number between " + min + " - " + max + ": ");
        guess = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Guess: " + guess);

        if (guess > number)
        {
            Console.WriteLine(guess + " is too high!");
        }
        else if (guess < number)
        {
            Console.WriteLine(guess + " is too low!");
        }
        guesses++;
    }
    Console.WriteLine("Number: " + number);
    Console.WriteLine("YOU WIN!");
    Console.WriteLine("Guesses: " + guesses);

    Console.Write("Would you like to play again (Y/N): ");
    response = Console.ReadLine()!;
    response = response.ToUpper();

    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
}

Console.WriteLine("Thanks for playing! ... I guess");

Console.ReadKey();