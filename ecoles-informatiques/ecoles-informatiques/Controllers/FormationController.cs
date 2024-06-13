using Microsoft.AspNetCore.Mvc;

namespace ecoles_informatiques.Controllers
{
    public class FormationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
