using Estoque.Api.Framework;
using Estoque.Api.Model;
using Estoque.Api.Model.TO;
using Estoque.Api.Repositories.Interface;
using Estoque.Api.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Estoque.Api.Controllers;

[ApiController, Route("produto")]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoServices _produtoServices;

    public ProdutoController(IProdutoServices produtoServices)
    {
        _produtoServices = produtoServices;
    }

    [HttpPost, Route("criar-produto")]
    public object CriarProduto(ProdutoTO produto)
    {
        try
        {
            if (!produto.IsValid())
                throw new Exception(string.Join(", ", produto.RetornarErros()));

            _produtoServices.CadastrarProduto(produto.ToProduto());

            return new { sucesso = true };
        }
        catch (Exception ex)
        {
            return new
            {
                sucesso = false, mensagem = "Não foi possível salvar o produto pelo seguinte motivo: " + ex.Message
            };
        }
    }
}