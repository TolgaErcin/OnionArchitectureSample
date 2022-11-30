using ANK_9.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.Entities
{
    public class Meal:BaseEntity
    {
        public string MealName { get; set; }
        public ICollection<MealFood> MealFoods { get; set; }
        public Meal()
        {
            IsActive = true;
            this.MealFoods = new HashSet<MealFood>();
            // HashSet: bir listeye aynı elemanı attığımda zaten aynı eleman var diyen bir yapı
        }
    }
}
