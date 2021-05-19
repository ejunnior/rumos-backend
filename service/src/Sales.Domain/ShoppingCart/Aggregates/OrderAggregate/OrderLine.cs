namespace Sales.Domain.ShoppingCart.Aggregates.OrderAggregate
{
    using Core;
    using ProductAggregate;

    public class OrderLine : Entity
    {
        public Product Product { get; }

        public int Quantiy { get; }

        public double UnitPrice { get; }
    }
}