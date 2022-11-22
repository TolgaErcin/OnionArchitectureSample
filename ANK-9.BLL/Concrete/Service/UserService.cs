using ANK_9.BLL.Abstract;
using ANK_9.DAL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.UserVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ANK_9.BLL.Concrete.Service
{
    public class UserService : IUserBLL
    {
        private readonly IUserDAL userDAL;

        public UserService(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }

        public ResultService<User> CreateUser(UserCreateVM vm)
        {
            ResultService<User> result = new ResultService<User>();

            bool checkUser = AnyUser(vm);

            bool checkEmail=IsValidEmail(vm.Email);

            if (checkEmail)
            {
                if (!checkUser)
                {
                    User newUser = new User
                    {
                        UserName = vm.UserName,

                        Email = vm.Email,
                        Password = vm.Password,
                        UserTypes = vm.UserTypes,
                        CreateOn = vm.CreateOn,
                    };

                    User addUser = userDAL.Add(newUser);

                    result.Data = addUser ?? newUser;
                }
                else
                {
                    result.Data = null;
                    result.AddError("Ekleme başarısız", "Kayıt zaten var");

                }
            }
            else
            {
                result.Data = null;
                result.AddError("Ekleme başarısız", "Email Formatı uygun değil");
            }
            return result;
        }

        public ResultService<UserUpdateVM> UpdateUser(UserUpdateVM vm)
        {
            ResultService<UserUpdateVM> result = new ResultService<UserUpdateVM>();

            try
            {
                User user = userDAL.Get(x => x.ID.Equals(vm.ID) && x.IsActive == true);

                user.UserName = vm.UserName;
                user.Email = vm.Email;
                user.Password = vm.Password;
                user.UpdateOn = vm.UpdateOn;

                User updateUser = userDAL.Update(user);

                result.Data = null;
            }
            catch (Exception)
            {
                result.Data = vm;
                result.AddError("Güncelleme başarısız", "Kayıt bulunamadı");
            }

            return result;
        }

        public ResultService<UserBaseVM> DeleteUser(UserBaseVM vm)
        {
            ResultService<UserBaseVM> result = new ResultService<UserBaseVM>();

            try
            {
                User user = userDAL.Get(x => x.IsActive == true && x.ID.Equals(vm.ID));
                user.IsActive = false;
                userDAL.Delete(user);

                result.Data = null;
            }
            catch (Exception)
            {
                result.Data = vm;
                result.AddError("Silme işlemi başarısız", "Kayıt bulunamadı");
            }

            return result;
        }

        public ResultService<User> Login(LoginVM vm)
        {
            ResultService<User> result = new ResultService<User>();

            User user = userDAL
                .Get(x => x.UserName.Equals(vm.UserName) && x.Password.Equals(vm.Password));

            if (user != null)
            {
                result.Data = user;
            }
            else
            {
                result.Data = null;
                result.AddError("Giriş başarısız", "Kullanıcı bulunamadı");
            }

            return result;
        }

        public  bool AnyUser(UserCreateVM vm)
        {
            bool validUser = userDAL.GetAll(x=>x.IsActive).Any(x => x.Email == vm.Email && x.Password == vm.Password);
            return validUser;
        }

        public  bool IsValidEmail(string email)
        {
            string pattern = @"[\w+-]+(?:.[\w+-]+)@[\w+-]+(?:.[\w+-]+)(?:.[a-zA-Z]{2,4})";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

        public ResultService<User> GetUserByUserName(string name)
        {
            ResultService<User> result = new ResultService<User>();

            User user = userDAL
                .Get(x => x.UserName.Equals(name));

            if (user != null)
            {
                result.Data = user;
            }
            else
            {
                result.Data = null;
                result.AddError("Hata", "Kullanıcı bulunamadı");
            }

            return result;
        }
    }
}
