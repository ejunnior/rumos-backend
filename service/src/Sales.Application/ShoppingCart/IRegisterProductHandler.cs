namespace Sales.Application.ShoppingCart
{
    using Domain.Core;
    using Domain.ShoppingCart.Aggregates.ProductAggregate;

    public interface IRegisterProductHandler : ICommandHandler<RegisterProductCommand>
    {
    }
}