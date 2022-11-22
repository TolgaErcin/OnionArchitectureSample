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
    }
}
