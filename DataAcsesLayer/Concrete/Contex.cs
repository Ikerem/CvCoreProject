using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesLayer.Concrete
{
	public class Contex : IdentityDbContext<WriteUser,WriteRole,int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=KEREMGENCPC\\SQLEXPRESS;database=CoreProje5.0  ;integrated security=true");

		}
		public DbSet<About> Abouts { get; set; }
		public DbSet<Contect> Contects { get; set; }
		public DbSet<Experince> Experinces { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Portfolio> Portfolios { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Skill> Skills { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
	
		public DbSet<ToDoList> ToDoLists { get; set; }
		public DbSet<test1> Test1s { get; set; }
		public DbSet<Announcement> Announcements { get; set; }
		public DbSet<WriterMessage> WriterMessages { get; set; }


	}
}
