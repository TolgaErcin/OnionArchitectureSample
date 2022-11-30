using ANK_9.BLL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.CategoryVMs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ANK_9.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryBLL categoryBLL;

        public CategoryController(ICategoryBLL categoryBLL)
        {
            this.categoryBLL = categoryBLL;
        }
        [HttpGet]
        public ResultService<Category> GetAllCategory()
        {
            ResultService<Category> resultService = categoryBLL.GetAllCategoryName();
            return resultService;
        }
        [HttpGet("{id}")]
        public ResultService<CategoryUpdateVM> GetCategoryById(int id)
        {
            ResultService<CategoryUpdateVM> resultService = categoryBLL.GetCategoryById(id);
            return resultService;
        }
        [HttpPost]
        public ResultService<Category> Create(CategoryNewVm vm)
        {
            ResultService<Category> resultService = categoryBLL.CreateCategory(vm);
            return resultService;
        }
        [HttpPut]
        public ResultService<CategoryUpdateVM> Update(CategoryUpdateVM vm)
        {
            ResultService<CategoryUpdateVM> resultService = categoryBLL.UpdateCategory(vm);
            return resultService;
        }
        [HttpDelete("{id}")]
        public ResultService<CategoryBaseVM> Delete(int id)
        {
            ResultService<CategoryBaseVM> resultService = categoryBLL.DeleteCategory(id);
            return resultService;
        }
    }
}
