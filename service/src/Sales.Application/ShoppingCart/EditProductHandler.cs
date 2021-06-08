namespace Sales.Application.ShoppingCart
{
    using System.Threading.Tasks;
    using Domain.ShoppingCart.Aggregates.ProductAggregate;
    using Infrastructure.Data.ShoppingCart.Repositories;
    using Infrastructure.Data.UnitOfWork;

    public class EditProductHandler : IEditProductHandler
    {
        private readonly IProductRepository _repository;
        private readonly ISalesUnitOfWork _unitOfWork;

        public EditProductHandler(
            ISalesUnitOfWork unitOfWork,
            IProductRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task HandleAsync(EditProductCommand command)
        {
            var product = await _repository
                .GetAsync(command.Id);

            var productName = ProductName
                .Create(command.ProductName);

            product
                .Edit(productName.Value);

            _repository
                .Modify(product);

            await _unitOfWork
                .CommitAsync();
        }
    }
}