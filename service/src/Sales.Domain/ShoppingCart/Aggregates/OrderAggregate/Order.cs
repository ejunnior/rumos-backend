namespace Sales.Domain.ShoppingCart.Aggregates.OrderAggregate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Core;
    using CustomerAggregate;

    public class Order : AggregateRoot
    {
        private readonly IList<OrderLine> _orderLines;

        public Order()
        {
            OrderDate = DateTime.UtcNow;
            _orderLines = new List<OrderLine>();
        }

        public Customer Customer { get; }

        public string ExpirationDate { get; }

        public string Name { get; }

        public string Number { get; }

        public DateTime OrderDate { get; }

        public IReadOnlyCollection<OrderLine> OrderLines => _orderLines.ToList();

        public string SecurityCode { get; }

        public string ShippingInfo { get; }
    }
}