namespace Sales.Infrastructure.Data.ShoppingCart.Repositories
{
    using System.Threading.Tasks;
    using Domain.Core;
    using UnitOfWork;

    public class Repository<TEntity>
        where TEntity : AggregateRoot
    {
        private readonly SalesUnitOfWork _unitOfWork;

        public Repository(SalesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(TEntity item)
        {
            if (item != null)
            {
                _unitOfWork
                    .Set<TEntity>().Add(item);
            }
        }

        public async Task<TEntity> Get(int id)
        {
            if (id != default)
            {
                return await _unitOfWork
                    .Set<TEntity>().FindAsync(id);
            }

            return null;
        }
    }
}