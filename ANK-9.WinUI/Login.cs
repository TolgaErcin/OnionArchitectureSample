using ANK_9.BLL.Abstract;
using ANK_9.Sysstem;
using ANK_9.Entities;
using ANK_9.ViewModels.UserVMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANK_9.WinUI.EFContextInjection;

namespace ANK_9.WinUI
{
    public partial class Login : Form
    {
        private readonly IUserBLL _userBLL;
        private readonly ICategoryBLL _categoryBLL;

        public Login(IUserBLL userBLL, ICategoryBLL categoryBLL)
        {
            InitializeComponent();
            _userBLL = userBLL;
            _categoryBLL = categoryBLL; 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            LoginVM login = new LoginVM
            {
                UserName = userName,
                Password = password,
            };

            ResultService<User> user =_userBLL.Login(login);

            GetUserTypes(user);

        }
        private void GetUserTypes(ResultService<User> user)
        {
            if (user.Data == null)
            {
                string error = user.Errors.ToList()[0].ErrorMessage + user.Errors.ToList()[0].ErrorType;

                MessageBox.Show(error, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form frm = default;

            if (user.Data.UserTypes == UserTypes.Admin)
            {
                //frm = new AdminForm(_userBLL, _categoryBLL);
                frm = EFContextForm.ConfigureServices<AdminForm>();
            }
            else
            {
                //frm = new UserForm();
                frm = EFContextForm.ConfigureServices<UserForm>();
            }
            frm.ShowDialog();
            this.Close();
        }

    }
}
