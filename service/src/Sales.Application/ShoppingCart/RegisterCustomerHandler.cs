namespace Sales.Application.ShoppingCart
{
    using System.Threading.Tasks;
    using Domain.ShoppingCart.Aggregates.CustomerAggregate;
    using Infrastructure.Data.ShoppingCart.Repositories;
    using Infrastructure.Data.UnitOfWork;

    public class RegisterCustomerHandler
    {
        public async Task HandleAsync(RegisterCustomerCommand command)
        {
            var unitOfWork = new SalesUnitOfWork();

            var repository = new CustomerRepository(unitOfWork);

            var customerName = CustomerName
                .Create(command.CustomerName);

            var customer = new Customer(customerName.Value);

            repository
                .Add(customer);

            await unitOfWork
                .CommitAsync();
        }
    }
}