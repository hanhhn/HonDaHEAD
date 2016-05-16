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
    public partial class frmHoaDonXuatHang : MyFormPage
    {
        public frmHoaDonXuatHang()
        {
            InitializeComponent();
            this.pnl = panel1;
            DSSP();
            Binding();
            LoadKH();
            LoadNV();
        }
        private void DSSP()
        {
            try
            {
                tbsp.DataSource = SanPhamBUS.SanPham_GetGia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Binding()
        {
            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", tbsp.DataSource, "TenSP");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", tbsp.DataSource, "DonGia");
        }
        private void LoadKH()
        {
            try
            {
                cbKH.DataSource = KhachHangBUS.KhachHang_GetTen();
                cbKH.DisplayMember = "TenKH";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadNV()
        {
            try
            {
                cbNV.DataSource = NhanVienBUS.NhanVien_GetTen();
                cbNV.DisplayMember = "TenNV";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLap_Click(object sender, EventArgs e)
        {
            try
            {
                SPKH sp = new SPKH();
                sp.TenKH = cbKH.Text;
                sp.TenSP = txtTenSanPham.Text;
                sp.TenNV = cbNV.Text;
                sp.NgayMua = DateTime.Parse(dtpNgayMua.Text);
                sp.SoLuong = int.Parse(txtSoLuong.Text);
                sp.DonGia = double.Parse(txtDonGia.Text);
                sp.TongTien = double.Parse(txtTongTien.Text);
                sp.ThanhToan = double.Parse(txtThanhToan.Text);
                sp.ConThieu = double.Parse(txtConThieu.Text);
                SanPhamBUS.SanPham_BanHang(sp);
                MessageBox.Show("Bán sản phẩm thành công!!");
                Binding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            int i=int.Parse(txtSoLuong.Text);
            double j=double.Parse(txtDonGia.Text);
            txtTongTien.Text = (i * j).ToString();
        }

        private void txtThanhToan_TextChanged(object sender, EventArgs e)
        {
            double i = double.Parse(txtTongTien.Text);
            double j = double.Parse(txtThanhToan.Text);
            txtConThieu.Text = (i - j).ToString();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenSanPham.Text = "";
            txtSoLuong.Text = "0";
            txtThanhToan.Text = "0";
        }
    }
}
