namespace Sales.Infrastructure.Data.UnitOfWork.Mapping
{
    using Domain.Profile.Aggregates.User;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SupervisorMap : IEntityTypeConfiguration<Supervisor>
    {
        public void Configure(EntityTypeBuilder<Supervisor> builder)
        {
            //builder
            //    .HasKey(p => p.Id);
            builder.ToTable("Supervisor");
        }
    }
}