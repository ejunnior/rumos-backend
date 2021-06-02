namespace Sales.Application.ShoppingCart
{
    using System.Threading.Tasks;
    using Domain.ShoppingCart.Aggregates.ProductAggregate;
    using Infrastructure.Data.ShoppingCart.Repositories;
    using Infrastructure.Data.UnitOfWork;

    public class DeleteProductHandler
    {
        public async Task Handle(DeleteProductCommand command)
        {
            var unitOfWork = new SalesUnitOfWork();

            var repository = new ProductRepository(unitOfWork);

            var product = await repository
                .GetAsync(command.Id);

            repository
                .Delete(product);

            await unitOfWork
                .CommitAsync();
        }
    }
}