using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.ViewModels.MealFoodVMs
{
    public class MealFoodUpdateVM
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FoodId { get; set; }
        public int MealId { get; set; }
        public int Portion { get; set; }
        public DateTime UpdateOn => DateTime.Now;
    }
}
