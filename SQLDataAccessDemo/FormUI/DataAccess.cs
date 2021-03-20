using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {
        public List<Student> GetStudents(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GPA")))
            {
                // var output = connection.Query<Student>($"select * from Student where LastName = '{ lastName }'").ToList();
                var output = connection.Query<Student>("dbo.Student_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }             
        }
    }
}
