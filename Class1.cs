using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Data;


namespace Final_Project
{
    class Class1
    {
        internal static string CnnStr = "Data Source=.;Initial Catalog=master;MultipleActiveResultSets=True;User Id=sa;Password=123456789";
        internal static SqlConnection Cnn = new SqlConnection(CnnStr);
        internal static void CreateConnection()
        {
            if (Class1.Cnn.State == ConnectionState.Closed)
            {
                Class1.Cnn.Open();
            }
        }
        internal static void CloseConnection()
        {
            if (Class1.Cnn.State == ConnectionState.Open)
            {
                Class1.Cnn.Close();
            }
        }
        public static string uid { get; set; }

    }
}
