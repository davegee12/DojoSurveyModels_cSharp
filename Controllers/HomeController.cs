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
            if(ModelState.IsValid)
            {
                return View("Success", person);
            }
            else
            {
                return View("Index");
            }
        }
        // [HttpGet("result")]
        // public ViewResult Success()
        // {
        //     return View();
        // }
    }
}
