using ControleDeRegistros.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControleDeRegistros.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }


        public IActionResult CriarNovaMatricula()
        {
            return View();
        }

        public IActionResult EditarUmaMatricula (int id)
        {
            return View();
        }

        public IActionResult ApagarUmaMatricula (int id)
        {
            return View();
        }


    }
}
