namespace Sales.Domain.ShoppingCart.Aggregates.CartItemAggregate
{
    using Core;
    using ProductAggregate;

    public class CartItem : AggregateRoot
    {
        public CartItem(Product product)
        {
            Product = product;
        }

        private CartItem()
        {
        }

        public Product Product { get; }
    }
}