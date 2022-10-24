using Estoque.Api.Data;
using Estoque.Api.Model;
using Estoque.Api.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Api.Repositories;

public class ProdutoRepository :Repository<Produto>, IProdutoRepository
{
    public ProdutoRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
     
    }

    public void CadastrarProduto(Produto produto)
    {
        Adicionar(produto);
        Salvar();
    }
}