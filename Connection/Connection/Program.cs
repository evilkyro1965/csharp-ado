using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            string connetionString = null;
            SqlConnection cnn ;
            connetionString = "Server=KYRO\\SQLEXPRESS;Database=qa;User ID=sa;Password=drowssap";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                Console.WriteLine("open");
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
        
            }
            Console.ReadKey();
        }
    }
}
