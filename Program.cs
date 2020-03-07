using System;

namespace Pets_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Pets pet1 = new Pets("dog", "Jax", "Will", 60.5);

            Console.WriteLine("Name: " + pet1.name);
            Console.WriteLine("Weight: " + pet1.weight);
            Console.WriteLine(pet1.getTag());

            Console.WriteLine("");

            Dog dog1 = new Dog("Jace", "Will", 58.7);

            Console.WriteLine("Name: " + dog1.name);
            Console.WriteLine("Weight: " + dog1.weight);
            Console.WriteLine(dog1.getTag());
            Console.WriteLine(dog1.bark(2));

            Console.WriteLine("");

            Cat cat1 = new Cat("Max", "Will", 6.4);
            Console.WriteLine("Name: " + cat1.name);
            Console.WriteLine("Weight: " + cat1.weight);
            Console.WriteLine(cat1.getTag());
            Console.WriteLine(cat1.meow(1));

            Console.WriteLine("\nPress any key to continue...");
        }
    }
}
