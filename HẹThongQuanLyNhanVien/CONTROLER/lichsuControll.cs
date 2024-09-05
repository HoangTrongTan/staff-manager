using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HẹThongQuanLyNhanVien.SERVICE;

namespace HẹThongQuanLyNhanVien.CONTROLER
{
    public class lichsuControll
    {
        SqlConnection conn = new SqlConnection(Database.conn);
        private void open()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public int delete()
        {
            open();
            int i = 0;
            SqlCommand cmd = new SqlCommand("DELETE FROM NV_temp", conn);
            i = cmd.ExecuteNonQuery();
            return i;
        }
    }
}
