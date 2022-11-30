using ANK_9.BLL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.FoodVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ANK_9.WebUI.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class FoodController : Controller
    {
        private readonly IFoodBLL foodBLL;
        private readonly ICategoryBLL categoryBLL;

        public FoodController(IFoodBLL foodBLL,ICategoryBLL categoryBLL)
        {
            this.foodBLL = foodBLL;
            this.categoryBLL = categoryBLL;
        }
        public IActionResult Index()
        {
            ResultService<FoodListVM> result=foodBLL.GetAllFoods();
            return View(result);
        }
        public List<SelectListItem> FillCategory()
        {
            return categoryBLL.GetAllCategoryName().ListData.Select(x => new SelectListItem
            {
                Value=x.ID.ToString(),
                Text=x.CategoryName
            }).ToList();
        }
        public IActionResult Create()
        {
            List<SelectListItem> list =FillCategory();
            ViewBag.categoryList=list;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FoodCreateVM vm)
        {
            //ResultService<Food> CreateFood(FoodCreateVM foodCreateVM)
            ResultService<Food> result=foodBLL.CreateFood(vm);
            string sonuc=foodBLL.GetResult(result);
            ViewData["result"] = sonuc;
            if (sonuc.Contains("Başarılı"))
            {
                TempData["result"] = sonuc;
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            ResultService<FoodBaseVM> result=foodBLL.DeleteFood(id);
            string v= foodBLL.GetResult(result);
            TempData["return"]=v;

            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            ResultService<FoodUpdateVM> result = foodBLL.GetFoodById(id);
            ViewBag.categoryList = FillCategory();
            ViewData["Errors"] = result.HasError ? result.Errors.FirstOrDefault().ErrorMessage : null;
            return View(result.Data);
        }
        [HttpPost]
        public IActionResult Update(FoodUpdateVM foodUpdateVM)
        {
            ResultService<FoodUpdateVM> resultService = foodBLL.UpdateFood(foodUpdateVM);
            string result = foodBLL.GetResult(resultService);
            ViewData["result"] = result;
            if (result.Contains("Başarılı"))
            {
                TempData["result"] = " Güncelleme " + result;
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Details(int id)
        {
            ResultService<FoodUpdateVM> resultService = foodBLL.GetFoodById(id);
            string result = foodBLL.GetResult(resultService);
            ViewData["result"] = result;
            return View(resultService.Data);
        }
    }
}
