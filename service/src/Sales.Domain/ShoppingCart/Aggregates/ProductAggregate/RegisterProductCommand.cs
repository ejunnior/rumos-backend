namespace Sales.Domain.ShoppingCart.Aggregates.ProductAggregate
{
    public class RegisterProductCommand
    {
        public RegisterProductCommand(string productName)
        {
            ProductName = productName;
        }

        public string ProductName { get; }
    }
}