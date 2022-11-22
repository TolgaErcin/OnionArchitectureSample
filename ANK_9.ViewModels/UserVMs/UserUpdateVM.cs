
using System.ComponentModel.DataAnnotations;

namespace ANK_9.ViewModels.UserVMs
{
    public class UserUpdateVM
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor")]
        public string PasswordCheck { get; set; }

        public DateTime UpdateOn => DateTime.Now;
    }
}
