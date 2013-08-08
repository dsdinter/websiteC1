using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3Sample.Models;

namespace MVC3Sample.Controllers
{
    public class MVC3SampleController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "Hello World";
            return View();
        }
    }
}
