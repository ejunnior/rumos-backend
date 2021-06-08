using Microsoft.AspNetCore.Mvc;

namespace Sales.Api.ShoppingCart
{
    using System.Threading.Tasks;
    using Application.ShoppingCart;
    using Domain.ShoppingCart.Aggregates.CustomerAggregate;
    using Infrastructure.Data.UnitOfWork;

    public class CustomerController : BaseController
    {
        private readonly IRegisterCustomerHandler _handler;

        public CustomerController(IRegisterCustomerHandler handler)
        {
            _handler = handler;
        }

        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> Register([FromBody] RegisterCustomerDto dto)
        {
            var command = new RegisterCustomerCommand(dto.CustomerName);

            await _handler
                .HandleAsync(command);

            return Ok();
        }
    }
}