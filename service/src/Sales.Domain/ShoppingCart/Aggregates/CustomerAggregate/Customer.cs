namespace Sales.Domain.ShoppingCart.Aggregates.CustomerAggregate
{
    using System.Collections.Generic;
    using Core;
    using System.Linq;

    public class Customer : AggregateRoot
    {
        private readonly IList<Address> _addresses;

        public Customer(
            CustomerName customerName)
        {
            CustomerName = customerName;
            _addresses = new List<Address>();
        }

        public IReadOnlyCollection<Address> Addresses => _addresses.ToList();

        public CustomerName CustomerName { get; }

        public void AddAddress(
            string identification,
            string postalCode)
        {
            var address =
                new Address(identification, postalCode);

            _addresses.Add(address);
        }
    }
}