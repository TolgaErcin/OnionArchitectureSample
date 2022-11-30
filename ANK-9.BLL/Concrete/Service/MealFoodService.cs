using ANK_9.BLL.Abstract;
using ANK_9.DAL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.FoodVMs;
using ANK_9.ViewModels.MealFoodVMs;
using ANK_9.ViewModels.MealVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.BLL.Concrete.Service
{
    public class MealFoodService : IMealFoodBLL
    {
        private readonly IMealFoodDAL mealFoodDAL;
        private readonly IMealDAL mealDAL;
        private readonly IFoodDAL foodDAL;
        private readonly IUserDAL userDAL;

        public MealFoodService(IMealFoodDAL mealFoodDAL,IMealDAL mealDAL,IFoodDAL foodDAL,IUserDAL userDAL)
        {
            this.mealFoodDAL = mealFoodDAL;
            this.mealDAL = mealDAL;
            this.foodDAL = foodDAL;
            this.userDAL = userDAL;
        }
        public ResultService<MealFood> CreateEatenMeal(MealFoodCreateVM vm)
        {
            ResultService<MealFood> result = new ResultService<MealFood>();
            int mealId = mealDAL.Get(x => x.MealName.Equals(vm.MealName)).ID;
            int foodId = foodDAL.Get(x => x.FoodName.Equals(vm.FoodName)).ID;

            MealFood mealFood= new MealFood()
            {
                UserId=vm.UserId,
                MealId=mealId,
                FoodId=foodId,
                Portion=vm.Portion,
            };
            MealFood addMealFood = mealFoodDAL.Add(mealFood);
            result.Data = addMealFood ?? mealFood;
            return result;
        }
        public ResultService<MealFoodUpdateVM> UpdateMealFood(MealFoodUpdateVM vm)
        {
            ResultService<MealFoodUpdateVM> result = new ResultService<MealFoodUpdateVM>();
            try
            {
                MealFood mealFood = mealFoodDAL.Get(x => x.ID.Equals(vm.Id) && x.IsActive);

                mealFood.MealId=vm.MealId;
                mealFood.FoodId=vm.FoodId;
                mealFood.Portion=vm.Portion;
                mealFood.UpdateOn=vm.UpdateOn;
                MealFood updateMealFood=mealFoodDAL.Update(mealFood);

                result.Data = new MealFoodUpdateVM
                {
                    Id = mealFood.ID,
                    MealId = mealFood.MealId,
                    FoodId = mealFood.FoodId,
                    UserId = mealFood.UserId,
                    Portion = mealFood.Portion,
                };
            }
            catch (Exception)
            {
                result.Data = vm;
                result.AddError("Güncelleme başarısız","Kayıt Bulunamadı");
            }
            return result;
        }

        public ResultService<MealFoodBaseVM> DeletedMealFood(int id)
        {
            ResultService<MealFoodBaseVM> result = new ResultService<MealFoodBaseVM>();

            try
            {
                MealFood mealFood = mealFoodDAL.Get(x=>x.ID.Equals(x)&&x.IsActive);
                mealFood.IsActive = false;
                mealFoodDAL.Delete(mealFood);
            }
            catch (Exception)
            {
                result.AddError("Silme işlemi başarısız.","Kayıt Bulunamadı.");
            }

            return result;
        }
        public ResultService<MealFoodBaseVM> GetAllMealFood()
        {
            ResultService<MealFoodBaseVM> result = new ResultService<MealFoodBaseVM>();

            try
            {
                List<MealFood> mealFoods = mealFoodDAL.GetAll(x => x.IsActive).ToList();
                result.ListData = mealFoods.Select(x => new MealFoodBaseVM
                {
                    Id = x.ID,
                    UserId = x.UserId,
                    UserName = x.User.UserName,
                    MealName = x.Meal.MealName,
                    FoodName = x.Food.FoodName,
                    Calorie = x.Food.Calorie,
                    Portion = x.Portion
                }).ToList();
            }
            catch (Exception)
            {
                result.AddError("Hata.", "Kayıtlara Ulaşılamıyor");
            }
            return result;
        }

        public ResultService<MealFoodBaseVM> GetMealFoodByDate(DateTime date)
        {
            ResultService<MealFoodBaseVM> result = new ResultService<MealFoodBaseVM>();

            try
            {
                List<MealFood> mealFoods = mealFoodDAL
                    .GetAll(x => x.IsActive && x.CreateOn <= DateTime.Today.Date && x.CreateOn >= date.Date).ToList();

                result.ListData = mealFoods.Select(x => new MealFoodBaseVM
                {
                    Id = x.ID,
                    UserId = x.UserId,
                    UserName = x.User.UserName,
                    MealName = x.Meal.MealName,
                    FoodName = x.Food.FoodName,
                    Calorie = x.Food.Calorie,
                    Portion = x.Portion
                }).ToList();
            }
            catch (Exception)
            {
                result.AddError("Hata.", "Kayıtlara Ulaşılamıyor");
            }

            return result;
        }

        public ResultService<MealFoodBaseVM> GetMealFoodById(int id)
        {
            throw new NotImplementedException();
        }

        public ResultService<MealFoodBaseVM> GetMealFoodByMealName(string mealName)
        {
            throw new NotImplementedException();
        }

        public ResultService<MealFoodBaseVM> GetMealFoodByUserId(int id)
        {
            ResultService<MealFoodBaseVM> result = new ResultService<MealFoodBaseVM>();
            try
            {
                result.ListData = mealFoodDAL.GetAll(x => x.IsActive && x.User.ID == id).Select(x => new MealFoodBaseVM
                {
                    Id=x.ID,
                    UserName=userDAL.Get(y=>y.ID.Equals(x.UserId)).UserName,
                    UserId=x.UserId,
                    MealName=mealDAL.Get(y=>y.ID.Equals(x.MealId)).MealName,
                    FoodName=foodDAL.Get(y=>y.ID.Equals(x.FoodId)).FoodName,
                    Calorie=foodDAL.Get(y=>y.ID.Equals(x.FoodId)).Calorie,
                    Portion=x.Portion
                }).ToList();
            }
            catch (Exception)
            {
                result.AddError("Hata","Kayıtlara ulaşılamıyor");
            }
            return result;
        }

        public ResultService<MealFoodBaseVM> GetMealFoodByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public ResultService<MealFoodCreateListVM> CreateMealFood(int id)
        {
            ResultService<MealFoodCreateListVM> result = new ResultService<MealFoodCreateListVM>();

            try
            {
                List<MealBaseVM> meals = mealDAL.GetAll(x => x.IsActive).Select(x => new MealBaseVM
                {
                    Id = x.ID,
                    MealName = x.MealName
                }).ToList();

                List<FoodBaseVM> foods = foodDAL.GetAll(x => x.IsActive).Select(x => new FoodBaseVM
                {
                    Id = x.ID,
                    FoodName = x.FoodName,
                    Description = x.Description,
                    Calorie = x.Calorie
                }).ToList();

                result.Data = new MealFoodCreateListVM
                {
                    UserId = id,
                    Meals = meals,
                    Foods = foods,
                };
            }
            catch (Exception)
            {
                result.AddError("Hata", "Kayıtlara ulaşılamadı");
            }
            return result;
        }
    }
}
