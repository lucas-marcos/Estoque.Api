using Estoque.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Api.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Produto> Produto { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
          
        foreach (var property in builder.Model.GetEntityTypes()
                     .SelectMany(t => t.GetProperties())
                     .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
        {
            property.SetColumnType("decimal(18, 6)");
        }
    }
}
