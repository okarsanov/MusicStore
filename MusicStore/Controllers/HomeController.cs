using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Customer customer = new Customer();

            ViewBag.Count = 10;
            ViewBag.Sum = 1000;
            return View();
        }

        [HttpPost]
        public ActionResult SomeMethod1()
        {
            ViewBag.Count = 10;
            ViewBag.Sum = 1000;
            return View("SomeMethod");
        }
        [HttpGet]
        public ViewResult SomeMethod()
        {
            ViewBag.Count = 10;
            ViewBag.Sum = 1000;
            return View();
        }
    }
}
