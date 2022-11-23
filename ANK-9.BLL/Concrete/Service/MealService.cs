using ANK_9.BLL.Abstract;
using ANK_9.DAL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.MealVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.BLL.Concrete.Service
{
    public class MealService : IMealBLL
    {
        private readonly IMealDAL mealDAL;

        public MealService(IMealDAL mealDAL)
        {
            this.mealDAL = mealDAL;
        }

        public ResultService<MealUpdateVM> UpdateMeal(MealUpdateVM vm)
        {
            ResultService<MealUpdateVM> result = new ResultService<MealUpdateVM>();
            try
            {
                Meal meal = mealDAL.Get(x=>x.ID.Equals(vm.Id));
                meal.MealName = vm.MealName;
                meal.UpdateOn = vm.UpdateOn;

                Meal updateMeal=mealDAL.Update(meal);
                result.Data = vm;
            }
            catch (Exception)
            {
                result.Data = vm;
                result.AddError("Güncelleme Başarısız","Kayıt bulunamadı");
            }
            return result;
        }

        public ResultService<MealBaseVM> DeleteMeal(int id)
        {
            ResultService<MealBaseVM> result = new ResultService<MealBaseVM>();
            try
            {
                Meal meal = mealDAL.Get(x=>x.IsActive==true&&x.ID==id);
                meal.IsActive = false;
                result.Data = new MealBaseVM()
                {
                    MealName=meal.MealName,
                };
                mealDAL.Delete(meal);
            }
            catch (Exception)
            {
                result.AddError("silme işlemi başarısız","Kayıt bulunamadı.");
            }
            return result;
        }

        public ResultService<MealBaseVM> GetAllMeal()
        {
            ResultService<MealBaseVM> result= new ResultService<MealBaseVM>();
            List<MealBaseVM> BaseList = mealDAL.GetAll(x=>x.IsActive).Select(x=> new MealBaseVM()
            {
                Id=x.ID,
                MealName=x.MealName
            }).ToList();
            if (BaseList.Count>0)
            {
                result.ListData = BaseList;
            }
            else
            {
                result.AddError("Verilere Ulaşılamadı", "Verilere Ulaşılamadı.");
            }
            return result;
        }

        public ResultService<Meal> GetMeal(string mealName)
        {
            ResultService<Meal> result= new ResultService<Meal>();
            result.Data = mealDAL.Get(x=>x.IsActive == true && x.MealName.Equals(mealName));
            if (result.Data==null)
            {
                result.AddError("Kayıt bulunamadı", "Kayıt bulunamadı");
            }
            return result;
        }

        public ResultService<Meal> GetMeal(int id)
        {
            ResultService<Meal> result = new ResultService<Meal>();
            result.Data = mealDAL.Get(x=>x.IsActive && x.ID==id);
            if (result.Data == null)
            {
                result.AddError("Kayıt bulunamadı", "Kayıt bulunamadı");
            }
            return result;
        }

        public ResultService<Meal> CreateMeal(MealCreateVm vm)
        {
            ResultService<Meal> result = new ResultService<Meal>();
            Meal newMeal = new Meal
            {
                MealName = vm.MealName,
                CreateOn = vm.CreateOn,
            };
            Meal addMeal = mealDAL.Add(newMeal);
            if (addMeal == null)
            {
                result.AddError("Ekleme İşlemi başarısız", "bir sorun oluştu");
                return result;
            }
            result.Data = addMeal;
            return result;
        }
    }
}
