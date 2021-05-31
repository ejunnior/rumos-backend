using Microsoft.AspNetCore.Mvc;

namespace Sales.Api.ShoppingCart
{
    using System.Threading.Tasks;
    using Application.ShoppingCart;
    using Domain.ShoppingCart.Aggregates.CustomerAggregate;

    public class CustomerController : BaseController
    {
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> Register([FromBody] RegisterCustomerDto dto)
        {
            var handler = new RegisterCustomerHandler();

            var command = new RegisterCustomerCommand(dto.CustomerName);

            await handler
                .HandleAsync(command);

            return Ok();
        }
    }
}