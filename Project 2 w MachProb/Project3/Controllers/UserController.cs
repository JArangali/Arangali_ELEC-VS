﻿using Microsoft.AspNetCore.Mvc;

namespace Project3.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employee()
        {
            return View();
        }

        public IActionResult MachineProblem()
        {
            return View();
        }
    }
}
