using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATAHondaHead;
using DATAHondaHead.DAL;
using DATAHondaHead.Info;

namespace BUSSINESSHondaHead
{
    public class NhanVienBUS
    {
        private static readonly NhanVienDAL db = new NhanVienDAL();
        public static void NhanVien_Insert(NhanVien Data)
        {
            db.NhanVien_Insert(Data);
        }
        public static DataTable NhanVien_DanhSach()
        {
            return db.NhanVien_DanhSach();
        }
        public static void NhanVien_Update(NhanVien Data)
        {
            db.NhanVien_Update(Data);
        }
        public static void NhanVien_Delete(string MaNV)
        {
            db.NhanVien_Delete(MaNV);
        }
        public static DataTable NhanVien_GetTen()
        {
            return db.NhanVien_GetTen();
        }
        public static int NhanVien_LayQuyen(string TenNV,string pass)
        {
            return db.NhanVien_LayQuyen(TenNV,pass);
        }
    }
}
