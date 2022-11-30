using ANK_9.Entities;
using ANK_9.ViewModels.FoodVMs;
using ANK_9.ViewModels.MealVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.ViewModels.MealFoodVMs
{
    public class MealFoodCreateListVM
    {
        public int UserId { get; set; }
        public ICollection<MealBaseVM> Meals { get; set; }
        public ICollection<FoodBaseVM> Foods { get; set; }
        public MealFoodCreateListVM()
        {
            this.Foods = new List<FoodBaseVM>();
            this.Meals = new List<MealBaseVM>();    
        }
    }
}
