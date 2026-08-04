// method overriding = provides a new version of a method inherited from a parent class
//                     inherited method must be: abstract, virtual, or already overridden
//                     Used with ToString(), polymorphism

using _40._method_overriding;

Dog dog = new Dog();
Cat cat = new Cat();

dog.Speak();
cat.Speak();

Console.ReadKey();