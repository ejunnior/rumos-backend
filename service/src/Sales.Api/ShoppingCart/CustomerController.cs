using Microsoft.AspNetCore.Mvc;

namespace Sales.Api.ShoppingCart
{
    using System.Threading.Tasks;
    using Application.ShoppingCart;
    using Domain.ShoppingCart.Aggregates.CustomerAggregate;
    using Infrastructure.Data.UnitOfWork;

    public class CustomerController : BaseController
    {
        private readonly ISalesUnitOfWork _unitOfWork;

        public CustomerController(ISalesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> Register([FromBody] RegisterCustomerDto dto)
        {
            var handler = new RegisterCustomerHandler(_unitOfWork);

            var command = new RegisterCustomerCommand(dto.CustomerName);

            await handler
                .HandleAsync(command);

            return Ok();
        }
    }
}