using CSharpFunctionalExtensions;

namespace Sales.Domain.Profile.Aggregates.User
{
    using Core;

    public class Password : ValueObject<Password>
    {
        private Password(string value)
        {
            Value = value;
        }

        private Password()
        {
        }

        public string Value { get; }

        public static Result<Password> Create(string value)
        {
            return Result
                .Success(new Password(value));
        }

        public static implicit operator string(Password password)
        {
            return password.Value;
        }
    }
}