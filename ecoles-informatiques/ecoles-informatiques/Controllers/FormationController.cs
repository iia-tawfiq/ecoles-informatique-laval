using ecoles_informatiques.Data;
using ecoles_informatiques.Models;
using ecoles_informatiques.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        [Route ("/formation/{Id}") ]
        public IActionResult Index(int Id)
        {
            Formation formation = _context.Formations.Find(Id);
            School school = _context.Schools.Find(formation.SchoolId);
            FormationViewModel model = new FormationViewModel(formation, school);
            
            return View("~/Views/Formation/Index.cshtml", model);
        }

    }
}
