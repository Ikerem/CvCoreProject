using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace CvCoreProject5._0.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name = "Kullanıcı adi")]
        [Required(ErrorMessage = "Kullanıcı adı Giriniz..")]
        public string UserName { get; set; }
        [Display(Name = "Şifre ")]
        [Required(ErrorMessage = "Şifreyi Giriniz Giriniz..")]
        public string Password { get; set; }
    }
}
