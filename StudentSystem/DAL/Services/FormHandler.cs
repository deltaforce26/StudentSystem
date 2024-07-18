using Microsoft.Extensions.Configuration;
using StudentSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.DAL.Services
{
    internal class FormHandler
    {

        DBcontext dBcontext = new DBcontext(GetCs());
        

        public static string GetCs()
        {
            var config = new ConfigurationBuilder()
             .AddUserSecrets<Program>()
             .Build();
            string? cs = config["connectionString"];
           
            if (string.IsNullOrEmpty(cs))
            {
                throw new ArgumentNullException("Connection string or database name is missing");
            }
            return cs;
        }

        public void ShowLoginForm()
        {
            var MainForm = new LoginForm(new LoginRepo(dBcontext));
            MainForm.Show();
        }

        public void ShowSecondForm(string name, string password)
        {
            
            StudentForm student = new StudentForm(new StRepo(dBcontext),name);
            student.Show();
        }

        public void ShowSigninForm()
        {
            SignInForm signInForm = new SignInForm(new SignInRepo(dBcontext));
            signInForm.Show();
        }
    }
}
