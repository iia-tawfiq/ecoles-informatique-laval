using ecoles_informatiques.Data;
using ecoles_informatiques.Models;
using ecoles_informatiques.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ecoles_informatiques.Controllers;

public class AdminSchoolController : Controller
{
    private readonly ApplicationDbContext _context;

    public AdminSchoolController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("/admin/ecoles")]
    public IActionResult Index()
    {
        AdminSchoolEnumerationViewModel model = new AdminSchoolEnumerationViewModel(_context.Schools.ToList());

        return View("~/Views/Admin/School/Index.cshtml", model);
    }

    [HttpGet]
    [Route("/admin/ecoles/creer")]
    public IActionResult Create()
    {
        return View("~/Views/Admin/School/Create.cshtml", new AdminSchoolCreateViewModel(new School()));
    }

    [HttpPost]
    [Route("/admin/ecoles/creer")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Name, Address, Description, City")] School school)
    {
        // @fixme: vérification par ModelState.IsValid non fonctionnelle car pas de restrictions sur les attributs
        if (true)
        {
            // @todo: gérer les slugs automatiquement, placeholder en attendant
            school.Slug = "temp";
            await _context.AddAsync(school);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        AdminSchoolCreateViewModel model = new AdminSchoolCreateViewModel(school);

        return View("~/Views/Admin/School/Create.cshtml", model);
    }

    [HttpGet]
    [Route("/admin/ecoles/editer/{id}")]
    public IActionResult Edit(int id)
    {
        School school = _context.Schools.First(s => s.Id == id);
        AdminSchoolEditViewModel model = new AdminSchoolEditViewModel(school);

        return View("~/Views/Admin/School/Edit.cshtml", model);
    }

    [HttpPost]
    [Route("/admin/ecoles/editer/{id}")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Name, Address, Description, City")] School school)
    {
        // @fixme: vérification par ModelState.IsValid non fonctionnelle car pas de restrictions sur les attributs
        if (true)
        {
            // @todo: gérer les slugs automatiquement, placeholder en attendant
            school.Id = id;
            school.Slug = "temp";
            _context.Update(school);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        AdminSchoolEditViewModel model = new AdminSchoolEditViewModel(school);

        return View("~/Views/Admin/School/Edit.cshtml", model);
    }

    [HttpGet]
    [Route("/admin/ecoles/supprimer/{id}")]
    //[ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        School? school = await _context.Schools.FindAsync(id);
        if (null != school)
        {
            _context.Remove(school);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }
}