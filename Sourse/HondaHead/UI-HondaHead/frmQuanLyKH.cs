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
using DATAHondaHead;

namespace UI_HondaHead
{
    public partial class frmQuanLyKH : MyFormPage
    {
        public int i;
        public frmQuanLyKH()
        {
            InitializeComponent();
            this.pnl = panel1;
            txtMaKH.Text = "";
            LoadDSKH();
            Binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang kh=new KhachHang();
            try
            {
                kh.TenKhachHang = txtTenKH.Text;
                if (rbtNam.Checked == true)
                {
                    kh.GioiTinh = "Nam";
                }
                else if (rbtNu.Checked == true)
                {
                    kh.GioiTinh = "Nữ";
                }
                else
                    kh.GioiTinh = "Khác";
                kh.CMND = txtCMND.Text;
                kh.SDT = txtSoDienThoai.Text;
                kh.Email = txtEmail.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
                KhachHangBUS.KhachHang_Insert(kh);
                MessageBox.Show("Thêm Khách Hàng Thành Công!");
                LoadDSKH();
                Binding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                SqlDataProvider.connection.Close();
            }

        }
        private void LoadDSKH()
        {
            try
            {
                tbKhachHang.DataSource = KhachHangBUS.KhachHang_DanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Binding()
        {
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", tbKhachHang.DataSource, "TenKH");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", tbKhachHang.DataSource, "CMND");
            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", tbKhachHang.DataSource, "SDT");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", tbKhachHang.DataSource, "DiaChi");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", tbKhachHang.DataSource, "Email");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", tbKhachHang.DataSource, "NgaySinh");
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", tbKhachHang.DataSource, "MaKH");
            string s = KhachHangBUS.KhachHang_GetGioiTinh(txtTenKH.Text);
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", tbKhachHang.DataSource, "GioiTinh");
            if (s == "Nam")
            {
                rbtNam.Checked = true;
            }
            else if (s == "Nu")
            {
                rbtNu.Checked = true;
            }
            else rbtKhac.Checked = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            try
            {
                i = int.Parse(txtMaKH.Text);
                //int i=KhachHangBUS.KhachHang_GetMaKH(txtTenKH.Text);
                kh.MaKH = i;
                kh.TenKhachHang = txtTenKH.Text;
                if (rbtNam.Checked == true)
                {
                    kh.GioiTinh = "Nam";
                }
                else if (rbtNu.Checked == true)
                {
                    kh.GioiTinh = "Nữ";
                }
                else
                    kh.GioiTinh = "Khác";
                kh.CMND = txtCMND.Text;
                kh.SDT = txtSoDienThoai.Text;
                kh.Email = txtEmail.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
                KhachHangBUS.KhachHang_Update(kh);
                MessageBox.Show("Sửa Thông Tin Thành Công!");
                LoadDSKH();
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
                KhachHangBUS.KhachHang_Delete(txtMaKH.Text);
                LoadDSKH();
                Binding();
                MessageBox.Show("Xoá Thành Công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            txtGioiTinh.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text="";
            txtSoDienThoai.Text="";
            txtCMND.Text="";
        }
    }
}
