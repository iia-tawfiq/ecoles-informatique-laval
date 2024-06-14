using Microsoft.AspNetCore.Mvc;
using ecoles_informatiques.Data;
using ecoles_informatiques.Models;

    public class SchoolController : Controller
    {
    private readonly ApplicationDbContext _context;

    public SchoolController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
        [Route("/ecoles")]
        {


        }
        
        return View(new SchoolEnumerationViewModel(filteredSchools));
    }
}
