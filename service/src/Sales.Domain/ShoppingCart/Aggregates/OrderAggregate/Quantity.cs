using CSharpFunctionalExtensions;

namespace Sales.Domain.ShoppingCart.Aggregates.OrderAggregate
{
    using Core;

    public class Quantity : ValueObject<Quantity>
    {
        private Quantity(int value)
        {
            Value = value;
        }

        public int Value { get; }

        //Factory
        public static Result<Quantity> Create(int value)
        {
            if (value > 0)
            {
            }
            return Result
                .Success(new Quantity(value));
        }

        public static implicit operator int(Quantity quantity)
        {
            return quantity.Value;
        }
    }
}