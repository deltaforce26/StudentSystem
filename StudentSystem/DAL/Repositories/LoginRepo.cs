using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.DAL.Services;

namespace StudentSystem.DAL.Repositories
{
    internal class LoginRepo
    {

        private readonly DBcontext _dbcontext;

        public LoginRepo(DBcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public  bool PasswordValidation(string username, string password)
        {
            

            SqlParameter[] login_params = {
            new SqlParameter("@username", username),
            new SqlParameter("@password", password)
            };
            string loginquery = "SELECT tz, password FROM students s WHERE s.tz = @username AND s.password = @password";

            DataTable data = _dbcontext.MakeQuery(loginquery, login_params); 
            if (data.Rows.Count > 0)
            {
                return true;

            }
            return false;

        }

    }
}
