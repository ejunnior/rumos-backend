namespace Sales.Domain.Profile.Aggregates.User
{
    public class Administrator : UserBase
    {
        public Administrator(
            Login login,
            Password password)
            : base(
                login,
                password)
        {
        }

        private Administrator()
        {
        }
    }
}