using ControleDeRegistros.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace ControleDeRegistros.Controllers
{
    public class InformacoesController : Controller
    {
        public IActionResult Informacoes()
        {
            return View();
        }
    }
}
