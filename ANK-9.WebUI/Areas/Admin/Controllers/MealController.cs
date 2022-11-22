using ANK_9.BLL.Abstract;
using ANK_9.Sysstem;
using ANK_9.ViewModels.MealVMs;
using Microsoft.AspNetCore.Mvc;

namespace ANK_9.WebUI.Areas.Admin.Controllers
{
    [Area("admin")]
    public class MealController : Controller
    {
        private readonly IMealBLL mealBLL;

        public MealController(IMealBLL mealBLL)
        {
            this.mealBLL = mealBLL;
        }
        public IActionResult Index()
        {
            ResultService<MealBaseVM> result = mealBLL.GetAllMeal();
            return View(result);
        }
    }
}
