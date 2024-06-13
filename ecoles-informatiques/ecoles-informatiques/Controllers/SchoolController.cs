using ecoles_informatiques.Data;
using ecoles_informatiques.Models;
using ecoles_informatiques.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

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
    public IActionResult Index(string? search)
    {
        List<School> schools = _context.Schools.ToList();

        search = Strings.Trim(search).ToLower();
        List<School> filteredSchools;

        if (!string.IsNullOrEmpty(search))
        {
            filteredSchools = schools.Where(s => s.Name.ToLower().Contains(search)).ToList();
        }
        else
        {
            filteredSchools = schools;
        }
        
        return View(new SchoolEnumerationViewModel(filteredSchools));
    }
}