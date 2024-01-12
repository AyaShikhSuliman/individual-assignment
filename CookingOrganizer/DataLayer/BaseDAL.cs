using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BaseDAL
    {
        private static string connectionString;
        static BaseDAL()
        {
            //connection string must be there
            connectionString = "Server=mssqlstud.fhict.local;Database=dbi485288;User Id=dbi485288;Password=dbi485288;";

        }
        protected SqlConnection GetDBConnection()
        {
            return new SqlConnection(connectionString);
        }
        //protected void OpenDBConnection()
        //{
        //    if (GetDBConnection().State == System.Data.ConnectionState.Closed)
        //        GetDBConnection().Open();
        //}

        //protected void CloseDBConnection()
        //{
        //    if (GetDBConnection().State == System.Data.ConnectionState.Open)
        //        GetDBConnection().Close();
        //}
    }
}
