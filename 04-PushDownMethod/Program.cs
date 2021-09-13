using System;
using After = LosTechies.DaysOfRefactoring.PushDownMethod.After;
using Before = LosTechies.DaysOfRefactoring.PushDownMethod.Before;

namespace _04_PushDownMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal_Before();
            Animal_After();

            Console.ReadKey();
        }

        private static void Animal_Before()
        {
            Before.Dog dog = new Before.Dog();
            dog.Bark();

            // Notice that the cat can bark because the Bark method is part of the 
            // Abstract Animal Class and Cat inherits Animal
            // This is true if the cat object is declared as an Animal e.g
            
            //Before.Animal cat = new Before.Cat();
            
            Before.Cat cat = new Before.Cat();
            cat.Bark();
        }

        private static void Animal_After()
        {
            After.Dog dog = new After.Dog();
            dog.Bark();

            // By Pulling Down the Bark method from the Abstract Animal Class
            // into the Dog Class, only the dog barks. The cat cannot bark.
            // Uncomment the cat.Bark() line to see the compiler error.
            After.Cat cat = new After.Cat();
            //cat.Bark();
        }
    }
}
