using Shop.Api.Database.Context;
using Shop.Domain.Dtos;
using Shop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Commands
{
    public class PedidoCommand(ApiContext context) : IPedidoCommand
    {
        public List<ObterPedidosDto> ObterPedidos()
        {
            var pedidos = new List<ObterPedidosDto>();

            foreach(var item in context.Pedidos)
            {
                item.CalcularValorTotal();

                var pedido = new ObterPedidosDto
                {
                    Id = item.Id,
                    Endereco = item.Endereco,
                    NomeCliente = item.NomeCliente,
                    Produtos = item.Produtos,
                    ValorTotal = item.ValorTotal,
                };

                pedidos.Add(pedido);
            }

            return pedidos;
        }
    }
}
