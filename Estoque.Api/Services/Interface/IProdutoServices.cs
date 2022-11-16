using Estoque.Api.Data.Interface;
using Estoque.Api.Model;

namespace Estoque.Api.Services.Interface;

public interface IProdutoServices
{
    void CadastrarProduto(Produto produto);
    List<Produto> ListarTodosProdutos();
    void RemoverProduto(int id);
    void AtualizarProduto(Produto toProduto);
}