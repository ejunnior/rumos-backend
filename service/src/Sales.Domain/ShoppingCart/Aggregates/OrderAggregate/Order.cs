namespace Sales.Domain.ShoppingCart.Aggregates.OrderAggregate
{
    using System;
    using System.Collections.Generic;
    using Core;
    using CustomerAggregate;

    public class Order : AggregateRoot
    {
        public Order()
        {
            OrderDate = DateTime.UtcNow;
        }

        public Customer Customer { get; }

        public string ExpirationDate { get; }

        public string Name { get; }

        public string Number { get; }

        public DateTime OrderDate { get; }

        public IReadOnlyCollection<OrderLine> OrderLines { get; }

        public string SecurityCode { get; }

        public string ShippingInfo { get; }
    }
}