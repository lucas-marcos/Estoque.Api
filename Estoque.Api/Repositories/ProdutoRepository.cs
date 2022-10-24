using Estoque.Api.Data;
using Estoque.Api.Model;
using Estoque.Api.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Api.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private ApplicationDbContext Db;
    private readonly DbSet<Produto> DbSet;
    
    public ProdutoRepository(ApplicationDbContext dbContext)
    {
        Db = dbContext;
        DbSet = Db.Set<Produto>();
    }

    public void CadastrarProduto(Produto produto)
    {
        DbSet.Add(produto);
        Db.SaveChanges();
    }
}