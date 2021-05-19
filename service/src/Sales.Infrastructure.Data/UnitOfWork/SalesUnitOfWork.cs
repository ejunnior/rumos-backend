namespace Sales.Infrastructure.Data.UnitOfWork
{
    using Mapping;
    using Microsoft.EntityFrameworkCore;

    public class SalesUnitOfWork : DbContext
    {
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