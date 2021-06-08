namespace Sales.Infrastructure.Data.ShoppingCart.Repositories
{
    using Domain.Core;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;
    using UnitOfWork;

    public class Repository<TEntity> : IRepository<TEntity>
    {
        private readonly ISalesUnitOfWork _unitOfWork;

        public Repository(ISalesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(TEntity item)
        {
            if (item != null)
            {
                GetSet()
                    .Add(item);
            }
        }

        public void Delete(TEntity item)
        {
            if (item != null)
            {
                //_unitOfWork
                //    .Attach(item);

                GetSet()
                    .Remove(item);
            }
        }

        public async Task<TEntity> GetAsync(int id)
        {
            if (id != default)
            {
                return await GetSet()
                    .FindAsync(id);
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

        private DbSet<TEntity> GetSet()
        {
            return _unitOfWork
                .CreateSet<TEntity>();
        }
    }
}