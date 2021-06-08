namespace Sales.Api.ShoppingCart
{
    using System.Threading.Tasks;
    using Application.ShoppingCart;
    using Domain.ShoppingCart.Aggregates.ProductAggregate;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.VisualBasic;

    public class ProductController : BaseController
    {
        private readonly IDeleteProductHandler _deleteHandler;
        private readonly IEditProductHandler _editHandler;
        private readonly IRegisterProductHandler _registerHandler;

        public ProductController(
            IRegisterProductHandler registerHandler,
            IDeleteProductHandler deleteHandler,
            IEditProductHandler editHandler)
        {
            _registerHandler = registerHandler;
            _deleteHandler = deleteHandler;
            _editHandler = editHandler;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteProductCommand(id);

            await _deleteHandler.HandleAsync(command);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] EditProductDto dto)
        {
            var command = new EditProductCommand(
                id: id,
                productName: dto.ProductName);

            await _editHandler
                .HandleAsync(command);

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var query = new GetProductByIdQuery(id);

            var handler = new GetProductByIdHandler();

            var result = await handler
                .HandlerAsync(query);

            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }
        }

        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> Register([FromBody] RegisterProductDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = new RegisterProductCommand(dto.ProductName);

            await _registerHandler.HandleAsync(command);

            return Ok(); //Http200
        }

        //await operacoes de inboud/outbound (ex: banco de dados, escrita de arquivos em HD...)
        //Protocolo HTTP:
        //POST - criar um novo resource
        //PUT - alterar um resource
        //Delete - excluir um novo resource
        //Get -- obter um resource - consulta
        //Patch - alteracao parcial do seu resource
    }
}