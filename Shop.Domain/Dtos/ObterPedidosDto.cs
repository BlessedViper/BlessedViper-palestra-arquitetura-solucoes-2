using Shop.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Dtos
{
    public class ObterPedidosDto
    {
        public int Id { get; set; }
        public List<Produto> Produtos { get; set; }
        public string NomeCliente { get; set; }
        public string Endereco { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
