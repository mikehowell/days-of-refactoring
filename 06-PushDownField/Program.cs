using System;
using After = LosTechies.DaysOfRefactoring.PushDownField.After;
using Before = LosTechies.DaysOfRefactoring.PushDownField.Before;

namespace _06_PushDownField
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_Before();
            Task_After();

            Console.ReadKey();
        }

        private static void Task_Before()
        {
            // In this example, the Abstract Task Class implements a Resolution property
            // however, it doesn't make much sense for a feature to have a resolution.

            var bug = new Before.BugTask {Resolution = "fixed"};
            Console.WriteLine($"The bug was {bug.Resolution}");

            var feature = new Before.FeatureTask {Resolution = "implemented"};
            Console.WriteLine($"The feature was {feature.Resolution}");
        }

        private static void Task_After()
        {
            // In this example, the Resolution property has been pushed down to
            // the BugTask Class.  It makes sense for the BugTaks to own this property
            // and not a FeatureTask.
            var bug = new After.BugTask {Resolution = "fixed"};
            Console.WriteLine($"The bug was {bug.Resolution}");

            // uncommenting these lines will reveal a compiler error
            //var feature = new After.FeatureTask {Resolution = "implemented"};
            //Console.WriteLine($"The feature was {feature.Resolution}");
        }
    }
}
