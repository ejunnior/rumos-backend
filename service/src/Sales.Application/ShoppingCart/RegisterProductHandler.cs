namespace Sales.Application.ShoppingCart
{
    using System.Threading.Tasks;
    using Domain.ShoppingCart.Aggregates.ProductAggregate;
    using Infrastructure.Data.UnitOfWork;
    using Sales.Infrastructure.Data.ShoppingCart.Repositories;

    public class RegisterProductHandler
    {
        public RegisterProductHandler()
        {
        }

        public async Task HandleAsync(RegisterProductCommand args)
        {
            var unitOfWork = new SalesUnitOfWork();

            var repository = new ProductRepository(unitOfWork);

            var productName = ProductName
                .Create(args.ProductName);

            var product = new Product(productName.Value);

            repository
                .Add(product);

            await unitOfWork
                .CommitAsync();
        }
    }
}