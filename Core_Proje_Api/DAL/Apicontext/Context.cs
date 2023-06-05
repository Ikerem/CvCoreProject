using Core_Proje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje_Api.DAL.Apicontext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=KEREMGENCPC\\SQLEXPRESS;database=CoreProje5.0Db2  ;integrated security=true");

        }
        public DbSet<Categoriy> Categoriys { get; set; }
    }
}
