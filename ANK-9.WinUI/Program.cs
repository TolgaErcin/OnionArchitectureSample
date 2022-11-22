using ANK_9.BLL.Concrete.Service;
using ANK_9.WinUI.EFContextInjection;
using Microsoft.Extensions.DependencyInjection;

namespace ANK_9.WinUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var form = EFContextForm.ConfigureServices<Login>();

            Application.Run(form);
        }
    }
}