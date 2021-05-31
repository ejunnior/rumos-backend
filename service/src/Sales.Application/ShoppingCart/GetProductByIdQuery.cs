namespace Sales.Application.ShoppingCart
{
    public class GetProductByIdQuery
    {
        public GetProductByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}