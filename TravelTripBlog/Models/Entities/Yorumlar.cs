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
		public int BlogsId { get; set; }/*blogıd'yi ekledik cünkü yeni yorum yapıldıgı vakıt bos blog olusturup sadece yorum yapmanısını engelledık*/
		public virtual Bloglar Bloglar { get; set; }//bir yorum bir bloga aittir virtual ekledık çünkü sadece o an ihtıyac duyuldugunda blogları getırırız
	}
}