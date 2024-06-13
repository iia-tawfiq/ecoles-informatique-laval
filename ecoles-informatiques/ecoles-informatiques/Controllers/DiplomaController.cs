using ecoles_informatiques.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ecoles_informatiques.Controllers
{
    public class DiplomaController : Controller
    {
        public IActionResult Diploma()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
