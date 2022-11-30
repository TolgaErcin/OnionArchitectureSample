using ANK_9.BLL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.FoodVMs;
using ANK_9.ViewModels.MealFoodVMs;
using ANK_9.ViewModels.MealVMs;
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
    public partial class CreateMeal : Form
    {
        private readonly IMealBLL mealBLL;
        private readonly IMealFoodBLL mealFoodBLL;
        private readonly IFoodBLL foodBLL;

        public CreateMeal(IMealBLL mealBLL,IMealFoodBLL mealFoodBLL,IFoodBLL foodBLL)
        {
            InitializeComponent();
            this.mealBLL = mealBLL;
            this.mealFoodBLL = mealFoodBLL;
            this.foodBLL = foodBLL;
        }

        private void CreateMeal_Load(object sender, EventArgs e)
        {
            ResultService<FoodListVM> resultFood=foodBLL.GetAllFoods();
            dgv_foodList.DataSource = resultFood.ListData;

            ResultService<MealBaseVM> resultMeal = mealBLL.GetAllMeal();
            string[] mealNames = resultMeal.ListData.Select(x => x.MealName).ToArray();
            cb_meal.Items.Clear();
            cb_meal.Items.AddRange(mealNames);
        }

        private string _foodName;

        private void dgv_foodList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            _foodName = dgv_foodList[1, rowIndex].Value.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string mealName=cb_meal.Text;
            int portion = (int)nub_Portion.Value;

            MealFoodCreateVM createVM= new MealFoodCreateVM()
            {
                UserId=UserFormUI.Id,
                MealName=mealName,
                Portion=portion,
                FoodName=_foodName,
            };
            ResultService<MealFood> result=mealFoodBLL.CreateEatenMeal(createVM);

            if (result.Data!=null)
            {
                MessageBox.Show("Ekleme Başarısız",result.Data.Food.FoodName);
            }
        }
    }
}
