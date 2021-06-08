namespace Sales.Domain.ShoppingCart.Aggregates.ProductAggregate
{
    using Core;

    public class DeleteProductCommand : ICommand
    {
        public DeleteProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}