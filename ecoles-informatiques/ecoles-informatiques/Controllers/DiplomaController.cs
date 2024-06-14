using ecoles_informatiques.Data;
using ecoles_informatiques.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ecoles_informatiques.Controllers
{
    public class DiplomaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DiplomaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Diploma()
        {
            DiplomaViewModel model = new DiplomaViewModel(_context.Diplomas.ToList());
            return View(model);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
