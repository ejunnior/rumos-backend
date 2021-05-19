﻿using CSharpFunctionalExtensions;

namespace Sales.Domain.ShoppingCart.Aggregates.CustomerAggregate
{
    using Core;

    public class ProductName : Core.ValueObject<ProductName>
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

        public static implicit operator string(ProductName customerName)
        {
            return customerName.Value;
        }
    }
}