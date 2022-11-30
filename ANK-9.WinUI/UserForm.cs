using ANK_9.WinUI.EFContextInjection;
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
    public partial class UserForm : Form
    {
        public static int _id;
        public UserForm()
        {
            InitializeComponent();
        }
        private void ToolStriptMenuItemClick(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string tag = item.Tag.ToString();

            Form frm = default;

            switch (tag)
            {
                case "0":
                    frm = OpenUserUpdate();
                    break;
                case "1":
                    frm = CreateEatMeal();
                    break;
            }
            if (frm!=null)
            {
                frm.MdiParent = this;
                frm.Dock= DockStyle.Fill;
                frm.Show();
            }
        }

        private UserUpdate OpenUserUpdate()
        {
            return (UserUpdate)EFContextForm.ConfigureServices<UserUpdate>();
        }
        private CreateMeal CreateEatMeal()
        {
            return (CreateMeal)EFContextForm.ConfigureServices<CreateMeal>();
        }

    }
}
