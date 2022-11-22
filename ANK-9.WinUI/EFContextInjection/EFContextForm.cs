using ANK_9.BLL.Concrete.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.WinUI.EFContextInjection
{
    public static class EFContextForm
    {
        private static IServiceProvider _serviceprovider;

        private static IHostBuilder CreateHostBuilder<T>() where T : Form
        {
            var result = Host.CreateDefaultBuilder()
                            .ConfigureServices((context, services) =>
                            {
                                services.AddScopeBLL();
                                services.AddTransient<T>();
                            });
            return result;
        }
        public static Form ConfigureServices<T>() where T : Form
        {
            var host = CreateHostBuilder<T>().Build();
            _serviceprovider = host.Services;
            return _serviceprovider.GetRequiredService<T>();
        }
    }
}
