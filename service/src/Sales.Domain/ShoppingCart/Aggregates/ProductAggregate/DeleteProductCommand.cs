namespace Sales.Domain.ShoppingCart.Aggregates.ProductAggregate
{
    public class DeleteProductCommand
    {
        public DeleteProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}