
using ANK_9.Entities;
using System.ComponentModel.DataAnnotations;

namespace ANK_9.ViewModels.UserVMs
{
    public class UserCreateVM
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor")]
        public string PasswordCheck { get; set; }

        public UserTypes UserTypes => UserTypes.Standart;

        public DateTime CreateOn => DateTime.Now;
    }
}
