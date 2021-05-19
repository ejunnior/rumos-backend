namespace Sales.Domain.ShoppingCart.Aggregates.CustomerAggregate
{
    using CSharpFunctionalExtensions;

    public class CustomerName : Core.ValueObject<CustomerName>
    {
        private CustomerName(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static Result<CustomerName> Create(string value)
        {
            return Result
                .Success(new CustomerName(value));
        }

        public static implicit operator string(CustomerName customerName)
        {
            return customerName.Value;
        }
    }
}