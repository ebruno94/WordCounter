using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordCounterProject.Models;

namespace WordCounterProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            RepeatCounter.ClearAll();
            return View("Form");
        }
    }
}
