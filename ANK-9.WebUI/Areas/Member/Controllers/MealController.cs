using ANK_9.BLL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.MealFoodVMs;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace ANK_9.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    public class MealController : Controller
    {
        private readonly IMealBLL mealBLL;
        private readonly IMealFoodBLL mealFoodBLL;
        private readonly IFoodBLL foodBLL;
        private static int _id;

        public MealController(IMealBLL mealBLL,IMealFoodBLL mealFoodBLL,IFoodBLL foodBLL)
        {
            this.mealBLL = mealBLL;
            this.mealFoodBLL = mealFoodBLL;
            this.foodBLL = foodBLL;
        }
        public IActionResult Index()
        {
            if (TempData["Id"] != null)
            {
                _id = (int)TempData["Id"];
            }
            ResultService<MealFoodBaseVM> result = mealFoodBLL.GetMealFoodByUserId(_id);

            if (result.HasError)
            {
                string errorMessage = result.Errors.First().ErrorMessage;
                string errorType = result.Errors.First().ErrorType;
                ViewData["Error"] = errorType + "\n" + errorMessage;
            }
            return View(result.ListData);
        }
        //*******************************************
        public IActionResult Deneme()
        {
            return View();
        }
        //*******************************************
        
        public IActionResult Create()
        {
            ResultService<MealFoodCreateListVM> result = mealFoodBLL.CreateMealFood(_id);
            return View(result.Data);
        }

        // POST: MealController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            string mealName = string.Empty;
            List<string> mealFoods = new List<string>();
            List<int> portions = new List<int>();

            foreach (var item in collection)
            {
                if (item.Key.Equals("__RequestVerificationToken"))
                {
                    continue;
                }
                else if (item.Key.Equals("meal"))
                {
                    mealName = item.Value.ToString();
                }
                else if (item.Key.Equals("food"))
                {
                    mealFoods = item.Value.ToString().Split(',').ToList();
                }
                else if (item.Key.Equals("portion"))
                {
                    string[] ports = item.Value.ToString().Split(",");
                    foreach (var port in ports)
                    {
                        portions.Add(int.Parse(port));
                    }
                }
            }
            bool isValid = CreateMeal(mealName, mealFoods, portions);

            if (isValid)
            {
                return RedirectToAction(nameof(Index), nameof(HomeController));
            }
            return View();
        }

        private bool CreateMeal(string meal, List<string> foods, List<int> portions)
        {
            if (foods.Count != portions.Count)
            {
                return false;
            }

            bool error = default;

            for (int i = 0; i < foods.Count; i++)
            {
                MealFoodCreateVM vm = new MealFoodCreateVM()
                {
                    MealName = meal,
                    FoodName = foods[i],
                    Portion = portions[i],
                    UserId = _id
                };

                ResultService<MealFood> result = mealFoodBLL.CreateEatenMeal(vm);
                error = !result.HasError;

                if (!error)
                {
                    break;
                }
            }
            return error;
        }
    }
}
