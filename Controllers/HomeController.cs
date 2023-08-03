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
        ViewBag.ListadoPartidos= BD.ListarPartidos();
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
        ViewBag.Partido = BD.VerInfoPartido(idPartido);
        ViewBag.ListarCandidatos = BD.ListarCandidatos(idPartido);
        return View();
    }
    
    public IActionResult VerDetalleCandidato(int idCandidato)
    {
        ViewBag.C=BD.VerInfoCandidato(idCandidato);
        return View();
    }
    
    public IActionResult AgregarCandidato(int idPartido)
    {
        ViewBag.idPartido = idPartido;
        return View();
    }
    
     public IActionResult AgregarPartido(int idPartido)
    {
        ViewBag.idPartido = idPartido;
        return View();
    }

    [HttpPost]
    public IActionResult GuardarPartido(string Nombre, string Logo, string SitioWeb, DateTime FechaFundacion, int CantidadDiputados, int CantidadSenadores)
    {
        BD.AgregarPartido(new Partido (Nombre, Logo, SitioWeb, FechaFundacion, CantidadDiputados, CantidadSenadores));
        return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    public IActionResult GuardarCandidato(int idPartido, string Apellido, string Nombre, DateTime FechaNacimiento, string Foto, string Postulacion)
    {
        BD.AgregarCandidato(new Candidato (idPartido, Apellido, Nombre, FechaNacimiento, Foto, Postulacion));
        return RedirectToAction("Index", "Home");
    }

    public IActionResult EliminarCandidato(int idCandidato, int idPartido)
    {
        BD.EliminarCandidato(idCandidato);
        return RedirectToAction("VerDetallePartido", "Home",  new { idPartido = idPartido });
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
