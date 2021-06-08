namespace Sales.Domain.ShoppingCart.Aggregates.ProductAggregate
{
    using Core;

    public class RegisterProductCommand : ICommand
    {
        public RegisterProductCommand(string productName)
        {
            ProductName = productName;
        }

        public string ProductName { get; }
    }
}