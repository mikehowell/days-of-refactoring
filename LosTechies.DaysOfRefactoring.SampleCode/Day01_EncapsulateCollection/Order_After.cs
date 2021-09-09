using System.Collections.Generic;

namespace LosTechies.DaysOfRefactoring.EncapsulateCollection.After
{
	public class Order
	{
		private readonly List<OrderLine> _orderLines;

		public IEnumerable<OrderLine> OrderLines => _orderLines;
        public double OrderTotal { get; private set; }

        public Order()
        {
            _orderLines = new List<OrderLine>();
        }
        public void AddOrderLine(OrderLine orderLine)
		{
			OrderTotal += orderLine.Total;
			_orderLines.Add(orderLine);
		}

		public void RemoveOrderLine(OrderLine orderLine)
		{
			orderLine = _orderLines.Find(o => o == orderLine);

			if (orderLine == null)
				return;

			OrderTotal -= orderLine.Total;
			_orderLines.Remove(orderLine);
		}
	}

	public class OrderLine
	{
		public double Total { get; private set; }

        public OrderLine(int total = 0)
        {
            Total = total;
        }
	}
}