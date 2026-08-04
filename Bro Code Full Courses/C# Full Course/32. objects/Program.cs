// object = An instance of a class
//          A class can be used as a blueprint to create objects (OOP)
//          objects can have fields & methods (characteristics & actions)

using _32._objects;

Human human1 = new Human();
Human human2 = new Human();

human1.name = "Rick";
human1.age = 65;

human2.name = "Morty";
human2.age = 16;

human1.Eat();
human1.Sleep();

human2.Eat();
human2.Sleep();

Console.ReadKey();