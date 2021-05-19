namespace Sales.Domain.ShoppingCart.Aggregates.CartItemAggregate
{
    using Core;
    using ProductAggregate;

    public class CartItem : AggregateRoot
    {
        public Product Product { get; }
    }
}