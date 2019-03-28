using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.blanco.Models;

namespace Test.blanco.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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

        public IActionResult Html()
        {
            //<b>test</b>
            //    <h1>Naam in of dergelijke</h1>
            //    <ul>
            //    <li>kleur 1</li>
            //    <li>kleur 2</li>
            //    </ul>
            string[] lusvoorbeeld = new string[] { "kleur 1", "kleur 2" };
            var naam1 = "test";
            var naam2 = "Naam in of dergelijke";


            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"<b>{naam1}</b>");
            stringBuilder.AppendLine($"<h1>{naam2}</h1>");
            stringBuilder.AppendLine("<ul>");
            for (var i = 0; i < lusvoorbeeld.Length; i++)
            {
                stringBuilder.AppendLine($"<li>{lusvoorbeeld[i]}</li>");
            }

            stringBuilder.AppendLine("</ul>");

            return Content(stringBuilder.ToString(), "text/html");
        }

    }
}
