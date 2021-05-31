namespace Sales.Domain.ShoppingCart.Aggregates.CustomerAggregate
{
    public class RegisterCustomerCommand
    {
        public RegisterCustomerCommand(string customerName)
        {
            CustomerName = customerName;
        }

        public string CustomerName { get; }
    }
}