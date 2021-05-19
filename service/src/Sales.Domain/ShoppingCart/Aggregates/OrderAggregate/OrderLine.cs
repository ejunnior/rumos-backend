namespace Sales.Domain.ShoppingCart.Aggregates.OrderAggregate
{
    using Core;
    using ProductAggregate;

    public class OrderLine : Entity
    {
        public OrderLine(
            Product product,
            Quantity quantity,
            UnitPrice unitPrice)
        {
            Product = product;
            Quantiy = quantity;
            UnitPrice = unitPrice;
        }

        public Product Product { get; }

        public Quantity Quantity { get; }

        public UnitPrice UnitPrice { get; }
    }
}