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
    }
}
