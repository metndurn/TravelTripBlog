using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TravelTripBlog.Models.Entities
{
	public class Context : DbContext
	{
		public DbSet<Admin> Admins { get; set; }
		public DbSet<AdresBlog> AdresBlogs { get; set; }
		public DbSet<Bloglar> Bloglars { get; set; }
		public DbSet<Hakkimizda> Hakkimizdas { get; set; }
		public DbSet<Iletisim> Iletisims { get; set; }
		public DbSet<Yorumlar> Yorumlars { get; set; }

	}
}