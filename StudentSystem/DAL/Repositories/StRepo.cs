using StudentSystem.DAL.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.DAL.Repositories
{
    internal class StRepo
    {
        private readonly DBcontext _dbcontext;

        public StRepo(DBcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public object GetStudentDebt(string tz)
        {
            SqlParameter[] parameters = {new SqlParameter("@tz", tz)};
            string query = "select sum(debt) from Payments where Student_ID = (select id from students where tz = @tz)";
            object res = _dbcontext.ExecuteScalar(query, parameters);
            return res;
        }
        public DataTable GetStudent(string tz)
        {
            SqlParameter[] parameters = {new SqlParameter("@tz", tz)};
            string query = "SELECT s.*, p.sum(debt) FROM students WHERE tz = @tz";
            DataTable dt = _dbcontext.MakeQuery(query, parameters);
            return dt;
        }

        public bool enterStudent(string fname, string lname, string cname)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@fname", fname),
                new SqlParameter("@lname", lname),
                new SqlParameter("@cname", cname)
            };
            string query = "INSERT INTO students(first_name, last_name,debt) VALUES(@fname,@lname,(SELECT price FROM courses WHERE name = @cname)) INSERT INTO enrolled(student_id,course_id) VALUES((SELECT id FROM students WHERE first_name = @fname AND last_name = @lname),(SELECT id FROM courses  WHERE name = @cname))";
            int rowsAffected = _dbcontext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool enrollStudent(string tz, string password, string cname)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@tz", tz),
                new SqlParameter("@password", password),
                new SqlParameter("@cname", cname)
            };
            string query = "DECLARE @answer VARCHAR(25) = 'false' DECLARE @result VARCHAR(25) = 'no' IF EXISTS(SELECT * FROM students WHERE tz = @tz AND password = @password) BEGIN SET @answer = 'true' END IF @answer = 'true' BEGIN IF EXISTS(SELECT name FROM courses c INNER JOIN enrolled e on e.Course_ID = c.ID INNER JOIN students s ON s.ID = e.Student_ID WHERE s.tz = @tz AND s.password = @password AND c.name = @cname) BEGIN SET @result = 'yes' END END SELECT @result";
            object answer =  _dbcontext.ExecuteScalar(query);
            if (answer.ToString() == "yes")
            {
                return false;
            }
            return true;
        }
    }
}
