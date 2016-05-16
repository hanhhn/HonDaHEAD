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
    public class SanPhamBUS
    {
        private static readonly SanPhamDAL db = new SanPhamDAL();
        public static void SanPham_NhapHang(SanPham Data)
        {
            db.SanPham_NhapHang(Data);
        }
        public static DataTable SanPham_GetAll()
        {
            return db.SanPham_GetAll();
        }
        public static void SanPham_BanHang(SPKH Data)
        {
            db.SanPham_BanHang(Data);
        }
        public static DataTable SanPham_GetGia()
        {
            return db.SanPham_GetGia();
        }
        public static void SanPham_Update(SanPham Data)
        {
            db.SanPham_Update(Data);
        }
        public static void SanPham_Delete(SanPham Data)
        {
            db.SanPham_Delete(Data);
        }
        public static DataTable NoiDungSC_GetAll()
        {
            return db.NoiDungSC_GetAll();
        }
        public static DataTable SanPham_GetVatTu()
        {
            return db.SanPham_GetVatTu();
        }
    }
}
