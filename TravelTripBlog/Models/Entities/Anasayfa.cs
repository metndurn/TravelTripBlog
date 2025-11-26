using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripBlog.Models.Entities
{
	public class Anasayfa //anasayfa tablosu
	{
		[Key]
		public int AnasayfaId { get; set; }
		public string Baslik { get; set; }
		public string Aciklama { get; set; }
	}
}