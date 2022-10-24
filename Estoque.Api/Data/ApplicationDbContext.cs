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
        optionsBuilder.UseSqlServer("Password=unigoias123456!@#$%;Persist Security Info=True;User ID=lucas.marcos;Initial Catalog=EstoqueApp;Data Source=lucasmarcos.database.windows.net; TrustServerCertificate=True");
    }
}
