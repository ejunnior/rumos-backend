namespace Sales.Domain.Profile.Aggregates.User
{
    public class Supervisor : UserBase
    {
        public Supervisor(
            Login login,
            Password password)
            : base(
                login,
                password)
        {
        }

        private Supervisor()
        {
        }
    }
}