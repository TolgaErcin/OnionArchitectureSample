using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.ViewModels.FoodVMs
{
    public class FoodCreateVM
    {
        public string FoodName { get; set; }
        public string Description { get; set; }
        public double Calorie { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreateOn=>DateTime.Now;
    }
}
