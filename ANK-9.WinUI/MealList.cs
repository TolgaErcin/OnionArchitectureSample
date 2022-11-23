using ANK_9.BLL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
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
    public partial class MealList : Form
    {
        private readonly IMealBLL _mealBLL;
        public MealList(IMealBLL mealBLL)
        {
            InitializeComponent();
            _mealBLL = mealBLL;
        }

        private void MealList_Load(object sender, EventArgs e)
        {
            MealListFill();
        }

        private void MealListFill()
        {
            lst_mealList.Items.Clear();
            ResultService<MealBaseVM> result = _mealBLL.GetAllMeal();

            GetError<MealBaseVM>(result);

            string[] baseVMs = result.ListData.Select(x => x.MealName).ToArray();
            lst_mealList.Items.AddRange(baseVMs);
            
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string mealName = txt_createMeal.Text;
            if (string.IsNullOrWhiteSpace(mealName)) return;

            MealCreateVm createVM=new MealCreateVm(){MealName = mealName,};

            ResultService<Meal> result= _mealBLL.CreateMeal(createVM);
            GetError<Meal>(result);
            MealListFill();
        }
        private void GetError<T>(ResultService<T> result) where T : class
        {
            if (result.HasError)
            {
                string errorMessage = result.Errors.FirstOrDefault().ErrorMessage;
                string errorType = result.Errors.FirstOrDefault().ErrorType;
                MessageBox.Show(errorMessage, errorType, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
        }
        ResultService<Meal> _result;

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Meal.Text)) return;

            GetError<Meal>(_result);

            MealUpdateVM updateVM=new MealUpdateVM()
            {
                Id=_result.Data.ID,
                MealName=_result.Data.MealName
            };
            ResultService<MealUpdateVM> updateResult=_mealBLL.UpdateMeal(updateVM);
            GetError<MealUpdateVM>(updateResult);
            MessageBox.Show("Güncelleme başarılı",updateResult.Data.MealName);
            MealListFill();
        }

        private void lst_mealList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Meal.Text=lst_mealList.SelectedItem.ToString();
            _result = _mealBLL.GetMeal(txt_Meal.Text);
            GetError<Meal>(_result);
        }
                
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Meal.Text)) return;

            ResultService<MealBaseVM> deleted = _mealBLL.DeleteMeal(_result.Data.ID);
            GetError<MealBaseVM>(deleted);
            MessageBox.Show("Silme işlemi başarılı",deleted.Data.MealName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MealListFill();
        }
    }
}
