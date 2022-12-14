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

    [HttpGet, Route("listar-todos-produtos")]
    public object ListarProdutos()
    {
        try
        {
            var produtos = _produtoServices.ListarTodosProdutos();

            return new { sucesso = true, produtos };
        }
        catch (Exception ex)
        {
            return new { sucesso = false, mensagem = "Não foi possível listar os produtos pelo seguinte motivo: " + ex.Message };
        }
    }

    [HttpGet, Route("deletar-produto")]
    public object DeletarProuto(int id)
    {
        try
        {
            _produtoServices.RemoverProduto(id);

            return new { sucesso = true };
        }
        catch (Exception ex)
        {
            return new { sucesso = false, mensagem = "Não foi possível remover o produto pelo seguinte motivo: " + ex.Message };
        }
    }

    [HttpPost, Route("editar-produto")]
    public object EditarProduto(ProdutoTO produto)
    {
        try
        {
            if (!produto.IsValid())
                throw new Exception(string.Join(", ", produto.RetornarErros()));

            _produtoServices.AtualizarProduto(produto.ToProduto());
            
            return new { sucesso = true };
        }
        catch (Exception ex)
        {
            return new { sucesso = false, mensagem = "Não foi possível editar o produto pelo seguinte motivo: " + ex.Message };
        }
    }
}