namespace Sales.Application.ShoppingCart
{
    using Domain.ShoppingCart.Aggregates.CustomerAggregate;
    using Infrastructure.Data.UnitOfWork;
    using System.Threading.Tasks;

    public class RegisterCustomerHandler : IRegisterCustomerHandler
    {
        private readonly ICustomerRepository _repository;
        private readonly ISalesUnitOfWork _unitOfWork;

        public RegisterCustomerHandler(
            ISalesUnitOfWork unitOfWork,
            ICustomerRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task HandleAsync(RegisterCustomerCommand command)
        {
            var customerName = CustomerName
                .Create(command.CustomerName);

            var customer = new Customer(customerName.Value);

            _repository
                .Add(customer);

            await _unitOfWork
                .CommitAsync();
        }
    }
}