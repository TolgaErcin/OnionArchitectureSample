using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.UserVMs;

namespace ANK_9.BLL.Abstract
{
    public interface IUserBLL : IBaseBLL<User>
    {
        ResultService<User> Login(LoginVM vm);
        ResultService<User> CreateUser(UserCreateVM vm);
        public bool AnyUser(UserCreateVM vm);
        bool IsValidEmail(string email);
        ResultService<User> GetUserByUserName(string name);
        ResultService<UserUpdateVM> UpdateUser(UserUpdateVM vm);
        ResultService<UserBaseVM> DeleteUser(UserBaseVM vm);
    }
}
