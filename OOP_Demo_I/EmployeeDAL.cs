using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_I
{
    public class EmployeeDAL
    {
        public bool InsertEmployee()
        {
            SqlConnection objSqlConnection = new SqlConnection(Database.ConnectionString);
        }
    }
}
