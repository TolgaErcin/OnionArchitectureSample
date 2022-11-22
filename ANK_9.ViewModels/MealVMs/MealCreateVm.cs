using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.ViewModels.MealVMs
{
    public class MealCreateVm
    {
        public string MealName { get; set; }
        public DateTime CreateOn => DateTime.Now;
    }
}
