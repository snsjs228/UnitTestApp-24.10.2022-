﻿using Microsoft.AspNetCore.Mvc;
using UnitTestApp.Models;

namespace UnitTestApp.Controllers 
{
    public class HomeController : Controller
    {
        IRepository repo;
        public HomeController(IRepository r)
        {
            repo = r;
        }
        public IActionResult Index()
        {
            return View(repo.GetAll());
        }
    }
}
