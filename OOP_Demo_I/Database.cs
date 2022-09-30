using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_I
{
    static class Database
    {
        public static string ConnectionString
        {
            get
            {
                return @"server =.\sqlexpress;database=EmployeeDB;integrated security=true";
            }
        }
    }
}
