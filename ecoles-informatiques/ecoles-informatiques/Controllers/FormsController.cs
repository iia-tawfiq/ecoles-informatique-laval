using ecoles_informatiques.Data;
using ecoles_informatiques.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecoles_informatiques.Controllers
{
	public class FormsController : Controller
	{
		private readonly ApplicationDbContext _context;
        public FormsController(ApplicationDbContext context)
        {
			this._context = context;
        }

		public IActionResult Index()
		{
			DbSet<GradeLevel> gradeLevels = _context.GradeLevels;

			return View(gradeLevels);
		}

        public IActionResult Update()
		{
			GradeLevel g = _context.GradeLevels.Find(1);
			GradeLevelViewModel model = new GradeLevelViewModel();
			model.Id = g.Id;
			model.ShortLabel = g.ShortLabel;
			model.LongLabel = g.LongLabel;

			return View("CreateOrUpdate", model);
		}

		[HttpPost("Forms/Update")]
		public IActionResult Update(GradeLevelViewModel model)
		{


			if(ModelState.IsValid)
			{
				GradeLevel? gradeLevel = new GradeLevel();
				
				gradeLevel.ShortLabel = model.ShortLabel;
				gradeLevel.LongLabel = model.LongLabel;
				
				_context.GradeLevels.Add(gradeLevel);
				_context.SaveChanges();
				return RedirectToAction("Update");
			}	
		
			return View("CreateOrUpdate", model);

		}


		public IActionResult Create()
		{
			GradeLevelViewModel model = new GradeLevelViewModel();
			return View("CreateOrUpdate", model);
		}

		[HttpPost("Forms/Create")]
		public IActionResult Create(GradeLevelViewModel model)
		{


			if (ModelState.IsValid)
			{
				GradeLevel? gradeLevel = _context.GradeLevels.Find(model.Id);
				gradeLevel.ShortLabel = model.ShortLabel;
				gradeLevel.LongLabel = model.LongLabel;

				_context.SaveChanges();
				return RedirectToAction("Create");
			}

			return View("CreateOrUpdate", model);

		}

		public IActionResult Delete(int id)
		{
			GradeLevelViewModel model = new GradeLevelViewModel();
			GradeLevel gradeLevel = _context.GradeLevels.Find(id);
			model.Id = gradeLevel.Id;
			model.ShortLabel = gradeLevel.ShortLabel;
			model.LongLabel = gradeLevel.LongLabel;

			return View(model);

		}

		[HttpPost("Forms/Delete")]
		public IActionResult Delete(GradeLevelViewModel model)
		{

			GradeLevel gradeLevel = _context.GradeLevels.Find(model.Id);
			_context.GradeLevels.Remove(gradeLevel);
			try
			{
				_context.SaveChanges();
			}
			catch (Exception)
			{

				model.Message = "Suppression impossible";
				return View(model);
			}
			
			return RedirectToAction("Index");

		}
	}
}
