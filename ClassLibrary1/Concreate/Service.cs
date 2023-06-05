using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
	public class Service
	{
		[Key]
		public int Serviceid { get; set; }
		public string Title { get; set; }
		public string ImgUrl { get; set; }
    }
}
