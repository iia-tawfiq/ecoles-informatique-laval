using Microsoft.AspNetCore.Mvc;
using ecoles_informatiques.Data;
using ecoles_informatiques.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore;

namespace ecoles_informatiques.Controllers;

public class SchoolController : Controller
{
    private ApplicationDbContext _context;

    public SchoolController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("/ecole/{schoolId}")]
    public IActionResult School(int schoolId)
    {
        School school = _context.Schools.Find(schoolId);

        return View(school);
    }
}