using ANK_9.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.Entities
{
    public class Food:BaseEntity
    {
        public string FoodName { get; set; }
        public string Description { get; set; }
        public double Calorie { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<MealFood> MealFoods { get; set; }
        public Food()
        {
            IsActive = true;
            MealFoods= new HashSet<MealFood>();
        }
    }
}
