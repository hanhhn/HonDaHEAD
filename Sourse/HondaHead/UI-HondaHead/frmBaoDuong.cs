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
    public partial class frmBaoDuong : MyFormPage
    {
        public frmBaoDuong()
        {
            InitializeComponent();
            this.pnl = panel1;
            LoadNDSC();
            LoadVatTu();
            LoadDSBaoTri();
            Binding();
        }
        private void LoadNDSC()
        {
            try
            {
                cbNoiDungSuaChua.DataSource=SanPhamBUS.NoiDungSC_GetAll();
                cbNoiDungSuaChua.DisplayMember = "NoiDungSC";
                cbNoiDungSuaChua.ValueMember = "MaSC";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadVatTu()
        {
            try
            {
                cbVatTuPhuTung.DataSource = SanPhamBUS.SanPham_GetVatTu();
                cbVatTuPhuTung.DisplayMember = "TenSP";
                cbVatTuPhuTung.ValueMember = "MaSP";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDSBaoTri()
        {
            try
            {
                tbBaoDuong.DataSource = KhachHangBUS.KhachHang_GetDSBaoTri();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Binding()
        {
            txtTenKhachHang.DataBindings.Clear();
            txtTenKhachHang.DataBindings.Add("Text", tbBaoDuong.DataSource, "TenKH");
            txtSanPham.DataBindings.Clear();
            txtSanPham.DataBindings.Add("Text", tbBaoDuong.DataSource, "TenSP");
            txtSoLanBaoTri.DataBindings.Clear();
            txtSoLanBaoTri.DataBindings.Add("Text", tbBaoDuong.DataSource, "SoLanBaoTri");
            if(txtSoLanBaoTri.Text!="")
            {
                if (int.Parse(txtSoLanBaoTri.Text) >= 5)
                {
                    btnBaoDuong.Enabled = false;
                    btnSuaChua.Enabled = true;
                    cbNoiDungSuaChua.Enabled = true;
                    cbVatTuPhuTung.Enabled = true;
                    txtSoLuong.Enabled = true;
                    dtpNgayBaoDuong.Enabled = true;
                }
                else
                {
                    btnBaoDuong.Enabled = true;
                    btnSuaChua.Enabled = false;
                    cbNoiDungSuaChua.Enabled = false;
                    cbVatTuPhuTung.Enabled = false;
                    txtSoLuong.Enabled = false;
                    dtpNgayBaoDuong.Enabled = false;
                }
            }
        }
        private void cbNoiDungSuaChua_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable x=SanPhamBUS.NoiDungSC_GetAll();
            txtTienCong.Text = x.Rows[cbNoiDungSuaChua.SelectedIndex]["TienCong"].ToString();
        }

        private void cbVatTuPhuTung_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable x = SanPhamBUS.SanPham_GetVatTu();
            txtDonGia.Text = x.Rows[cbVatTuPhuTung.SelectedIndex]["DonGia"].ToString();
            labelSoLuongTon.Text = x.Rows[cbVatTuPhuTung.SelectedIndex]["SoLuong"].ToString();
        }

        private void btnBaoDuong_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtSoLanBaoTri.Text) >= 5)
            {
                MessageBox.Show("Đã quá số lần bảo trì, hãy chọn quá trình sữa chữa!");
            }
            else
            {
                try
                {
                    SPKH sp = new SPKH();
                    sp.TenKH = txtTenKhachHang.Text;
                    sp.TenSP = txtSanPham.Text;
                    KhachHangBUS.BaoTri_BaoDuong(sp);
                    MessageBox.Show("Bảo trì thành công!");
                    LoadDSBaoTri();
                    Binding();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tbBaoDuong_Click(object sender, EventArgs e)
        {
            DataTable x = KhachHangBUS.KhachHang_GetDSBaoTri();
            txtSoLanBaoTri.DataBindings.Clear();
            txtSoLanBaoTri.DataBindings.Add("Text", tbBaoDuong.DataSource, "SoLanBaoTri");
            if (txtSoLanBaoTri.Text != "")
            {
                if (int.Parse(txtSoLanBaoTri.Text) >= 5)
                {
                    btnBaoDuong.Enabled = false;
                    btnSuaChua.Enabled = true;
                    cbNoiDungSuaChua.Enabled = true;
                    cbVatTuPhuTung.Enabled = true;
                    txtSoLuong.Enabled = true;
                    dtpNgayBaoDuong.Enabled = true;
                }
                else
                {
                    btnBaoDuong.Enabled = true;
                    btnSuaChua.Enabled = false;
                    cbNoiDungSuaChua.Enabled = false;
                    cbVatTuPhuTung.Enabled = false;
                    txtSoLuong.Enabled = false;
                    dtpNgayBaoDuong.Enabled = false;
                }
            }

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            int i=int.Parse(txtSoLuong.Text);
            double j=double.Parse(txtDonGia.Text);
            double k = double.Parse(txtTienCong.Text);
            txtThanhTien.Text = (i * j+k).ToString();
        }

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            try
            {
                SPKH sp = new SPKH();
                sp.TenKH = txtTenKhachHang.Text;
                sp.TenSP = txtSanPham.Text;
                sp.TongTien = double.Parse(txtThanhTien.Text);
                sp.SoLuong = int.Parse(txtSoLuong.Text);
                sp.TenVatTu = cbVatTuPhuTung.Text;
                KhachHangBUS.BaoTri_SuaChua(sp);
                MessageBox.Show("Sửa chữa thành công!");
                LoadDSBaoTri();
                Binding();
                DataTable x = SanPhamBUS.SanPham_GetVatTu();;
                labelSoLuongTon.Text = x.Rows[cbVatTuPhuTung.SelectedIndex]["SoLuong"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
