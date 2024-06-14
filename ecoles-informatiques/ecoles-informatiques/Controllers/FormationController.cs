using ecoles_informatiques.Data;
using Microsoft.AspNetCore.Mvc;

namespace ecoles_informatiques.Controllers
{
    public class FormationController : Controller
    {
        private ApplicationDbContext _context;


        public FormationController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string Name)
        {

            return View();
        }
    }
}
