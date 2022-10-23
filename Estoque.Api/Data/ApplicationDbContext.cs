using Estoque.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Api.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Produto> Produto { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
        
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Password=123456;Persist Security Info=True;User ID=sa;Initial Catalog=EstoqueApp;Data Source=DESKTOP-03NM2TV; TrustServerCertificate=True");
    }
}
