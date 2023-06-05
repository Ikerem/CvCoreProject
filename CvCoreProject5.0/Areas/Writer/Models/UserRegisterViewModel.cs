using System.ComponentModel.DataAnnotations;

namespace CvCoreProject5._0.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen  adınızı giriniz")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı giriniz")]

        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen  Resim url değeri girin giriniz")]

        public string ImageUrl { get; set; }



        [Required(ErrorMessage = "Lütfen Kulanıcı adınızı giriniz")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi giriniz")]

        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Tekarar girin giriniz")]
        [Compare("Password", ErrorMessage = "Lütfen Şifrenizi Kontrol ediniz!")]

        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mailinizi giriniz")]

        public string Mail { get; set; }
    }
}
