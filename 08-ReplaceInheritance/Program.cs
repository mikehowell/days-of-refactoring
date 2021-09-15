using System;
using After = LosTechies.DaysOfRefactoring.ReplaceInheritance.After;
using Before = LosTechies.DaysOfRefactoring.ReplaceInheritance.Before;

namespace _08_ReplaceInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Child_Before();
            Child_After();

            Console.ReadKey();
        }

        private static void Child_Before()
        {
            var billy = new Before.Child();
            Console.WriteLine(billy.WashHands());
        }

        private static void Child_After()
        {
            var cleaningRouting = new After.CleaningRoutine();
            var billy = new After.Child(cleaningRouting);
            Console.WriteLine(billy.WashHands());
        }
    }
}
