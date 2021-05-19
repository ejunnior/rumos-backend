namespace Sales.Domain.ShoppingCart.Aggregates.CustomerAggregate
{
    using Core;

    public class Address : Entity
    {
        public Address(
            string identification,
            string postalCode)
        {
            Identification = identification;
            PostalCode = postalCode;
        }

        public string Identification { get; }

        public string PostalCode { get; }
    }
}