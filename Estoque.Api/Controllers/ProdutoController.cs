using Estoque.Api.Model;
using Estoque.Api.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Estoque.Api.Controllers;

[ApiController, Route("produto")]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoController(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    [HttpGet, Route("criar-produto")]
    public void CriarProduto(string a)
    {
        var produto = new Produto() { Nome = "Produto teste 1", Marca = "Marca teste 1" };
        
        _produtoRepository.Criar(produto);
    }
}