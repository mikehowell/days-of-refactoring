using System;
using After = LosTechies.DaysOfRefactoring.Rename.After;
using Before = LosTechies.DaysOfRefactoring.Rename.Before;

namespace _07_Rename
{
    class Program
    {
        static void Main(string[] args)
        {
            Person_Before();
            Person_After();

            Console.ReadKey();
        }

        private static void Person_Before()
        {
            // Renaming is a powerful refactoring tool and probably one of the first that
            // should be used.  It is certainly the easiest, although choosing a good name
            // can be challenging.
            // compare how unreadable this code is when compared with the after example.

            var employee1 = new Before.Person {FN = "Bob"};
            Console.WriteLine($"Hourly pay is {employee1.ClcHrlyPR()}");
        }

        private static void Person_After()
        {
            var employee1 = new After.Employee {FirstName = "Bob"};
            Console.WriteLine($"Hourly pay is {employee1.CalculateHourlyPay()}");
        }
    }
}
