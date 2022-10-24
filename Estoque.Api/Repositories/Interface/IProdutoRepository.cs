using Estoque.Api.Data.Interface;
using Estoque.Api.Model;

namespace Estoque.Api.Repositories.Interface;

public interface IProdutoRepository : IRepository<Produto>
{
    void CadastrarProduto(Produto produto);
}