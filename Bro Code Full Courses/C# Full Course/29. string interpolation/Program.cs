// string interpolation = allows us to insert variables into a string literal
//                        precede a string literal with $
//                        {} are placeholders

string firstName = "Bro";
string lastName = "Code";
int age = 21;

//Console.WriteLine("Hello " + firstName + " " + lastName + ".");
//Console.WriteLine("You are " + age + " years old.");

Console.WriteLine($"Hello {firstName} {lastName}.");
Console.WriteLine($"You are {age} years old.");
// Console.WriteLine($"You are {age, 3} years old."); this would use 3 characters with right padding, using whitespaces where it wouldn't be anything, negative 3 would use left padding instead of right

Console.ReadKey();