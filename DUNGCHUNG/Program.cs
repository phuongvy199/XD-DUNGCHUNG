using System;
using System.Data;
using System.Data.SqlClient;

namespace DUNGCHUNG
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLDB.SQLDB.ConnectionString = @"Data Source=.\SQLEXPRESS;Integrated Security=True";
            SqlCommand sqlcmd = new SqlCommand("select * from KHACHHANG");
            DataTable dt = SQLDB.SQLDB.GetData(sqlcmd);
            Console.WriteLine(dt.Rows.Count.ToString());
            Console.ReadKey();
        }
    }
}
