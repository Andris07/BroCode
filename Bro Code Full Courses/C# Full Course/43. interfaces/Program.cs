// interface = defines a "contract" that all the classes inheriting from should follow

//             An interface declares "what a class should have"
//             An inheriting class defines "how it should do it"

//             Benefit = security + multiple inheritance + "plug-and-play"

using _43._interfaces;

Rabbit rabbit = new Rabbit();
Hawk hawk = new Hawk();
Fish fish = new Fish();

rabbit.Flee();
hawk.Hunt();
fish.Flee();
fish.Hunt();

Console.ReadKey();