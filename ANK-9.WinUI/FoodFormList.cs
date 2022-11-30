using ANK_9.BLL.Abstract;
using ANK_9.Sysstem;
using ANK_9.ViewModels.CategoryVMs;
using ANK_9.ViewModels.FoodVMs;
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
    public partial class FoodFormList : Form
    {
        private readonly IFoodBLL foodBLL;
        private readonly ICategoryBLL categoryBLL;

        public FoodFormList(IFoodBLL foodBLL,ICategoryBLL categoryBLL)
        {
            InitializeComponent();
            this.foodBLL = foodBLL;
            this.categoryBLL = categoryBLL;
        }

        private void FoodFormList_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void Fill()
        {
            dataGridView1.DataSource=foodBLL.GetAllFoods().ListData;
            dataGridView1.Columns["CategoryId"].Visible = false;
            cbCatogory.DataSource= categoryBLL.GetAllCategoryName().ListData.Select(x => new CategoryBaseVM
            {
                Id=x.ID,
                Name=x.CategoryName
            }).ToList();
            cbCatogory.ValueMember = "Id";
            cbCatogory.DisplayMember = "Name";
            cbCatogory.SelectedIndex = 0;
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtFoodName.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDesc.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCalori.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbCatogory.SelectedValue= dataGridView1.CurrentRow.Cells[4].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FoodUpdateVM fm=new FoodUpdateVM()
            {
                Id=Convert.ToInt32(txtId.Text),
                Calorie=Convert.ToDouble(txtCalori.Text),
                FoodName = txtFoodName.Text,
                Description = txtDesc.Text,
                CategoryId=Convert.ToInt32(cbCatogory.SelectedValue),
            };
            ResultService<FoodUpdateVM> result=foodBLL.UpdateFood(fm);
            string v=foodBLL.GetResult(result);
            MessageBox.Show(v);
            if (v.Contains("Başarılı"))
            {
                Fill();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            ResultService<FoodBaseVM> result = foodBLL.DeleteFood(id);
            string v = foodBLL.GetResult(result);
            MessageBox.Show(v);
            if (v.Contains("Başarılı"))
            {
                Fill();
            }
        }
    }
}
