using Microsoft.AspNetCore.Mvc;
using System;

namespace WordCounterProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
