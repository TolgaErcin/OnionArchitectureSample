using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.ViewModels.MealFoodVMs
{
    public class MealFoodCreateVM
    {
        public string MealName { get; set; }
        public string FoodName { get; set; }
        public int Portion { get; set; }
        public int UserId { get; set; }
        public DateTime Created=>DateTime.Now;
    }
}
