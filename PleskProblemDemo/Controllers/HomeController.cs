using PleskProblemDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PleskProblemDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            var list = new List<TestViewModel>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(new TestViewModel() { Text = $"Sample Text {i}" });
            }

            return View(list);
        }
    }
}