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
    public class NhanVienDAL:SqlDataProvider
    {
        public void NhanVien_Insert(NhanVien Data)
        {
            using (var cmd = new SqlCommand("sp_NhanVien_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenNV", Data.TenNV));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", Data.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@CMND", Data.CMND));
                cmd.Parameters.Add(new SqlParameter("@NoiCap",Data.NoiCap));
                cmd.Parameters.Add(new SqlParameter("@DiaChiThuongTru", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@NguyenQuan", Data.NguyenQuan));
                cmd.Parameters.Add(new SqlParameter("@HocVan", Data.HocVan));
                cmd.Parameters.Add(new SqlParameter("@SDT", Data.SDT));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", Data.NgaySinh));
                cmd.Parameters.Add(new SqlParameter("@NgayThamGia", Data.NgayThamGia));
                cmd.Parameters.Add(new SqlParameter("@ChucVu", Data.ChucVu));
                cmd.Parameters.Add(new SqlParameter("@Password", Data.Password));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable NhanVien_DanhSach()
        {
            using (var cmd=new SqlCommand("sp_NhanVien_DanhSach",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void NhanVien_Update(NhanVien Data)
        {
            using (var cmd = new SqlCommand("sp_NhanVien_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNV", Data.MaNV));
                cmd.Parameters.Add(new SqlParameter("@TenNV", Data.TenNV));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", Data.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@CMND", Data.CMND));
                cmd.Parameters.Add(new SqlParameter("@NoiCap", Data.NoiCap));
                cmd.Parameters.Add(new SqlParameter("@DiaChiThuongTru", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@NguyenQuan", Data.NguyenQuan));
                cmd.Parameters.Add(new SqlParameter("@HocVan", Data.HocVan));
                cmd.Parameters.Add(new SqlParameter("@SDT", Data.SDT));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", Data.NgaySinh));
                cmd.Parameters.Add(new SqlParameter("@NgayThamGia", Data.NgayThamGia));
                cmd.Parameters.Add(new SqlParameter("@ChucVu", Data.ChucVu));
                cmd.Parameters.Add(new SqlParameter("@Password", Data.Password));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void NhanVien_Delete(string MaNV)
        {
            using (var cmd=new SqlCommand("sp_NhanVien_Delete",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable NhanVien_GetTen()
        {
            using (var cmd = new SqlCommand("sp_NhanVien_GetTen", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public int NhanVien_LayQuyen(string TenNV,string pass)
        {
            using (var cmd = new SqlCommand("sp_NhanVien_LayQuyen", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenNV", TenNV));
                cmd.Parameters.Add(new SqlParameter("@Password", pass));
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
