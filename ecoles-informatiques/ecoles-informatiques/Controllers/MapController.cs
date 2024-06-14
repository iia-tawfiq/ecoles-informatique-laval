using ecoles_informatiques.Data;
using ecoles_informatiques.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ecoles_informatiques.Controllers;

public class MapController : Controller
{
    private readonly ApplicationDbContext _context;

    public MapController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("/carte")]
    public IActionResult Index()
    {
        return View(new AdminSchoolEnumerationViewModel(_context.Schools.ToList()));
    }
}