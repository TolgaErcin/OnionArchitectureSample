using ANK_9.Core;

namespace ANK_9.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserTypes UserTypes { get; set; }

        public User()
        {
            IsActive = true;
        }
    }
}
