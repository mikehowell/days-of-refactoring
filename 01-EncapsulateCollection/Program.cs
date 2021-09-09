using System;
using Before = LosTechies.DaysOfRefactoring.EncapsulateCollection.Before;
using After = LosTechies.DaysOfRefactoring.EncapsulateCollection.After;

namespace _01_EncapsulateCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Order_Before();
            Order_After();

            Console.ReadKey();
        }

        private static void Order_Before()
        {
            var order = new Before.Order();
            var orderLine1 = new Before.OrderLine(10);
            var orderLine2 = new Before.OrderLine(25);
            order.AddOrderLine(orderLine1);
            order.AddOrderLine(orderLine2);

            Console.WriteLine($"Order Total: {order.OrderTotal}");
            DisplaySpacing();

            var listOfOrderLines = order.OrderLines;
            
            //NOTE: here we are allowed to replace an existing order line
            //effectively introducing a bug in the program!
            listOfOrderLines[0] = new Before.OrderLine(6);
            
            Console.WriteLine("Value on each order line:");
            double sumTotal = 0;
            var counter = 1;
            foreach (var orderLines in listOfOrderLines)
            {
                sumTotal += orderLines.Total;
                Console.WriteLine($"Order line {counter++} value: {orderLines.Total}");
            }

            Console.WriteLine($"Order line total: {sumTotal}");
            DisplaySpacing();
        }

        private static void Order_After()
        {
            var order = new After.Order();
            var orderLine1 = new After.OrderLine(10);
            var orderLine2 = new After.OrderLine(25);
            order.AddOrderLine(orderLine1);
            order.AddOrderLine(orderLine2);

            Console.WriteLine($"Order Total: {order.OrderTotal}");
            DisplaySpacing();

            var listOfOrderLines = order.OrderLines;

            //NOTE: here we are NOT allowed to replace an existing order line
            //a compile time error prevents the bug - uncomment the line below and build the project.
            //listOfOrderLines[0] = new After.OrderLine(6);

            Console.WriteLine("Value on each order line:");
            double sumTotal = 0;
            var counter = 1;
            foreach (var orderLines in listOfOrderLines)
            {
                sumTotal += orderLines.Total;
                Console.WriteLine($"Order line {counter++} value: {orderLines.Total}");
            }

            Console.WriteLine($"Order line total: {sumTotal}");
            DisplaySpacing();
        }

        private static void DisplaySpacing()
        {
            Console.WriteLine(new string('*',25));
            Console.WriteLine("");
        }
    }
}
