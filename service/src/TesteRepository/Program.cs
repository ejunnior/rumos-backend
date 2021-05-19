using System;

namespace TesteRepository
{
    using Sales.Domain.ShoppingCart.Aggregates.ProductAggregate;
    using Sales.Infrastructure.Data.UnitOfWork;

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

                unitOfWork.Add(product); //commando de insert do sql server

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