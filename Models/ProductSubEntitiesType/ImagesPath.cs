namespace DatabaseTest.Models.ProductSubEntitiesType;

public sealed class ImagesPath
{
    public int ImagesPathId { get; set; }
    public string FeaturedImagePath { get; set; } = string.Empty;
    public IList<string>? SecondaryImagesPath { get; set; }

    public int ProductoId { get;  set; }
    public Produto? FK_Produto { get;  set; }
}



