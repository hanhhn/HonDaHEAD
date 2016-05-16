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
    public class SanPhamDAL:SqlDataProvider
    {
        public void SanPham_NhapHang(SanPham Data)
        {
            using (var cmd = new SqlCommand("sp_SanPham_NhapHang", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenSP", Data.TenSP));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.Parameters.Add(new SqlParameter("@LoaiSanPham", Data.LoaiSP));
                cmd.Parameters.Add(new SqlParameter("@LaiSuat", Data.LaiSuat));
                cmd.Parameters.Add(new SqlParameter("@TenNV", Data.TenNV));
                cmd.Parameters.Add(new SqlParameter("@NgayLap", Data.NgayNhapHang));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable SanPham_GetAll()
        {
            using(var cmd=new SqlCommand("sp_SanPham_GetAll",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void SanPham_BanHang(SPKH Data)
        {
            using (var cmd = new SqlCommand("sp_SanPham_MuaHang", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenKH", Data.TenKH));
                cmd.Parameters.Add(new SqlParameter("@TenSP", Data.TenSP));
                cmd.Parameters.Add(new SqlParameter("@TenNV", Data.TenNV));
                cmd.Parameters.Add(new SqlParameter("@NgayMua", Data.NgayMua));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.Parameters.Add(new SqlParameter("@ThanhToan", Data.ThanhToan));
                cmd.Parameters.Add(new SqlParameter("@ConThieu", Data.ConThieu));
                cmd.Parameters.Add(new SqlParameter("@TongTien", Data.TongTien));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable SanPham_GetGia()
        {
            using(var cmd=new SqlCommand("sp_SanPham_GetGia",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void SanPham_Update(SanPham Data)
        {
            using (var cmd = new SqlCommand("sp_SanPham_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaSP", Data.MaSP));
                cmd.Parameters.Add(new SqlParameter("@TenSP", Data.TenSP));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void SanPham_Delete(SanPham Data)
        {
            using (var cmd = new SqlCommand("sp_SanPham_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaSP", Data.MaSP));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable NoiDungSC_GetAll()
        {
            using (var cmd = new SqlCommand("sp_NoiDungSC_GetAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable SanPham_GetVatTu()
        {
            using (var cmd = new SqlCommand("sp_SanPham_GetVatTu", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
