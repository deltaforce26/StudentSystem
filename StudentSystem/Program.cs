using Microsoft.Extensions.Configuration;
using StudentSystem.DAL.Services;
using StudentSystem.DAL.Repositories;
namespace StudentSystem
{
    internal  class Program
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
            FormHandler formHandler = new FormHandler();
            formHandler.ShowLoginForm();
            Application.Run();
        }
    }
}