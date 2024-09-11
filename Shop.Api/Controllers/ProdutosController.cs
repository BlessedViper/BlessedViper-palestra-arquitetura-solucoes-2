using Microsoft.AspNetCore.Mvc;
using Shop.Api.Database.Context;
using Shop.Domain.Dtos;
using Shop.Domain.Interfaces;

namespace Shop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProdutosController(ApiContext context, IAlterarProdutoCommand command) : ControllerBase
{
    [HttpGet]
    public IActionResult ObterProdutos()
    {
        return Ok(context.Products);
    }

    [HttpPut]
    public IActionResult EditarProduto([FromBody] AlterarProdutoDto dto)
    {
        command.AlterarProduto(dto);
        return Ok();
    }
}
