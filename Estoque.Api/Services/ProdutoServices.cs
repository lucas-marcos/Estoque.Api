using Estoque.Api.Model;
using Estoque.Api.Repositories.Interface;
using Estoque.Api.Services.Interface;

namespace Estoque.Api.Services;

public class ProdutoServices : IProdutoServices
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoServices(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public void CadastrarProduto(Produto produto)
    {
        _produtoRepository.CadastrarProduto(produto);
    }

    public List<Produto> ListarTodosProdutos()
    {
        return _produtoRepository.BuscarTodos().ToList();
    }
}