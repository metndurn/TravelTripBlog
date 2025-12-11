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
		BlogYorumlari blogyorum = new BlogYorumlari();
		public ActionResult BlogDetay(int id)
		{
			//var value = blog.Bloglars.Where(x => x.BlogId == id).ToList();
			blogyorum.Bloglar1 = blog.Bloglars.Where(x => x.BlogId == id).ToList();
			return View(blogyorum);
		}

	}
}