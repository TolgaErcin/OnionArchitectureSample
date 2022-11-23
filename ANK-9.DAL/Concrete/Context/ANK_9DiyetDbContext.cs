using ANK_9.DAL.Concrete.Context.Configuration;
using ANK_9.Entities;
using Microsoft.EntityFrameworkCore;

namespace ANK_9.DAL.Concrete.Context
{
    public class ANK_9DiyetDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=TOLGA\MSSQLSERVER1;Database=ANK9Diyet;User Id=sa;Password=123;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealFood> MealsFoods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new MealConfiguration());
            modelBuilder.ApplyConfiguration(new FoodConfiguration());
        }
    }
}
