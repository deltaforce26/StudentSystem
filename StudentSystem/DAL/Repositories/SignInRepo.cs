using StudentSystem.DAL.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentSystem.DAL.Repositories
{
    internal class SignInRepo
    {
        private readonly DBcontext _dbcontext;

        public SignInRepo(DBcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }


        public bool addStudent(string fname, string lname, string password)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@fname", fname),
                new SqlParameter("@lname", lname),
                new SqlParameter("@password", password)
            };
            string query = "insert into students(first_name,last_name,password) values(@fname, @lname, @password)";
            int rowsAffected = _dbcontext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}
