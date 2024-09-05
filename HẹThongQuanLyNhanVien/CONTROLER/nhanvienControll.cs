using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HẹThongQuanLyNhanVien.DAO;
using HẹThongQuanLyNhanVien.SERVICE;

namespace HẹThongQuanLyNhanVien.CONTROLER
{
    public class nhanvienControll
    {
        private nhanvienDAO dao = new nhanvienDAO();
        SqlConnection conn = new SqlConnection(Database.conn);
        private void open()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

    }
}
