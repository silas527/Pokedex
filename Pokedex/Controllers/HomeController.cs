using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;

namespace Pokedex.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db;

    public HomeController(ILogger<HomeController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        var pokemons -_db.pokemons
        .include(p => p.Tipos)
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Details(int id)
    {
        var pokemon = _db.Pokemons
            .Where(p => p.Numero == id)
            .Include(p => p.Genero)
            .Include(p => p.Regiao)
            .Include(p => p.Tipos)
            .ThenInclude(p => p.Tipos)
            SingleOrDefault();
        return View(pokemon)
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
