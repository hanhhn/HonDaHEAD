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
    public class KhachHangBUS
    {
        private static readonly KhachHangDAL db= new KhachHangDAL();
        public static void KhachHang_Insert(KhachHang Data)
        {
            db.KhachHang_Insert(Data);
        }   
        public static DataTable KhachHang_DanhSach()
        {
            return db.KhachHang_DanhSach();
        }
        public static string KhachHang_GetGioiTinh(string TenKH)
        {
            return db.KhachHang_GetGioiTinh(TenKH);
        }
        public static int KhachHang_GetMaKH(string TenKH)
        {
            return db.KhachHang_GetMaKH(TenKH);
        }
        public static void KhachHang_Update(KhachHang Data)
        {
            db.KhachHang_Update(Data);
        }
        public static void KhachHang_Delete(string MaKH)
        {
            db.KhachHang_Delete(MaKH);
        }
        public static DataTable KhachHang_GetTen()
        {
            return db.KhachHang_GetTen();
        }
        public static DataTable KhachHang_GetDSBaoTri()
        {
            return db.KhachHang_GetDSBaoTri();
        }
        public static void BaoTri_BaoDuong(SPKH data)
        {
            db.BaoTri_BaoDuong(data);
        }
        public static void BaoTri_SuaChua(SPKH data)
        {
            db.BaoTri_SuaChua(data);
        }
        public static DataTable KhachHang_TraCuu()
        {
            return db.KhachHang_TraCuu();
        }
        public static void KhachHang_ThanhToan(int x, double y, string z)
        {
            db.KhachHang_ThanhToan(x,y,z);
        }
    }
}
