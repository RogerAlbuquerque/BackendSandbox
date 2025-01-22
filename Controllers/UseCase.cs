using DatabaseTest.Context;
using DatabaseTest.Models;
using DatabaseTest.Models.ProductSubEntitiesType;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTest.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UseCase(AppDbContext _context) : ControllerBase
{
    private readonly AppDbContext context = _context;

    // GET: api/<UseCase>
    [HttpGet]
    public IActionResult Get()
    {
        
        var produtos = context.Produtos.Include(p => p.ImagesPath).ToList();

        return Ok(produtos);
    }


    [HttpPost]
    public IActionResult Post()
    {


        var novoProduto = new Produto
        {
            ProdutoId = 10,
            Nome = "Avião",
            Cor = new List<string> { "Laranja", "Rosa", "Preto", "Lilaz" },
            ImagesPath = new ImagesPath
            {
                FeaturedImagePath = "/images/featured3.jpg",
                SecondaryImagesPath = new List<string>
                    {
                        "/images/secondary6.jpg",
                        "/images/secondary7.jpg"
                    }
            }

        };

        context.Produtos.Add(novoProduto);
        context.SaveChanges();

        Console.WriteLine("Produto e imagens inseridos com sucesso!");

        return Ok();

        //var dbContext = new PlannerDbContext();

        //var entity = new Trip
        //{
        //    Name = request.Name,
        //    StartDate = request.StartDate,
        //    EndDate = request.EndDate,
        //};

        //dbContext.Trips.Add(entity);

        //dbContext.SaveChanges();

        //return new ResponseShortTripJson
        //{
        //    EndDate = entity.EndDate,
        //    StartDate = entity.StartDate,
        //    Name = entity.Name,
        //    Id = entity.Id

        //};
    }

}
