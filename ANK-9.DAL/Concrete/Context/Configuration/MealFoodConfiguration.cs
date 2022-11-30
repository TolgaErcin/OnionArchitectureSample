using ANK_9.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.DAL.Concrete.Context.Configuration
{
    public class MealFoodConfiguration:BaseConfiguration<MealFood>
    {
        public override void Configure(EntityTypeBuilder<MealFood> builder)
        {
            builder.Property(x => x.Portion).IsRequired();

            builder.Property(x => x.UserId).IsRequired();
            builder.HasOne(x => x.User)
                .WithMany(x => x.MealFoods)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);//

            builder.Property(x => x.FoodId).IsRequired();
            builder.HasOne(x => x.Food)
                .WithMany(x => x.MealFoods)
                .HasForeignKey(x => x.FoodId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.MealId).IsRequired();
            builder.HasOne(x => x.Meal)
                .WithMany(x => x.MealFoods)
                .HasForeignKey(x => x.MealId)
                .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
