using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.FoodVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.BLL.Abstract
{
    public interface IFoodBLL:IBaseBLL<Food>
    {
        ResultService<Food> CreateFood(FoodCreateVM foodCreateVM);
        string GetResult<T>(ResultService<T> resultService) where T:class;
        ResultService<FoodListVM> GetAllFoods();
        ResultService<FoodUpdateVM> UpdateFood(FoodUpdateVM vm);
        ResultService<FoodBaseVM> DeleteFood(int id);
        ResultService<FoodUpdateVM> GetFoodById(int id);
    }
}
