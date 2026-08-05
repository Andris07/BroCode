// List = data structure that represents a list of objects that can be accessed by index.
//        Similar to array, but can dynamically increase/decrease in size
//        using System.Collections.Generic;

//string[] foods = new string[3];

//foods[0] = "pizza";
//foods[1] = "hamburger";
//foods[2] = "hotdog";

List<string> foods = new List<string>();

foods.Add("pizza");
foods.Add("hamburger");
foods.Add("hotdog");

foreach (var food in foods)
{
    Console.WriteLine(food);
}
Console.WriteLine();

foods.Add("fries");

foreach (var food in foods)
{
    Console.WriteLine(food);
}
Console.WriteLine();

foods.Remove("fries");

foods.Insert(0, "sushi");
foods.Add("sushi");

foreach (var food in foods)
{
    Console.WriteLine(food);
}
Console.WriteLine();

Console.WriteLine(foods.IndexOf("sushi"));
Console.WriteLine(foods.LastIndexOf("sushi"));
Console.WriteLine(foods.Contains("sushi"));
foods.RemoveAll(food => food == "sushi");
Console.WriteLine();

foods.Sort();

foreach (var food in foods)
{
    Console.WriteLine(food);
}
Console.WriteLine();

foods.Reverse();

foreach (var food in foods)
{
    Console.WriteLine(food);
}
Console.WriteLine();

string[] foodsArray = foods.ToArray();

foods.Clear();

Console.WriteLine(foods.Count);
Console.WriteLine(foodsArray.Length);

Console.ReadKey();