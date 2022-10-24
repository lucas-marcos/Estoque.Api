using Estoque.Api.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Api.Data;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected ApplicationDbContext Db;
    protected readonly DbSet<TEntity> DbSet;


    protected Repository(ApplicationDbContext context)
    {
        Db = context;
        DbSet = Db.Set<TEntity>();
    }

    public IQueryable<TEntity> BuscarTodos()
    {
        return DbSet;
    }

    public int Salvar()
    {
        return Db.SaveChanges();
    }

    public void Adicionar(TEntity obj)
    {
        if (obj == null)
            return;

        DbSet.Add(obj);
    }

    public void Atualizar(TEntity obj)
    {
        if (obj == null)
            return;

        DbSet.Update(obj);
    }
}