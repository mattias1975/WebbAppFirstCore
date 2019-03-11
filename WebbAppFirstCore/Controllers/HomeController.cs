using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebbAppFirstCore.Modells;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebbAppFirstCore.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Core()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Swing()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Swing(String angle, string velocity)
        {
            double numAngle = 0;//gör en dubbel med namn numAnglesom jag ger startvärde 0
            double numVelocity = 0;//samma som ovsn fast num Velocity
            angle = angle.Replace('.',',');
            velocity = velocity.Replace('.', ',');
            Double.TryParse(angle, out numAngle);
            Double.TryParse(velocity, out numVelocity);

            /*double numAngle = Convert.ToDouble(angle);
            double numVelocity = Convert.ToDouble(velocity);*/
           ViewBag.Distance = Golf.Distance(numAngle, numVelocity);

            return View();
        }
    }
}
