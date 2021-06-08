namespace Sales.Domain.ShoppingCart.Aggregates.ProductAggregate
{
    using Core;

    public class EditProductCommand : ICommand
    {
        public EditProductCommand(
            int id,
            string productName)
        {
            Id = id;
            ProductName = productName;
        }

        public int Id { get; }
        public string ProductName { get; }
    }
}