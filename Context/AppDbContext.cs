using DatabaseTest.Models;
using DatabaseTest.Models.ProductSubEntitiesType;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTest.Context;

public class AppDbContext : DbContext
{

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ImagesPath> ImagesPath { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "Server=localhost;Port=3306;Database=ecommercesandbox;Uid=root;Pwd=admin;",
            new MySqlServerVersion(ServerVersion.AutoDetect("Server=localhost;Port=3306;Database=ecommercesandbox;Uid=root;Pwd=admin;")) // Substitua pela versão do seu MySQL
        );
    }
}
