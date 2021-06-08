namespace Sales.Application.ShoppingCart
{
    using System.Threading.Tasks;
    using Domain.ShoppingCart.Aggregates.ProductAggregate;
    using Infrastructure.Data.ShoppingCart.Repositories;
    using Infrastructure.Data.UnitOfWork;

    public class DeleteProductHandler : IDeleteProductHandler
    {
        private readonly IProductRepository _repository;
        private readonly ISalesUnitOfWork _unitOfWork;

        public DeleteProductHandler(
            ISalesUnitOfWork unitOfWork,
            IProductRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task HandleAsync(DeleteProductCommand args)
        {
            var product = await _repository
                .GetAsync(args.Id);

            _repository
                .Delete(product);

            await _unitOfWork
                .CommitAsync();
        }
    }
}