using DatabaseTest.Models;
using DatabaseTest.Models.ProductSubEntitiesType;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTest.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ImagesPath> ImagesPath { get; set; }

}
