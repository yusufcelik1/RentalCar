﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
