namespace Sales.Domain.ShoppingCart.Aggregates.CustomerAggregate
{
    using Core;

    public class RegisterCustomerCommand : ICommand
    {
        public RegisterCustomerCommand(string customerName)
        {
            CustomerName = customerName;
        }

        public string CustomerName { get; }
    }
}