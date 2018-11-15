using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DBConnect
    {
        public SqlConnection con = new SqlConnection(@"Data Source=TIENTHANH\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
        public void openDb()
        {
            if (con != null && con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeDb()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }


    }
}
