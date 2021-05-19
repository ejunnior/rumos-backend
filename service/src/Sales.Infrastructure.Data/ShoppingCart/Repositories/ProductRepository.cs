namespace Sales.Infrastructure.Data.ShoppingCart.Repositories
{
    using Domain.ShoppingCart.Aggregates.ProductAggregate;
    using UnitOfWork;

    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(SalesUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}