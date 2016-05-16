using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSSINESSHondaHead;
using DATAHondaHead.Info;

namespace UI_HondaHead
{
    public partial class frmQuanLyNV : MyFormPage
    {
        DataTable DSChucVu;
        public frmQuanLyNV()
        {
            InitializeComponent();
            this.pnl = panel1;
            cbGioiTinh.DataSource = new List<string>(){"Nam", "Nữ", "Khác"};
            LoadDSChucVu();
            LoadDSNV();
            Binding();
        }
        private void LoadDSChucVu()
        {
            try
            {
                DSChucVu = ChucVuBUS.ChucVu_Get();
                cbViTri.DataSource = DSChucVu;
                cbViTri.DisplayMember = "ChucVu";
                cbViTri.ValueMember = "MaChucVu";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDSNV()
        {
            try
            {
                tbNV.DataSource = NhanVienBUS.NhanVien_DanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien();
                nv.TenNV = txtTenNV.Text;
                nv.GioiTinh = cbGioiTinh.Text;
                nv.CMND = txtCMND.Text;
                nv.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
                nv.NoiCap = txtNoiCap.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.NguyenQuan = txtNguyenQuan.Text;
                nv.NgayThamGia = DateTime.Parse(dtpNgayVaoLam.Text);
                nv.HocVan = txtHocVan.Text;
                nv.ChucVu = cbViTri.Text;
                nv.SDT = txtSoDienThoai.Text;
                nv.Email = txtEmail.Text;
                NhanVienBUS.NhanVien_Insert(nv);
                MessageBox.Show("Thêm nhân viên thành công!!");
                LoadDSNV();
                Binding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbViTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLuongCoBan.Text = DSChucVu.Rows[cbViTri.SelectedIndex]["LuongCoBan"].ToString();
        }
        private void Binding()
        {
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", tbNV.DataSource, "TenNV");
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Text", tbNV.DataSource, "GioiTinh");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", tbNV.DataSource, "CMND");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", tbNV.DataSource, "NgaySinh");
            txtNoiCap.DataBindings.Clear();
            txtNoiCap.DataBindings.Add("Text", tbNV.DataSource, "NoiCap");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", tbNV.DataSource, "DiaChiThuongTru");
            txtNguyenQuan.DataBindings.Clear();
            txtNguyenQuan.DataBindings.Add("Text", tbNV.DataSource, "NguyenQuan");
            dtpNgayVaoLam.DataBindings.Clear();
            dtpNgayVaoLam.DataBindings.Add("Text", tbNV.DataSource, "NgayThamGia");
            txtHocVan.DataBindings.Clear();
            txtHocVan.DataBindings.Add("Text", tbNV.DataSource, "HocVan");
            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", tbNV.DataSource, "SDT");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", tbNV.DataSource, "Email");
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", tbNV.DataSource, "MaNV");
            txtMaChucVu.DataBindings.Clear();
            txtMaChucVu.DataBindings.Add("Text", tbNV.DataSource, "MaChucVu");
            if(txtMaChucVu.Text!="")
            {
                cbViTri.Text = ChucVuBUS.ChucVu_GetTen(int.Parse(txtMaChucVu.Text));
                txtLuongCoBan.Text = Convert.ToString(ChucVuBUS.ChucVu_GetLuong(int.Parse("4")));
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = int.Parse(txtMaNV.Text);
                nv.TenNV = txtTenNV.Text;
                nv.GioiTinh = cbGioiTinh.Text;
                nv.CMND = txtCMND.Text;
                nv.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
                nv.NoiCap = txtNoiCap.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.NguyenQuan = txtNguyenQuan.Text;
                nv.NgayThamGia = DateTime.Parse(dtpNgayVaoLam.Text);
                nv.HocVan = txtHocVan.Text;
                nv.ChucVu = cbViTri.Text;
                nv.SDT = txtSoDienThoai.Text;
                nv.Email = txtEmail.Text;
                NhanVienBUS.NhanVien_Update(nv);
                MessageBox.Show("Thay đổi thông tin nhân viên thành công!!");
                LoadDSNV();
                Binding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienBUS.NhanVien_Delete(txtMaNV.Text);
                LoadDSNV();
                Binding();
                MessageBox.Show("Xoá Thành Công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
