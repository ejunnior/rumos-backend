namespace Sales.Application.ShoppingCart
{
    using System.Threading.Tasks;
    using Infrastructure.Data.ShoppingCart.Repositories;
    using Infrastructure.Data.UnitOfWork;

    public class GetProductByIdHandler
    {
        public async Task<GetProductByIdDto> HandlerAsync(GetProductByIdQuery query)
        {
            var unitOfWork = new SalesUnitOfWork();

            var repository = new ProductRepository(unitOfWork);

            var result = await repository
                .Get(query.Id);

            if (result == null)
            {
                return null;
            }

            var dto = new GetProductByIdDto
            {
                Id = result.Id,
                Name = result.ProductName.Value
            };

            return dto;
        }
    }
}