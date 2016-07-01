using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /Contacts/

        public ActionResult Contacts()
        {
            ViewBag.Count = 50;
            ViewBag.Sum = 5000;
            return View();
        }

    }
}
