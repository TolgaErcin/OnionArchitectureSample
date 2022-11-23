using ANK_9.BLL.Concrete.Service;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.MealVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.BLL.Abstract
{
    public interface IMealBLL:IBaseBLL<Meal>
    {
        ResultService<Meal> CreateMeal(MealCreateVm vm);
        ResultService<MealUpdateVM> UpdateMeal(MealUpdateVM vm);
        ResultService<MealBaseVM> DeleteMeal(int id);
        ResultService<Meal> GetMeal(string mealName);
        ResultService<Meal> GetMeal(int id);
        ResultService<MealBaseVM> GetAllMeal();
    }
}
