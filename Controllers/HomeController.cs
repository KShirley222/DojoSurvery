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

        [HttpPost("Result")]
        public IActionResult Result(string name, string language, string location, string comment)
        {

            ViewBag.SurveyInfo = SurveyInfo;
            SurveyInfo.Add(name);
            SurveyInfo.Add(language);
            SurveyInfo.Add(location);
            SurveyInfo.Add(comment);
            return View("Result");
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
