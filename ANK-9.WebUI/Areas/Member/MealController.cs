using ANK_9.BLL.Abstract;
using ANK_9.Sysstem;
using ANK_9.ViewModels.MealFoodVMs;
using Microsoft.AspNetCore.Mvc;

namespace ANK_9.WebUI.Areas.Member
{
    [Area("Member")]
    public class MealController : Controller
    {
        private readonly IMealBLL mealBLL;
        private readonly IFoodBLL foodBLL;
        private readonly IMealFoodBLL mealFoodBLL;
        private static int _id;

        public MealController(IMealBLL mealBLL,IFoodBLL foodBLL,IMealFoodBLL mealFoodBLL)
        {
            this.mealBLL = mealBLL;
            this.foodBLL = foodBLL;
            this.mealFoodBLL = mealFoodBLL;
        }
        public IActionResult Index()
        {
            if (TempData["Id"]!=null)
            {
                _id = (int)TempData["Id"];
            }
            ResultService<MealFoodBaseVM> result=mealFoodBLL.GetMealFoodByUserId(_id);
            if (result.HasError)
            {
                string errorMessage = result.Errors.First().ErrorMessage;
                string errorType= result.Errors.First().ErrorType;
                ViewData["Error"] = errorType+"\n"+errorMessage;
            }
            return View(result.ListData);
        }
    }
}
