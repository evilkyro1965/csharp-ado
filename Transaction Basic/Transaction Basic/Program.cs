using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Transactions;

namespace Transaction_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Customers([ContactName],[CompanyName]) VALUES ('test','test')", conn);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Customers([ContactName],[CompanyName]) VALUES ('test','test')", conn);
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                }
                scope.Complete();
            }

            Console.ReadKey();
        }
    }
}
