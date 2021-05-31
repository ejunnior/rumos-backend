﻿namespace Sales.Api.ShoppingCart
{
    using System.Threading.Tasks;
    using Application.ShoppingCart;
    using Domain.ShoppingCart.Aggregates.ProductAggregate;
    using Microsoft.AspNetCore.Mvc;

    public class ProductController : BaseController
    {
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> Register([FromBody] RegisterProductDto dto)
        {
            var command = new RegisterProductCommand(dto.ProductName);

            var handler = new RegisterProductHandler();

            await handler.HandleAsync(command);

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