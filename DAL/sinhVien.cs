using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLThuoc;
namespace DAL
{
    public class sinhVien:DBConnect
    {
        thuoc t = new thuoc();
        public DataTable insertSinhVien(thuoc t)
        {
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("tênPro",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@dsd", t.Congdung));
            
            

            return tb;
        }
    }
}
