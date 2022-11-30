using ANK_9.BLL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
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

namespace ANK_9.WinUI
{
    public partial class Register : Form
    {
        private readonly IUserBLL userBLL;
        private static ResultService<User> _result;

        public Register(IUserBLL userBLL)
        {
            InitializeComponent();
            this.userBLL = userBLL;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string userName = txt_userName.Text;
            string email=txt_eMail.Text;
            string password = txt_password.Text;
            string repeatPassword = txt_repPaswd.Text;

            if (password!=repeatPassword)
            {
                return;
            }
            UserCreateVM createVM=new UserCreateVM()
            {
                UserName = userName,
                Email = email,
                Password = password,
                PasswordCheck=repeatPassword
            };
            _result = userBLL.CreateUser(createVM);

            if (_result.HasError)
            {
                string errorMessage = _result.Errors.First().ErrorMessage;
                string errorType = _result.Errors.First().ErrorType;
                MessageBox.Show(errorMessage,errorType,MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return;
            }
            this.Close();
        }
    }
}
