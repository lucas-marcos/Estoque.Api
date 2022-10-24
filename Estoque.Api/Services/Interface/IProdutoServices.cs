using Estoque.Api.Model;

namespace Estoque.Api.Services.Interface;

public interface IProdutoServices
{
    void CadastrarProduto(Produto produto);
}