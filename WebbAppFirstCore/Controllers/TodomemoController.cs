using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebbAppFirstCore.Controllers
{
    public class TodomemoController : Controller
    {
        public IActionResult Index()
        {
            string toDo= "";
            int? prio = 0;

            toDo = HttpContext.Session.GetString("_ToDo");
            prio = HttpContext.Session.GetInt32("_Prio");

            ViewBag.ToDo = toDo;
            ViewBag.Prio = prio;
             

            return View();
        }

        public IActionResult MakeTodo()
        {
            return View("SetToDo");//Defualt name of method is name of file to use.
        }
        [HttpPost]
        public IActionResult MakeToDo(string toDo, int prio)
        {
            HttpContext.Session.SetString("_ToDo", toDo);
            HttpContext.Session.SetInt32("_Prio", prio);
            return RedirectToAction("index","ToDoMemo");
        }
    }
}