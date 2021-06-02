namespace Sales.Infrastructure.Data.ShoppingCart.Repositories
{
    using System.Runtime.CompilerServices;
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

        public void Delete(TEntity item)
        {
            if (item != null)
            {
                _unitOfWork
                    .Attach(item);

                _unitOfWork
                    .Set<TEntity>()
                    .Remove(item);
            }
        }

        public async Task<TEntity> GetAsync(int id)
        {
            if (id != default)
            {
                return await _unitOfWork
                    .Set<TEntity>().FindAsync(id);
            }

            return null;
        }

        public void Modify(TEntity item)
        {
            if (item != null)
            {
                _unitOfWork.SetModified(item);
            }
        }
    }
}