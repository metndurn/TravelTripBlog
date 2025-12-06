using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripBlog.Models.Entities;

namespace TravelTripBlog.Controllers
{
    public class ContactController : Controller
    {
		// GET: Contact
		Context contact = new Context();
		public ActionResult Index()
        {
            var value = contact.Iletisims.ToList();
			return View(value);
        }
    }
}