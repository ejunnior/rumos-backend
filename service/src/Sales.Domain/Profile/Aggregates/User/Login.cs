using CSharpFunctionalExtensions;

namespace Sales.Domain.Profile.Aggregates.User
{
    using Core;

    public class Login : ValueObject<Login>
    {
        private Login(string value)
        {
            Value = value;
        }

        private Login()
        {
        }

        public string Value { get; }

        public static Result<Login> Create(string value)
        {
            return Result
                .Success(new Login(value));
        }

        public static implicit operator string(Login login)
        {
            return login.Value;
        }
    }
}