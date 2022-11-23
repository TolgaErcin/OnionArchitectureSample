using ANK_9.BLL.Abstract;
using ANK_9.DAL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.CategoryVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.BLL.Concrete.Service
{
    public class CategoryService : ICategoryBLL
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public ResultService<Category> CreateCategory(CategoryNewVm categoryNewVm)
        {
            ResultService<Category> result = new ResultService<Category>();
            bool checkCategory = AnyCategory(categoryNewVm.Name);
            if (!checkCategory)
            {
                Category newCategory = new Category 
                { 
                    CategoryName=categoryNewVm.Name,
                };
                Category addCategory=_categoryDal.Add(newCategory);
                result.Data = addCategory ?? newCategory;
            }
            else
            {
                result.Data = null;
                result.AddError("Ekleme basarısız", "Kayıt zaten var");
            }
            return result;
        }

        public bool AnyCategory(string categoryName)
        {
            bool validCategory = _categoryDal.GetAll(x => x.IsActive).Any(x => x.CategoryName == categoryName);
            return validCategory;
        }

        public ResultService<Category> GetAllCategoryName()
        {
            ResultService<Category> result = new ResultService<Category>();
            List<Category> categories = _categoryDal.GetAll(x=>x.IsActive,x=>x.Foods).ToList();
            if (categories != null)
            {
                result.ListData = categories;
            }
            else
            {
                result.AddError(" Liste Boş","Herhangi bir kategori yok");
            }
            return result;
        }

        public ResultService<CategoryBaseVM> GetCategoryID(string categoryName)
        {
            ResultService<CategoryBaseVM> result = new ResultService<CategoryBaseVM>();
            Category category = _categoryDal.Get(x => x.CategoryName == categoryName);
            if (category != null)
            {
                result.Data = new CategoryBaseVM()
                {
                    Id = category.ID,
                    Name = category.CategoryName
                };
            }
            else
            {
                result.Data = new CategoryBaseVM()
                {
                    Id = -1,
                    Name = categoryName
                };
                result.AddError("Kayıt Bulunamadı.","Bu isimde bir kategori yok");
            }
            return result;
        }

        public ResultService<CategoryUpdateVM> UpdateCategory(CategoryUpdateVM categoryUpdateVM)
        {
            ResultService<CategoryUpdateVM> result = new ResultService<CategoryUpdateVM>();
            Category category = _categoryDal.Get(x => x.ID.Equals(categoryUpdateVM.Id) && x.IsActive);
            if (category!=null)
            {
                if (!AnyCategory(categoryUpdateVM.Name))
                {
                    category.CategoryName= categoryUpdateVM.Name;
                    category.UpdateOn = categoryUpdateVM.UpdateOn;
                    Category updatecategory = _categoryDal.Update(category);
                    result.Data = new CategoryUpdateVM()
                    {
                        Id=updatecategory.ID,
                        Name=updatecategory.CategoryName
                    };
                }
                else
                {
                    result.AddError("Güncelleme basarısız", "Bu kayıt zaten var");
                }
            }
            else
            {
                result.Data = categoryUpdateVM;
                result.AddError("Güncelleme basarısız","Kayıt Bulunamadı");
            }
            return result;
        }

        public ResultService<Category> GetCategoryByName(string categoryName)
        {
            ResultService<Category> result = new ResultService<Category>();
            Category category = _categoryDal.Get(x=>x.CategoryName==categoryName);
            if (category!=null)
            {
                result.Data = new Category()
                {
                    CategoryName=category.CategoryName,
                    ID=category.ID
                };
            }
            else
            {
                result.Data = null;
                result.AddError("Kayıt Bulunamadı.","Bu isimde kayıt bulunmamaktadır.");
            }

            return result;
        }

        public ResultService<CategoryBaseVM> DeleteCategory(int id)
        {
            ResultService<CategoryBaseVM> resultService = new ResultService<CategoryBaseVM>();
            try
            {
                Category category = _categoryDal.Get(x=>x.ID.Equals(id) && x.IsActive);
                category.IsActive = false;
                _categoryDal.Delete(category);
                resultService.Data = null;
            }
            catch (Exception)
            {
                resultService.AddError("Silme işlemi başarısız","Kayıt bulunamadı.");
            }

            return resultService;
        }

        public ResultService<CategoryUpdateVM> GetCategoryById(int id)
        {
            ResultService<CategoryUpdateVM> result=new ResultService<CategoryUpdateVM>();
            Category category = _categoryDal.Get(x => x.ID.Equals(id));
            if (category!=null)
            {
                result.Data = new CategoryUpdateVM
                {
                    Id = category.ID,
                    Name = category.CategoryName
                };
            }
            else
            {
                result.AddError("Hata","Kayıt bulunamadı");
            }
            return result;
        }
    }
}
