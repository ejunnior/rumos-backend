// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sales.Infrastructure.Data.UnitOfWork;

namespace Sales.Infrastructure.Data.Migrations
{
    [DbContext(typeof(SalesUnitOfWork))]
    [Migration("20210604110601_ProfileFeature_RenamingUserTable")]
    partial class ProfileFeature_RenamingUserTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sales.Domain.Profile.Aggregates.User.UserBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Sales.Domain.ShoppingCart.Aggregates.CartItemAggregate.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("Sales.Domain.ShoppingCart.Aggregates.CustomerAggregate.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("char(7)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Sales.Domain.ShoppingCart.Aggregates.CustomerAggregate.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Sales.Domain.ShoppingCart.Aggregates.OrderAggregate.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Sales.Domain.ShoppingCart.Aggregates.OrderAggregate.OrderLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(7,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderLine");
                });

            modelBuilder.Entity("Sales.Domain.ShoppingCart.Aggregates.ProductAggregate.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Sales.Domain.Profile.Aggregates.User.Administrator", b =>
                {
                    b.HasBaseType("Sales.Domain.Profile.Aggregates.User.UserBase");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("Sales.Domain.Profile.Aggregates.User.Supervisor", b =>
                {
                    b.HasBaseType("Sales.Domain.Profile.Aggregates.User.UserBase");

                    b.ToTable("Supervisor");
                });

            modelBuilder.Entity("Sales.Domain.ShoppingCart.Aggregates.CartItemAggregate.CartItem", b =>
                {
                    b.HasOne("Sales.Domain.ShoppingCart.Aggregates.ProductAggregate.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Sales.Domain.ShoppingCart.Aggregates.CustomerAggregate.Address", b =>
                {
                    b.HasOne("Sales.Domain.ShoppingCart.Aggregates.CustomerAggregate.Customer", null)
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sales.Domain.ShoppingCart.Aggregates.OrderAggregate.Order", b =>
                {
                    b.HasOne("Sales.Domain.ShoppingCart.Aggregates.CustomerAggregate.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Sales.Domain.ShoppingCart.Aggregates.OrderAggregate.OrderLine", b =>
                {
                    b.HasOne("Sales.Domain.ShoppingCart.Aggregates.OrderAggregate.Order", null)
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sales.Domain.ShoppingCart.Aggregates.ProductAggregate.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Sales.Domain.Profile.Aggregates.User.Administrator", b =>
                {
                    b.HasOne("Sales.Domain.Profile.Aggregates.User.UserBase", null)
                        .WithOne()
                        .HasForeignKey("Sales.Domain.Profile.Aggregates.User.Administrator", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sales.Domain.Profile.Aggregates.User.Supervisor", b =>
                {
                    b.HasOne("Sales.Domain.Profile.Aggregates.User.UserBase", null)
                        .WithOne()
                        .HasForeignKey("Sales.Domain.Profile.Aggregates.User.Supervisor", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sales.Domain.ShoppingCart.Aggregates.CustomerAggregate.Customer", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Sales.Domain.ShoppingCart.Aggregates.OrderAggregate.Order", b =>
                {
                    b.Navigation("OrderLines");
                });
#pragma warning restore 612, 618
        }
    }
}
