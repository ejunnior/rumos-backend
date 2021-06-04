namespace Sales.Infrastructure.Data.UnitOfWork.Mapping
{
    using Domain.Profile.Aggregates.User;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserMap : IEntityTypeConfiguration<UserBase>
    {
        public void Configure(EntityTypeBuilder<UserBase> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder.Property(p => p.Login)
                .HasConversion(p => p.Value,
                    p => Login.Create(p).Value)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnType("varchar");

            builder.Property(p => p.Password)
                .HasConversion(p => p.Value,
                    p => Password.Create(p).Value)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnType("varchar");

            builder
                .ToTable("User");
        }
    }
}