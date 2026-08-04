// constructor = A special method in a class
//               Same name as the class name
//               Can be used to assign arguments to fields when creating an object

using _33._constructors;

Human human1 = new Human("Rick", 65);
Human human2 = new Human("Morty", 16);

human1.Eat();
human1.Sleep();

human2.Eat();
human2.Sleep();

Console.WriteLine();

Car car1 = new Car("Ford", "Mustang", 2022, "red");
Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

car1.Drive();
car2.Drive();

Console.ReadKey();