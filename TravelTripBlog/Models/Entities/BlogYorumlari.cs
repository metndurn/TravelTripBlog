using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripBlog.Models.Entities
{
	public class BlogYorumlari
	{
		/*burada hangi tabloda islem yapılacaksa ve hangi tablodan verıler cekılecekse dıye yazılır
		 ayrıca bir ıenumarable yazılır yanı ınterface formatında olmalı 
		ıenumarable ise belli degerleri belli bir sayıda tutmaya yarayan bir koleksiyon diyebiliriz*/
		public IEnumerable<Bloglar> Bloglar1 { get; set; }
		public IEnumerable<Yorumlar> Yorumlar1 { get; set; }
		public IEnumerable<Yorumlar> Yorumlar2 { get; set; }
		public IEnumerable<Bloglar> Bloglar2 { get; set; }//anasayfada 3 blog gosterme seklıdır onun ıcın bu yazıldı
	}
}