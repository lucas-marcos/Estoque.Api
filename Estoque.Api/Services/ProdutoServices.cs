using Estoque.Api.Framework;
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

    public void RemoverProduto(int id)
    {
        var produto = _produtoRepository.BuscarPorId(id) ?? throw new Exception("Não foi possível encontrar o produto informado");
        
        _produtoRepository.Remover(produto.Id);
        _produtoRepository.Salvar();
    }

    public void AtualizarProduto(Produto produtoParaAtualizar)
    {
        var produtoCadastrado = _produtoRepository.BuscarPorId(produtoParaAtualizar.Id) ?? throw new Exception("Não foi possível encontrar o produto informado");

        ObjectExtensions<Produto, Produto>.Copy(produtoParaAtualizar, produtoCadastrado);

        _produtoRepository.Atualizar(produtoCadastrado);
        _produtoRepository.Salvar();
    }
}