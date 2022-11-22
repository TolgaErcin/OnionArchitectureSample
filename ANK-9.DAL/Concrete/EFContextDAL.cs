using ANK_9.DAL.Abstract;
using ANK_9.DAL.Concrete.Context;
using ANK_9.DAL.Concrete.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ANK_9.DAL.Concrete
{
    public static class EFContextDAL
    {
        public static void AddScoppedDAL(this IServiceCollection services)
        {
            services.AddDbContext<ANK_9DiyetDbContext>()
                    .AddScoped<IUserDAL, UserRepository>()
                    .AddScoped<ICategoryDal,CategoryRepository>()
                    .AddScoped<IMealDAL, MealRepository>();
        }
    }
}
