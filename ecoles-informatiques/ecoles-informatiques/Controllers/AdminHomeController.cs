﻿using Microsoft.AspNetCore.Mvc;

namespace ecoles_informatiques.Controllers
{
    public class AdminHomeController : Controller
    {
        [Route("/admin/accueil")]
        public IActionResult AdminHome()
        {
            return View();
        }
    }
}
