using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripBlog.Controllers
{
    public class AboutController : Controller
    {
        // GET: Hakkımızda
        public ActionResult Index()
        {
            return View();
        }
    }
}