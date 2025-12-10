using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripBlog.Models.Entities;

namespace TravelTripBlog.Controllers
{
    public class BlogController : Controller
    {
		// GET: Blog
		Context blog = new Context();
		public ActionResult Index()
        {
            var value = blog.Bloglars.ToList();
			return View(value);
        }
    }
}