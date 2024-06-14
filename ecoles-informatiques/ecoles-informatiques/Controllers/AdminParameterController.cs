using ecoles_informatiques.Data;
using ecoles_informatiques.Models;
using ecoles_informatiques.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ecoles_informatiques.Controllers;

public class AdminParameterController : Controller
{
    private readonly ApplicationDbContext _context;

    public AdminParameterController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("/admin/parametres")]
    public IActionResult Index()
    {
        AdminParameterEnumerationViewModel model = new AdminParameterEnumerationViewModel(_context.Parameters.ToList());

        return View("~/Views/Admin/Parameter/Index.cshtml", model);
    }

    [HttpGet]
    [Route("/admin/parametres/creer")]
    public IActionResult Create()
    {
        return View("~/Views/Admin/Parameter/Create.cshtml", new AdminParameterCreateViewModel(new Parameter()));
    }

    [HttpPost]
    [Route("/admin/parametres/creer")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Key, Value")] Parameter parameter)
    {
        // @fixme: vérification par ModelState.IsValid non fonctionnelle car pas de restrictions sur les attributs
        if (true)
        {
            await _context.AddAsync(parameter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        AdminParameterCreateViewModel model = new AdminParameterCreateViewModel(parameter);

        return View("~/Views/Admin/Parameter/Create.cshtml", model);
    }

    [HttpGet]
    [Route("/admin/parametres/editer/{id}")]
    public IActionResult Edit(int id)
    {
        Parameter parameter = _context.Parameters.First(p => p.Id == id);
        AdminParameterEditViewModel model = new AdminParameterEditViewModel(parameter);

        return View("~/Views/Admin/Parameter/Edit.cshtml", model);
    }

    [HttpPost]
    [Route("/admin/parametres/editer/{id}")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Key, Value")] Parameter parameter)
    {
        // @fixme: vérification par ModelState.IsValid non fonctionnelle car pas de restrictions sur les attributs
        if (true)
        {
            parameter.Id = id;
            _context.Update(parameter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        AdminParameterEditViewModel model = new AdminParameterEditViewModel(parameter);

        return View("~/Views/Admin/Parameter/Edit.cshtml", model);
    }

    [HttpGet]
    [Route("/admin/parametres/supprimer/{id}")]
    //[ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        Parameter? parameter = await _context.Parameters.FindAsync(id);
        if (null != parameter)
        {
            _context.Remove(parameter);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }
}