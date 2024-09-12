using Shop.Domain.Dtos;

namespace Shop.Domain.Interfaces
{
    public interface IProdutoCommand
    {
        void AlterarProduto(AlterarProdutoDto dto);

        int AdicionarProduto(AdicionarProdutoDto dto);

        void DeletarProduto(int id);

        ObterProdutoDto ObterProdutoPorId(int id);
    }
}
