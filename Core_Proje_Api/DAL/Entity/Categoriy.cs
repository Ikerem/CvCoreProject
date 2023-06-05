using System.ComponentModel.DataAnnotations;

namespace Core_Proje_Api.DAL.Entity
{
    public class Categoriy
    {
        [Key]
        public int Categoiryid { get; set; }
        public string CategoriyName { get; set; }
    }
}
