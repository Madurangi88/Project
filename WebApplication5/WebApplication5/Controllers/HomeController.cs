using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Account
        public ActionResult About()
        {
            return View();
        }

        // GET: Account
        public ActionResult Contact()
        {
            return View();
        }
    }
}