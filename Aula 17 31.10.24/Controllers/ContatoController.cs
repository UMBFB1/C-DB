using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aula_17_31._10._24.Models;

namespace Aula_17_31._10._24.Controllers;

public class ContatoController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ContatoController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
       public IActionResult Criar()
    {
        return View();
    }
       public IActionResult Editar()
    {
        return View();
    }
       public IActionResult VerificarDeletar()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
