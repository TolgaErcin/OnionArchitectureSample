using ANK_9.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.Entities
{
    public class MealFood:BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
