using ecoles_informatiques.Data;
using ecoles_informatiques.Models;
using ecoles_informatiques.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ecoles_informatiques.Controllers;

public class SchoolController : Controller
{
    private readonly ApplicationDbContext _context;

    public SchoolController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("/ecoles")]
    public IActionResult Index()
    {
        SchoolEnumerationViewModel model = new SchoolEnumerationViewModel(new List<School>());
        return View(model);
    }
}