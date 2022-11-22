
using ANK_9.BLL.Abstract;
using ANK_9.DAL.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace ANK_9.BLL.Concrete.Service
{
    public static class EFContextBLL
    {
        public static void AddScopeBLL(this IServiceCollection services)
        {
            services.AddScoppedDAL();
            services.AddScoped<IUserBLL, UserService>();
            services.AddScoped<ICategoryBLL, CategoryService>();
            services.AddScoped<IMealBLL, MealService>();
                    
        }
    }
}
