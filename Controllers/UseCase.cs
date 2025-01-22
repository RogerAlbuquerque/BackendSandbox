using DatabaseTest.Context;
using DatabaseTest.Models;
using DatabaseTest.Models.ProductSubEntitiesType;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DatabaseTest.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UseCase : ControllerBase
{
    // GET: api/<UseCase>
    [HttpGet]
    public IActionResult Get()
    {
        using var context = new AppDbContext();
        var produtos = context.Produtos.Include(p => p.ImagesPath).ToList();

        return Ok(produtos);
    }


    [HttpPost]
    public IActionResult Post()
    {
        using var context = new AppDbContext();

        var novoProduto = new Produto
        {
            ProdutoId = 2,
            Nome = "Moto",
            Cor = new List<string> { "Vermelho", "Verde", "Azul", "Amarelo" },
            ImagesPath = new ImagesPath
            {
                FeaturedImagePath = "/images/featured2.jpg",
                SecondaryImagesPath = new List<string>
                    {
                        "/images/secondary4.jpg",
                        "/images/secondary5.jpg"
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
