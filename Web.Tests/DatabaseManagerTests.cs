using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Web.Tests
{
    [TestClass]
    public class DatabaseManagerTests
    {
        [TestMethod]
        public void InsertMessageTest()
        {
            var dbManager = new DatabaseManager();
            dbManager.AddMessage("a", "a", "34523452345", "123123123", "123123123");
            SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Farrukh\Algorithms\Algorithms\Data\DB.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM tbl_message";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            Console.WriteLine(reader.FieldCount);
            sqlConnection1.Close();
        }
    }
}
