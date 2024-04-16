using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp.views;
namespace Supermarket_mvp.Views
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
            string sqlConnectionString = "";
            IPayModeView view = new PayModeView();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            Application.Run(new PayModeView());
        }
    }
}
