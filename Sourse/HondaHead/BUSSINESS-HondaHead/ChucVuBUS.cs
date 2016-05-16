using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAHondaHead;
using DATAHondaHead.DAL;
using DATAHondaHead.Info;
using System.Data;

namespace BUSSINESSHondaHead
{
    public class ChucVuBUS
    {
        private static readonly ChucVuDAL db = new ChucVuDAL();
        public static DataTable ChucVu_Get()
        {
            return db.ChucVu_Get();
        }
        public static double ChucVu_GetLuong(int MaChucVu)
        {
            return db.ChucVu_getLuong(MaChucVu);
        }
        public static string ChucVu_GetTen(int MaChucVu)
        {
            return db.ChucVu_GetTen(MaChucVu);
        }
    }
}
