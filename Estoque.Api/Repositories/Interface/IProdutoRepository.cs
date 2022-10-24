using Estoque.Api.Model;

namespace Estoque.Api.Repositories.Interface;

public interface IProdutoRepository
{
    void CadastrarProduto(Produto produto);
}