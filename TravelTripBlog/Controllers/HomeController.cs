using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripBlog.Models.Entities;

namespace TravelTripBlog.Controllers
{
    public class HomeController : Controller
    {
		// GET: Home
		Context blog = new Context();
		public ActionResult Index()
        {
            var bloglar = blog.Bloglars.ToList();
			return View(bloglar);
        }
    }
}