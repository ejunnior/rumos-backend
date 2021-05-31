namespace Sales.Api.ShoppingCart
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    public class ProductController : BaseController
    {
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> Register()
        {
            //await operacoes de inboud/outbound (ex: banco de dados, escrita de arquivos em HD...)
        }

        //Protocolo HTTP:
        //POST - criar um novo resource
        //PUT - alterar um resource
        //Delete - excluir um novo resource
        //Get -- obter um resource - consulta
        //Patch - alteracao parcial do seu resource
    }
}