using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyModel.Models;

namespace DojoSurveyModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult Submission(Survey person)
        {
            return View("Success", person);
        }
        // [HttpGet("result")]
        // public ViewResult Success()
        // {
        //     return View();
        // }
    }
}
