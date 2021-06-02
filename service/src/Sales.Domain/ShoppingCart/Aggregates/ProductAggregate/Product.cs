namespace Sales.Domain.ShoppingCart.Aggregates.ProductAggregate
{
    using Core;

    public class Product : AggregateRoot
    {
        public Product(ProductName productName)
        {
            ProductName = productName;
        }

        public ProductName ProductName { get; private set; }

        public void Edit(ProductName productName)
        {
            ProductName = productName;
        }
    }
}