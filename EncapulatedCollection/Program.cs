using System;
using LosTechies.DaysOfRefactoring.EncapsulateCollection.Before;

namespace EncapulatedCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            var orderLine1 = new OrderLine(10);
            var orderLine2 = new OrderLine(25);
            order.AddOrderLine(orderLine1);
            order.AddOrderLine(orderLine2);

            var listOfOrderLines = order.OrderLines;

            foreach (var orderLines in listOfOrderLines)
            {
                Console.WriteLine(orderLines.Total);
            }
        }
    }
}
