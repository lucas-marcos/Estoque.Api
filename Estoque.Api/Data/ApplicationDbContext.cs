using Estoque.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Api.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Produto> Produto { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
        
    }
}
