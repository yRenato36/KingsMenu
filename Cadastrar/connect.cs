using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cadastrar
{
    internal class connect
    {
        private static string server = @"RENATO-PC";
        private static string dataBase = "kingsmenu";
        private static string user = "root@localhost";
        private static string password = "1234";

        public static string StrCon
        {
            get
            {
                return $"Data Source ={server}; Integrated Security=false;Initial Catalog={dataBase}; " +
                  $"User ID={user}; Password={password}";
            }
        }
    }
}