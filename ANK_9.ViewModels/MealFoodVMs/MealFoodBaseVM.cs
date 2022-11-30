using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.ViewModels.MealFoodVMs
{
    public class MealFoodBaseVM
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Portion { get; set; }
        public double Calorie { get; set; }
        public string FoodName { get; set; }
        public string MealName { get; set; }
        public double TotalCalorie { get { return Portion * Calorie; } }
    }
}
