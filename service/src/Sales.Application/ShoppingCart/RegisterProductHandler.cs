namespace Sales.Application.ShoppingCart
{
    using System.Threading.Tasks;
    using Domain.ShoppingCart.Aggregates.CustomerAggregate;
    using Domain.ShoppingCart.Aggregates.ProductAggregate;
    using Infrastructure.Data.UnitOfWork;
    using Sales.Infrastructure.Data.ShoppingCart.Repositories;

    public class RegisterProductHandler : IRegisterProductHandler
    {
        private readonly IProductRepository _repository;
        private readonly ISalesUnitOfWork _unitOfWork;

        public RegisterProductHandler(
            ISalesUnitOfWork unitOfWork,
            IProductRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task HandleAsync(RegisterProductCommand args)
        {
            var productName = ProductName
                .Create(args.ProductName);

            if (productName.IsSuccess)
            {
                var product = new Product(productName.Value);

                _repository
                    .Add(product);

                await _unitOfWork
                    .CommitAsync();
            }
        }
    }
}