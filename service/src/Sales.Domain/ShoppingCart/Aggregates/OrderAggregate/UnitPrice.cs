using CSharpFunctionalExtensions;

namespace Sales.Domain.ShoppingCart.Aggregates.OrderAggregate
{
    using Core;

    public class UnitPrice : ValueObject<UnitPrice>
    {
        private UnitPrice(decimal value)
        {
            Value = value;
        }

        public decimal Value { get; }

        public static Result<UnitPrice> Create(decimal value)
        {
            return Result
                .Success(new UnitPrice(value));
        }

        public static implicit operator decimal(UnitPrice unitPrice)
        {
            return unitPrice.Value;
        }
    }
}