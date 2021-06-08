namespace Sales.Infrastructure.Data.ShoppingCart.Repositories
{
    using Domain.ShoppingCart.Aggregates.CustomerAggregate;
    using UnitOfWork;

    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ISalesUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}