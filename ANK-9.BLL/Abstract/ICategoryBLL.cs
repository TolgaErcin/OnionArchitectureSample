using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.CategoryVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.BLL.Abstract
{
    public interface ICategoryBLL:IBaseBLL<Category>
    {
        ResultService<CategoryBaseVM> GetCategoryID(string categoryName);
        ResultService<Category> GetAllCategoryName();
        //metotların imzası yazıldı
        ResultService<Category> CreateCategory(CategoryNewVm categoryNewVm);
        ResultService<CategoryUpdateVM> UpdateCategory(CategoryUpdateVM categoryUpdateVM);
        ResultService<CategoryUpdateVM> GetCategoryById(int id);
        ResultService<Category> GetCategoryByName(string categoryName);
        ResultService<CategoryBaseVM> DeleteCategory(int id);
    }
}
