using ANK_9.BLL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.CategoryVMs;
using ANK_9.ViewModels.FoodVMs;
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
    public partial class CreateFood : Form
    {
        private readonly IFoodBLL _foodBLL;
        private readonly ICategoryBLL _categoryBll;

        public CreateFood(ICategoryBLL categoryBll,IFoodBLL foodBLL)
        {
            InitializeComponent();
            _categoryBll = categoryBll;
            _foodBLL = foodBLL;
        }

        private void CreateFood_Load(object sender, EventArgs e)
        {
            ResultService<CategoryBaseVM> resultService = new ResultService<CategoryBaseVM>();
            resultService.ListData = _categoryBll.GetAllCategoryName().ListData.Select(x=> new CategoryBaseVM
            {
                Id=x.ID,
                Name=x.CategoryName
            }).ToList();
            cbCatogory.DataSource= resultService.ListData;
            cbCatogory.ValueMember = "Id";
            cbCatogory.DisplayMember = "Name";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FoodCreateVM createVM=new FoodCreateVM()
            {
                FoodName=txtFoodName.Text,
                Calorie=Convert.ToDouble(txtCalori.Text),
                 Description=txtDesc.Text,
                 CategoryId=Convert.ToInt32(cbCatogory.SelectedValue)
            };
            ResultService<Food> result=_foodBLL.CreateFood(createVM);
            string v=_foodBLL.GetResult(result);
            MessageBox.Show(v);
            if (/*v.Contains("Başarılı")*/v=="Başarılı")
            {
                Form frm = default;
                frm = EFContextForm.ConfigureServices<FoodFormList>();
                frm.Show();
            }
        }
    }
}
