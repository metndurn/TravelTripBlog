using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripBlog.Models.Entities
{
	public class Yorumlar
	{
		[Key]
		public int Id { get; set; }
		public string KullaniciAdi { get; set; }
		public string Mail { get; set; }
		public string Yorum { get; set; }
		public Bloglar Bloglar { get; set; }//bir yorum bir bloga aittir
	}
}