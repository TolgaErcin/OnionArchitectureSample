using ANK_9.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.DAL.Concrete.Context.Configuration
{
    public class MealConfiguration:BaseConfiguration<Meal>
    {
        public override void Configure(EntityTypeBuilder<Meal> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.MealName).IsRequired().HasMaxLength(50);

            builder.HasData(
                new Meal { ID=1,MealName="Kahvaltı",IsActive=true,CreateOn=DateTime.Now},
                new Meal { ID=2,MealName="Öğle Yemeği",IsActive=true,CreateOn=DateTime.Now},
                new Meal { ID=3,MealName="Akşam Yemeği",IsActive=true,CreateOn=DateTime.Now}
                );
        }
    }
}
