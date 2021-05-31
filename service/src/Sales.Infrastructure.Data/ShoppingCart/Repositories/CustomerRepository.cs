namespace Sales.Infrastructure.Data.ShoppingCart.Repositories
{
    using Domain.ShoppingCart.Aggregates.CustomerAggregate;
    using UnitOfWork;

    public class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository(SalesUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}