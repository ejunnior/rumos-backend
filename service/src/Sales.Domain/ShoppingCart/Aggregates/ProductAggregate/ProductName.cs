using CSharpFunctionalExtensions;

namespace Sales.Domain.ShoppingCart.Aggregates.ProductAggregate
{
    using Core;

    public class ProductName : ValueObject<ProductName>
    {
        private ProductName(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static Result<ProductName> Create(string value)
        {
            return Result
                .Success(new ProductName(value));
        }

        public static implicit operator string(ProductName productName)
        {
            return productName.Value;
        }
    }
}