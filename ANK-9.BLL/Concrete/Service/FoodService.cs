using ANK_9.BLL.Abstract;
using ANK_9.DAL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.FoodVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.BLL.Concrete.Service
{
    public class FoodService : IFoodBLL
    {
        private readonly IFoodDAL _foodDAL;

        public FoodService(IFoodDAL foodDAL)
        {
            _foodDAL = foodDAL;
        }
        public ResultService<FoodListVM> GetAllFoods()
        {
            ResultService<FoodListVM> result = new ResultService<FoodListVM>();
            List<FoodListVM> foodvmList = _foodDAL.GetAll(x => x.IsActive, x=>x.Category).Select(x=> new FoodListVM
            {
                Id=x.ID,
                FoodName = x.FoodName,
                Description=x.Description,
                Calorie=x.Calorie,
                CategoryId=x.CategoryId,
                CategoryName=x.Category.CategoryName
            }).ToList();
            if (foodvmList.Count>0)
            {
                result.ListData = foodvmList;
            }
            else
            {
                result.AddError("Hata","Liste getirilemedi");
            }
            return result;
        }

        public ResultService<Food> CreateFood(FoodCreateVM foodCreateVM)
        {
            ResultService<Food> resultService = new ResultService<Food>();
            try
            {
                Food newfood = new Food()
                {
                    FoodName = foodCreateVM.FoodName,
                    Description = foodCreateVM.Description,
                    Calorie = foodCreateVM.Calorie,
                    CreateOn = foodCreateVM.CreateOn,
                    CategoryId = foodCreateVM.CategoryId,
                };
                Food addfood = _foodDAL.Add(newfood);
                resultService.Data = addfood ?? newfood;
            }
            catch (Exception)
            {
                resultService.AddError("Güncelleme basarısız", "Kayıt bulunamadı ");
            }
            

            return resultService;
        }

        public string GetResult<T>(ResultService<T> resultService) where T : class
        {
            string result = "";
            if (resultService.HasError)
            {
                result=resultService.Errors.FirstOrDefault()?.ErrorMessage+" "+resultService.Errors.FirstOrDefault().ErrorType;
                return result;
            }
            else
            {
                result = "Başarılı";
                return result;
            }
        }

        public ResultService<FoodUpdateVM> UpdateFood(FoodUpdateVM vm)
        {
            ResultService<FoodUpdateVM> result=new ResultService<FoodUpdateVM>();
            try
            {
                Food food = _foodDAL.Get(x => x.ID.Equals(vm.Id));
                food.Description = vm.Description;
                food.FoodName=vm.FoodName;
                food.Calorie=vm.Calorie;
                food.ID=vm.Id;
                food.CategoryId = vm.CategoryId;
                food.UpdateOn = vm.UpdateOn;
                Food food1 = _foodDAL.Update(food);
            }
            catch (Exception)
            {
                result.Data = vm;
                result.AddError("Güncelleme basarısız","Kayıt bulunamadı ");
            }

            return result;
        }

        public ResultService<FoodBaseVM> DeleteFood(int id)
        {
            ResultService<FoodBaseVM> result = new ResultService<FoodBaseVM>();
            try
            {
                Food food = _foodDAL.Get(x=>x.ID==id);
                food.IsActive=false;
                _foodDAL.Delete(food);
                result.Data = null;
            }
            catch (Exception)
            {
                result.AddError("Lilme Başarısız.","Kayıt bulunamadı");
            }
            return result;
        }

        public ResultService<FoodUpdateVM> GetFoodById(int id)
        {
            ResultService<FoodUpdateVM> result = new ResultService<FoodUpdateVM>();
            Food food = _foodDAL.Get(x=>x.ID==id);
            if (food!=null)
            {
                result.Data=new FoodUpdateVM()
                {
                    Id=food.ID,
                    FoodName=food.FoodName,
                    Calorie=food.Calorie,
                    Description=food.Description,
                    CategoryId=food.CategoryId,
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
