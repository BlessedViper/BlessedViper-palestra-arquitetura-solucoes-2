using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public List<Produto> Produtos { get; set; }
        public string NomeCliente { get; set; }
        public string Endereco { get; set; }
        public decimal ValorTotal { get; private set; }

        public void CalcularValorTotal()
        {
            if (Produtos != null)
            {
                foreach (var produto in Produtos)
                {
                    ValorTotal += produto.Preco;
                }
            }
        }
    }
}
