using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.ViewModels.FoodVMs
{
    public class FoodBaseVM
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string Description { get; set; }
        public double Calorie { get; set; }
    }
}
