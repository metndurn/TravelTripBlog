using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripBlog.Models.Entities
{
	public class Hakkimizda
	{
		[Key]
		public int HakkimizdaId { get; set; }
		public string ResimUrl { get; set; }
		public string Aciklama { get; set; }
	}
}