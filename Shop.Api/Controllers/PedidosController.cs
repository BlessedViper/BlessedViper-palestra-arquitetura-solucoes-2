using Microsoft.AspNetCore.Mvc;
using Shop.Api.Database.Context;
using Shop.Domain.Dtos;
using Shop.Domain.Interfaces;

namespace Shop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PedidosController(ApiContext context, IProdutoCommand command, IPedidoCommand pedidoCommand) : ControllerBase
{
    [HttpGet]
    public IActionResult ObterPedidos()
    {
        return Ok(pedidoCommand.ObterPedidos());
    }
}
