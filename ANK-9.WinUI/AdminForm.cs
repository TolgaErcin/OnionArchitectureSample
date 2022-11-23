
using ANK_9.BLL.Abstract;
using ANK_9.WinUI.EFContextInjection;
using ANK_9.WinUI.UserCrudForm;
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
    public partial class AdminForm : Form
    {
        private readonly IUserBLL _userBLL;
        //private readonly ICategoryBLL _categoryBLL;

        
        public AdminForm(IUserBLL userBLL/*,ICategoryBLL categoryBLL*/)
        {
            InitializeComponent();

            _userBLL = userBLL;
            //_categoryBLL = categoryBLL;
        }
       
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CrudUser _form = new CrudUser(_userBLL);
            Form _form = default;
            _form = EFContextForm.ConfigureServices<CrudUser>();
            _form.MdiParent = this;
            _form.Dock = DockStyle.Fill;
            _form.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CategoryList form=new CategoryList(_categoryBLL);
            Form form = default;
            form = EFContextForm.ConfigureServices<CategoryList>();

            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void mealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = default;
            form = EFContextForm.ConfigureServices<MealList>();

            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
