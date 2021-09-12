using System;
using After = LosTechies.DaysOfRefactoring.PullUpMethod.After;
using Before = LosTechies.DaysOfRefactoring.PullUpMethod.Before;

namespace _03_PullUpMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle_Before();
            Vehicle_After();

            Console.ReadKey();
        }

        private static void Vehicle_Before()
        {
            //Notice how we have to delare the car as a Car type
            //declaring it as a Vehicle will cause a compile error 
            //on the car.Turn method.
            Before.Car car = new Before.Car();
            car.Turn(Before.Direction.Right);

            //Additionally, a motor-cycle cannot turn
            //uncomment to motorcycle.Turn line to verify the compiler error
            Before.Motorcycle motorcycle = new Before.Motorcycle();
            //motorcycle.Turn(Before.Direction.Right);
        }

        private static void Vehicle_After()
        {
            //Notice here that we can declare the car as a Vehicle and
            //still access the Turn method.
            //This is because the Vehicle base class now owns the Turn method.
            After.Vehicle car = new After.Car();
            car.Turn(After.Direction.Right);

            //Additionally, a motor-cycle can now turn
            //even when declared as a motorcycle because Motorcycle inherits Vehicle too.
            After.Motorcycle motorcycle = new After.Motorcycle();
            motorcycle.Turn(After.Direction.Right);
        }
    }
}
