using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKho
{
    internal class KetNoiCSDL
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public SqlDataAdapter ada;
        public DataTable dta;

        public void KetNoi_Dulieu()
        {
            string str = @"Data Source=DESKTOP-0LTEIDP\MAYA0;Initial Catalog= SQL_QLKHO;Integrated Security=True";
            cnn = new SqlConnection(str);
            cnn.Open();
        }

        public void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable LayBang(string sql)
        {
            KetNoi_Dulieu();
            ada = new SqlDataAdapter(sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }

        public void ThucThi(string sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}
