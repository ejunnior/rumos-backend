namespace Sales.Domain.ShoppingCart.Aggregates.ProductAggregate
{
    public class EditProductCommand
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