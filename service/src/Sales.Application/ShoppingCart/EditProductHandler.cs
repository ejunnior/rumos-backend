namespace Sales.Application.ShoppingCart
{
    using System.Threading.Tasks;
    using Domain.ShoppingCart.Aggregates.ProductAggregate;
    using Infrastructure.Data.ShoppingCart.Repositories;
    using Infrastructure.Data.UnitOfWork;

    public class EditProductHandler
    {
        public async Task HandleAsync(EditProductCommand command)
        {
            var unitOfWork = new SalesUnitOfWork();

            var repository = new ProductRepository(unitOfWork);

            var product = await repository
                .GetAsync(command.Id);

            var productName = ProductName
                .Create(command.ProductName);

            product
                .Edit(productName.Value);

            repository
                .Modify(product);

            await unitOfWork
                .CommitAsync();
        }
    }
}