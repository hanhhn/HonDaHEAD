using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAHondaHead;
using DATAHondaHead.Info;
using System.Data.SqlClient;
using System.Data;

namespace DATAHondaHead.DAL
{
    public class ChucVuDAL:SqlDataProvider
    {
        public DataTable ChucVu_Get()
        {
            using (var cmd = new SqlCommand("sp_ChucVu_Get", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public string ChucVu_GetTen(int MaChucVu)
        {
            using (var cmd = new SqlCommand("sp_ChucVu_GetTen", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaChucVu", MaChucVu));
                return cmd.ExecuteScalar().ToString();
            }
        }
        public double ChucVu_getLuong(int MaChucVu)
        {
            using (var cmd = new SqlCommand("sp_ChucVu_GetLuong", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaChucVu", MaChucVu));
                return double.Parse(cmd.ExecuteScalar().ToString());
            }
        }
    }
}
