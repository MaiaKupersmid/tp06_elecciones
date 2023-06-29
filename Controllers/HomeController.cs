using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06_Elecciones.Models;

namespace TP06_Elecciones.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult VerDetallePartido(int idPartido)
    {
        return View();
    }
    public IActionResult VerDetalleCandidato(int idCandidato)
    {
        return View();
    }
    public IActionResult AgregarCandidato(int idPartido)
    {
        return View();
    }
    [HttpPost]
    public IActionResult GuardarCandidato(Candidato can)
    {
        return View();
    }
    public IActionResult EliminarCandidato(int idCandidato,int idPartido)
    {
        return View();
    }
    public IActionResult Elecciones()
    {
        return View();
    }
    public IActionResult Creditos()
    {
        return View();
    }
}
