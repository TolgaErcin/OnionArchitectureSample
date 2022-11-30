using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.MealFoodVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.BLL.Abstract
{
    public interface IMealFoodBLL:IBaseBLL<Meal>
    {
        ResultService<MealFoodBaseVM> GetAllMealFood();
        ResultService<MealFood> CreateEatenMeal(MealFoodCreateVM vm);
        ResultService<MealFoodUpdateVM> UpdateMealFood(MealFoodUpdateVM vm);
        ResultService<MealFoodBaseVM> DeletedMealFood(int id);
        ResultService<MealFoodBaseVM> GetMealFoodById(int id);
        ResultService<MealFoodBaseVM> GetMealFoodByMealName(string mealName);
        ResultService<MealFoodBaseVM> GetMealFoodByUserId(int id);
        ResultService<MealFoodBaseVM> GetMealFoodByUserName(string userName);
        ResultService<MealFoodBaseVM> GetMealFoodByDate(DateTime date);
        ResultService<MealFoodCreateListVM> CreateMealFood(int id);
    }
}
