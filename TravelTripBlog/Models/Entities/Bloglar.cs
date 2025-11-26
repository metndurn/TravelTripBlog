using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripBlog.Models.Entities
{
	public class Bloglar
	{
		[Key]
		public int BlogId { get; set; }
		public string Baslik { get; set; }
		public DateTime Tarih { get; set; }
		public string Aciklama { get; set; }
		public string BlogImage { get; set; }
		public ICollection<Yorumlar> Yorumlars { get; set; }//bir blogun birden fazla yorumu olabilir
	}
}