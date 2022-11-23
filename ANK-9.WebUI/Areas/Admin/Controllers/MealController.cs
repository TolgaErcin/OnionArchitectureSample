using ANK_9.BLL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.MealVMs;
using Microsoft.AspNetCore.Mvc;

namespace ANK_9.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
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
        //GET: MealController/Id
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MealCreateVm vm)
        {
            ResultService<Meal> result = mealBLL.CreateMeal(vm);
            if (result.HasError)
            {
                string errorMessage = result.Errors.ToList()[0].ErrorMessage;
                string errorType=result.Errors.ToList()[0].ErrorType;

                ViewData["Errors"]=errorMessage+"\n"+errorType;
                return View(vm);
            }
            TempData["Success"] = result.Data.MealName+"\n"+"Kayıt işlemi basarılı";
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            ResultService<Meal> result = mealBLL.GetMeal(id);
            MealUpdateVM updateVM = new MealUpdateVM()
            {
                Id=result.Data.ID,
                MealName=result.Data.MealName,
            };
            return View(updateVM);
        }
        [HttpPost]
        public IActionResult Update(MealUpdateVM vm)
        {
            ResultService<MealUpdateVM> result = mealBLL.UpdateMeal(vm);
            if (result.HasError)
            {
                string errorMessage = result.Errors.ToList()[0].ErrorMessage;
                string errorType = result.Errors.ToList()[0].ErrorType;

                ViewData["Errors"] = errorMessage + "\n" + errorType;
                return View(vm);
            }
            TempData["Success"] = result.Data.MealName + "\n" + "Güncelleme işlemi basarılı";
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            ResultService<MealBaseVM> result = mealBLL.DeleteMeal(id);
            if (result.HasError)
            {
                string errorMessage = result.Errors.ToList()[0].ErrorMessage;
                string errorType = result.Errors.ToList()[0].ErrorType;

                TempData["Errors"] = errorMessage + "\n" + errorType;
                // Farklı action lara veri gönderirken tempData kullanılır
            }
            else
            {
                string message = "Silme işlemi başarılı";
                string deletedName=result.Data.MealName;
                TempData["Success"] =message + "\n" + deletedName;
            }

            return RedirectToAction("Index");
        }
    }
}
