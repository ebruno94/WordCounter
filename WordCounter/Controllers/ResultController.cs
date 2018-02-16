using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordCounterProject.Models;

namespace WordCounterProject.Controllers
{
    public class ResultController : Controller
    {
        [HttpPost("/result")]
        public IActionResult Result()
        {
            RepeatCounter.SetDictionary(Request.Form["userInput"]);
            return View(RepeatCounter.GetDictionary());
        }
    }
}
