namespace Sales.Infrastructure.Data.UnitOfWork
{
    using System.Threading.Tasks;
    using Domain.Core;
    using Mapping;
    using Microsoft.EntityFrameworkCore;

    public class SalesUnitOfWork : DbContext, ISalesUnitOfWork
    {
        public async Task CommitAsync()
        {
            await base.SaveChangesAsync();
        }

        public DbSet<TEntity> CreateSet<TEntity>()
                    where TEntity : AggregateRoot
        {
            return base
                .Set<TEntity>();
        }

        public void SetModified<TEntity>(TEntity item) where TEntity : AggregateRoot
        {
            base.Entry<TEntity>(item).State = EntityState.Modified;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Data Source=(local);Initial Catalog=Db_Sales");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(ProductMap).Assembly);
        }
    }
}