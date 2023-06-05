using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
	public class SocialMedia
	{
		[Key]
		public int SocialMediaid { get; set; }
		public string Name { get; set; }
		public string Url { get; set; }
		public string Icone { get; set; }
		public bool Status { get; set; }

    }
}
