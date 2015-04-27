using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ConnectionXml
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var connectionString = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
            var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Open");
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
