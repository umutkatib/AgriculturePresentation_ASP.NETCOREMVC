using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını girin")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi girin")]
        public string password { get; set; }
    }
}
