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
    public class KhachHangDAL : SqlDataProvider
    {
        public void KhachHang_Insert(KhachHang Data)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenKH", Data.TenKhachHang));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", Data.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@CMND", Data.CMND));
                cmd.Parameters.Add(new SqlParameter("@SDT", Data.SDT));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", Data.NgaySinh));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable KhachHang_DanhSach()
        {
            using (var cmd = new SqlCommand("sp_KhachHang_DanhSach", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public string KhachHang_GetGioiTinh(string TenKH)
        {
            using(var cmd=new SqlCommand("sp_KhachHang_GetGioiTinh",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenKH", TenKH));
                return (string)cmd.ExecuteScalar();
            }
        }
        public int KhachHang_GetMaKH(string TenKH)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_GetMaKH", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenKH", TenKH));
                return (int)cmd.ExecuteScalar();
            }
        }
        public void KhachHang_Update(KhachHang Data)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKH", Data.MaKH));
                cmd.Parameters.Add(new SqlParameter("@TenKH", Data.TenKhachHang));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", Data.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@CMND", Data.CMND));
                cmd.Parameters.Add(new SqlParameter("@SDT", Data.SDT));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", Data.NgaySinh));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void KhachHang_Delete(string MaKH)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable KhachHang_GetTen()
        {
            using (var cmd = new SqlCommand("sp_KhachHang_GetTen", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable KhachHang_GetDSBaoTri()
        {
            using (var cmd = new SqlCommand("sp_KhachHang_GetDSBaoTri", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void BaoTri_SuaChua(SPKH Data)
        {
            using (var cmd = new SqlCommand("sp_BaoTri_SuaChua", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenSP", Data.TenSP));
                cmd.Parameters.Add(new SqlParameter("@TenKH", Data.TenKH));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", Data.TongTien));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@TenVatTu", Data.TenVatTu));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void BaoTri_BaoDuong(SPKH Data)
        {
            using (var cmd = new SqlCommand("sp_BaoTri_BaoDuong", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenSP", Data.TenSP));
                cmd.Parameters.Add(new SqlParameter("@TenKH", Data.TenKH));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable KhachHang_TraCuu ()
        {
            using (var cmd = new SqlCommand("sp_KhachHang_TraCuu", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void KhachHang_ThanhToan(int x, double y, string z)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_ThanhToan", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenSP", z));
                cmd.Parameters.Add(new SqlParameter("@MaKH", x));
                cmd.Parameters.Add(new SqlParameter("@ThanhToan", y));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
