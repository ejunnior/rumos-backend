namespace Sales.Application.ShoppingCart
{
    using System.Threading.Tasks;
    using Domain.ShoppingCart.Aggregates.CustomerAggregate;
    using Infrastructure.Data.ShoppingCart.Repositories;
    using Infrastructure.Data.UnitOfWork;

    public class RegisterCustomerHandler
    {
        private readonly ISalesUnitOfWork _unitOfWork;

        public RegisterCustomerHandler(ISalesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task HandleAsync(RegisterCustomerCommand command)
        {
            var repository = new CustomerRepository(_unitOfWork);

            var customerName = CustomerName
                .Create(command.CustomerName);

            var customer = new Customer(customerName.Value);

            repository
                .Add(customer);

            await _unitOfWork
                .CommitAsync();
        }
    }
}