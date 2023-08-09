using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kullanıcı Adını Giriniz")]
        public string Username { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Şifreyi Giriniz")]
        public string Password { get; set; }
    }
}
