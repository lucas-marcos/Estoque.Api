using Estoque.Api.Data;
using Estoque.Api.Model;
using Estoque.Api.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Api.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    protected ApplicationDbContext Db;
    protected readonly DbSet<Produto> DbSet;
    
    public ProdutoRepository(ApplicationDbContext dbContext)
    {
        Db = dbContext;
        DbSet = Db.Set<Produto>();
    }

    public void Criar(Produto produto)
    {
        DbSet.Add(produto);
        Db.SaveChanges();
    }
}