using ecoles_informatiques.Data;
using ecoles_informatiques.Models;
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

        [HttpGet]
        [Route ("/Formation/{Id}") ]
        public IActionResult Index(int Id)
        {
            Formation formation = _context.Formations.Find(Id);
            School scholl = _context.Schools.Find(formation.SchoolId);
            return View(formation);
        }
    }
}
