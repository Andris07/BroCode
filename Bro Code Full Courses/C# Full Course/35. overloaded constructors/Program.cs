// overloaded constructors = technique to create multiple constructors,
//                           with a different set of parameters,
//                           name + parameters = signature

using _35._overloaded_constructors;

Pizza pizza1 = new Pizza("stuffed crust");
Pizza pizza2 = new Pizza("stuffed crust", "red sauce");
Pizza pizza3 = new Pizza("stuffed crust", "red sauce", "mozzarella");
Pizza pizza4 = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");

Console.ReadKey();