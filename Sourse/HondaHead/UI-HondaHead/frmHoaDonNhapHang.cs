using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATAHondaHead.Info;
using BUSSINESSHondaHead;

namespace UI_HondaHead
{
    public partial class frmHoaDonNhapHang : MyFormPage
    {
        public frmHoaDonNhapHang()
        {
            InitializeComponent();
            this.pnl = panel1;
            LoadDSNV();
            LoadDSSP();
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sp = new SanPham();
                sp.TenSP = txtTenSanPham.Text;
                sp.SoLuong = int.Parse(txtSoLuong.Text);
                sp.DonGia = double.Parse(txtDonGia.Text);
                if (cbLoaiSP.Text == "Xe")
                    sp.LoaiSP = 1;
                else sp.LoaiSP = 2;
                sp.LaiSuat = float.Parse(txtLaiSuat.Text);
                sp.TenNV = cbTenNV.Text;
                sp.NgayNhapHang = DateTime.Parse(dtpNgayLap.Text);
                SanPhamBUS.SanPham_NhapHang(sp);
                MessageBox.Show("Nhập hàng thành công!!");
                LoadDSSP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDSNV()
        {
            cbTenNV.DataSource=NhanVienBUS.NhanVien_DanhSach();
            cbTenNV.ValueMember="MaNV";
            cbTenNV.DisplayMember="TenNV";
        }
        private void LoadDSSP()
        {
            try
            {
                tbSP.DataSource = SanPhamBUS.SanPham_GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenSanPham.Text = "";
            txtSoLuong.Text = "";
            txtLaiSuat.Text = "";
            txtDonGia.Text = "";
        }
    }
}
