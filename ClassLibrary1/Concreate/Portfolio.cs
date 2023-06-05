using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
	public class Portfolio
	{
		[Key]
		public int Portfolioid { get; set; }
		public string Name { get; set; }
		public string ImgUrl { get; set; }
		public string ProjecUrl { get; set; }
		public string ImgUrl2 { get; set; }
		public string Platform { get; set; }
		public string Price { get; set; }
		public bool Status { get; set; }
		public String Img1 { get; set; }
		public String Img2 { get; set; }
		public String Img3 { get; set; }
		public String Img4 { get; set; }
		public int Values { get; set; }

    }
}
