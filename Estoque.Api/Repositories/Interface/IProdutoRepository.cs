using Estoque.Api.Model;

namespace Estoque.Api.Repositories.Interface;

public interface IProdutoRepository
{
    void Criar(Produto produto);
}