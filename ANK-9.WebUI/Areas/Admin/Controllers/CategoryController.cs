using ANK_9.BLL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.CategoryVMs;
using Microsoft.AspNetCore.Mvc;

namespace ANK_9.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryBLL _categoryBLL;

        public CategoryController(ICategoryBLL categoryBLL)
        {
            _categoryBLL = categoryBLL;
        }
        public IActionResult Index()
        {
            ResultService<CategoryBaseVM> result = new ResultService<CategoryBaseVM>();
            result.ListData = _categoryBLL.GetAllCategoryName().ListData.Select(x=>new CategoryBaseVM
            {
                Id=x.ID,
                Name=x.CategoryName
            }).ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryNewVm vm)
        {
            ResultService<Category> result = _categoryBLL.CreateCategory(vm);
            if (result.HasError)
            {
                string errorMessage = result.Errors.ToList()[0].ErrorMessage;
                string errorType = result.Errors.ToList()[0].ErrorType;

                ViewData["Errors"] = errorMessage + " " + errorType;
                return View(vm);
            }

            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            ResultService<CategoryUpdateVM> result=_categoryBLL.GetCategoryById(id);
            ViewData["Errors"]=result.HasError ? result.Errors.FirstOrDefault().ErrorMessage:null;
            return View(result.Data);
        }
        [HttpPost]
        public IActionResult Update(CategoryUpdateVM vm)
        {
            ResultService<CategoryUpdateVM> result= _categoryBLL.UpdateCategory(vm); 
            //ViewData["Errors"] = result.HasError ? string.Concat(result.Errors.FirstOrDefault().ErrorMessage," ",(result.Errors.FirstOrDefault().ErrorType)) : null;
            if (result.HasError)
            {
                string errorMessage = result.Errors.ToList()[0].ErrorMessage;
                string errorType = result.Errors.ToList()[0].ErrorType;

                ViewData["Errors"] = errorMessage + " " + errorType;
                return View(vm);
            }

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Detail(int id)
        {
            ResultService<CategoryUpdateVM> result = _categoryBLL.GetCategoryById(id);
            ViewData["Errors"] = result.HasError ? string.Concat(result.Errors.FirstOrDefault().ErrorMessage, " ", (result.Errors.FirstOrDefault().ErrorType)) : null;
            return View(result.Data);
        }
        public IActionResult Delete(int id)
        {
            ResultService < CategoryBaseVM > result = _categoryBLL.DeleteCategory(id);
            if (result.HasError)
            {
                string errorMessage = result.Errors.ToList()[0].ErrorMessage;
                string errorType = result.Errors.ToList()[0].ErrorType;

                TempData["Errors"] = errorMessage + " " + errorType;
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["Success"] = "Silme Başarılı";
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
