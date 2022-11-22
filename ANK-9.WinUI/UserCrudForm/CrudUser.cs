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

namespace ANK_9.WinUI.UserCrudForm
{
    public partial class CrudUser : Form
    {
        private readonly IUserBLL _userBLL;

        public CrudUser(IUserBLL userBLL)
        {
            InitializeComponent();
            _userBLL = userBLL;
        }


        private void buttonget_Click(object sender, EventArgs e)
        {
            ResultService<User> resultService = _userBLL.GetUserByUserName(checkuser.Text);
            if (resultService.Data != null)
            {
                txtUserName.Text = resultService.Data.UserName;
                txtEmail.Text = resultService.Data.Email;
                txtPassword.Text = resultService.Data.Password;
            }
            else
            {
                string error = resultService.Errors.ToList()[0].ErrorMessage + resultService.Errors.ToList()[0].ErrorType;

                MessageBox.Show(error, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            ResultService<User> resultService = _userBLL.GetUserByUserName(checkuser.Text);
            if (resultService.Data != null)
            {UserUpdateVM updateVM= new UserUpdateVM();
                updateVM.UserName = txtUserName.Text ;
                updateVM.Email = txtEmail.Text ;
                updateVM.Password= txtPassword.Text;
                updateVM.ID = resultService.Data.ID;
                _userBLL.UpdateUser(updateVM);
                MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string error = resultService.Errors.ToList()[0].ErrorMessage + resultService.Errors.ToList()[0].ErrorType;

                MessageBox.Show(error, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttoncreate_Click(object sender, EventArgs e)
        {
            UserCreateVM newuser = new UserCreateVM()
            {
                UserName = txtUserName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,


            };

            ResultService<User> resultService = _userBLL.CreateUser(newuser);
            GetResult(resultService);
        }
        private void GetResult(ResultService<User> resultService)
        {
            if (resultService.Data == null)
            {
                string error = resultService.Errors.ToList()[0].ErrorMessage + resultService.Errors.ToList()[0].ErrorType;

                MessageBox.Show(error, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ResultService<User> resultService = _userBLL.GetUserByUserName(checkuser.Text);
            if (resultService.Data != null)
            {
                UserBaseVM userBaseVM = new UserBaseVM()
                {
                    ID = resultService.Data.ID
                };
                _userBLL.DeleteUser(userBaseVM);
                MessageBox.Show("Silme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string error = resultService.Errors.ToList()[0].ErrorMessage + resultService.Errors.ToList()[0].ErrorType;

                MessageBox.Show(error, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
