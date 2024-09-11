using Shop.Domain.Dtos;

namespace Shop.Domain.Interfaces
{
    public interface IAlterarProdutoCommand
    {
        void AlterarProduto(AlterarProdutoDto dto);
    }
}
