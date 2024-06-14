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

        public IActionResult Index()
        {
            DiplomasViewModel model = new DiplomasViewModel(_context.Diplomas.ToList());
            return View(model);
        }
        public IActionResult Diploma(int id)
        {
            Diploma diploma = _context.Diplomas.Find(id);
            List<Formation> formations = _context.Formations.Where(f => f.DiplomaId == id).ToList();
            DiplomaViewModel model = new DiplomaViewModel(formations, diploma);
            return View(model);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
