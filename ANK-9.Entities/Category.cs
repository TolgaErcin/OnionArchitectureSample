using ANK_9.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public ICollection<Food> Foods { get; set; }
        public Category()
        {
            IsActive = true;
            this.Foods = new HashSet<Food>(); // ICoolectionun instance ını alarak hata vermesini engelledik
        }
    }
}
