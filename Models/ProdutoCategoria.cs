namespace DatabaseTest.Models;

public class ProdutoCategoria
{
    public int CategoriaId { get; set; }
    public Produto? Produto { get; set; }
    public string? ProdutoId { get; set; }
    public Categoria? Categoria { get; set; }
}
