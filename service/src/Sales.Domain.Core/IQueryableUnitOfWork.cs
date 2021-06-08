using Microsoft.EntityFrameworkCore;

namespace Sales.Domain.Core
{
    public interface IQueryableUnitOfWork : IUnitOfWork
    {
        DbSet<TEntity> CreateSet<TEntity>() where TEntity : AggregateRoot;

        void SetModified<TEntity>(TEntity item) where TEntity : AggregateRoot;
    }
}