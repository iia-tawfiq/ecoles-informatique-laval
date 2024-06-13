using Microsoft.AspNetCore.Mvc;
using ecoles_informatiques.Data;
using ecoles_informatiques.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace ecoles_informatiques.Controllers
{
    public class SchoolController : Controller
    {
        [Route("/ecoles")]
        public IActionResult Index(int SchoolId = 1)
        {
            ApplicationDbContext model = new ApplicationDbContext();
            School school = model.Schools.Find(SchoolId);

            ViewData[nameof(SchoolId)] = SchoolId;

            return View(model);
        }
    }
}
