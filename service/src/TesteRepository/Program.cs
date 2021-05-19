using System;

namespace TesteRepository
{
    using Sales.Domain.ShoppingCart.Aggregates.CustomerAggregate;
    using Sales.Domain.ShoppingCart.Aggregates.ProductAggregate;
    using Sales.Infrastructure.Data.ShoppingCart.Repositories;
    using Sales.Infrastructure.Data.UnitOfWork;
    using ProductName = Sales.Domain.ShoppingCart.Aggregates.ProductAggregate.ProductName;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite o nome do seu produto");

            var input = Console.ReadLine();

            var productName = ProductName
                .Create(input);

            if (productName.IsSuccess)
            {
                var product = new Product(productName.Value);

                var unitOfWork = new SalesUnitOfWork();

                //var repository = new Repository<Product>(unitOfWork);
                var repository = new ProductRepository(unitOfWork);

                repository.Add(product);

                //unitOfWork.Add(product); //commando de insert do sql server

                unitOfWork.SaveChanges(); //Comando de commit do sql server

                Console.WriteLine("Sucesso!");
            }
            else
            {
                Console.WriteLine(productName.Error);
            }

            Console.ReadKey();
        }
    }
}