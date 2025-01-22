using DatabaseTest.Models.ProductSubEntitiesType;

namespace DatabaseTest.Models;

public class Produto
{
    public int ProdutoId { get; set; }
    public string? Nome { get; set; }

    public IList<string>? Cor { get; set; }
    public ImagesPath ImagesPath { get; set; }
}