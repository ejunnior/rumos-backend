namespace Sales.Application.ShoppingCart
{
    using Domain.Core;
    using Domain.ShoppingCart.Aggregates.CustomerAggregate;

    public interface IRegisterCustomerHandler : ICommandHandler<RegisterCustomerCommand>
    {
    }
}