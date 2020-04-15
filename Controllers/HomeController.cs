using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
         public static List<string> SurveyInfo = new List<string>(){

         };

        [HttpGet("")]
        public IActionResult Index()
        {
           
            return View("Index");
        }
        [HttpPost("survey")]
        public IActionResult Submission(Survey survey)
        {
            Survey incoming = new Survey(){
                Name = survey.Name,
                Location = survey.Location,
                Language = survey.Language,
                Comment = survey.Comment
            };
            Console.WriteLine("Completed Creating survey model");
            return View("result", incoming);
        }

        [HttpGet("result")]
        public IActionResult Result(Survey incoming)
        {
            Console.WriteLine(incoming.Name);
            return View("result", incoming);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
