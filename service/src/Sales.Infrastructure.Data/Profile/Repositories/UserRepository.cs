namespace Sales.Infrastructure.Data.Profile.Repositories
{
    using Domain.Profile.Aggregates.User;
    using ShoppingCart.Repositories;
    using UnitOfWork;

    public class UserRepository : Repository<UserBase>
    {
        public UserRepository(SalesUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}