namespace Sales.Domain.Profile.Aggregates.User
{
    using Core;

    public class UserBase : AggregateRoot
    {
        protected UserBase(
            Login login,
            Password password)
        {
            Login = login;
            Password = password;
        }

        protected UserBase()
        {
        }

        public Login Login { get; }

        public Password Password { get; }
    }
}