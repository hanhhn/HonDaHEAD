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
    public partial class frmTraCuuKH : MyFormPage
    {
        public frmTraCuuKH()
        {
            InitializeComponent();
            this.pnl = panel1;
            DSTraCuu();
            Binding();
        }
        private void DSTraCuu()
        {
            try
            {
                tbTraCuuKH.DataSource = KhachHangBUS.KhachHang_TraCuu();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Binding()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", tbTraCuuKH.DataSource, "MaKH");
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", tbTraCuuKH.DataSource, "TenKH");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", tbTraCuuKH.DataSource, "CMND");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", tbTraCuuKH.DataSource, "DiaChi");
            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", tbTraCuuKH.DataSource, "SDT");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", tbTraCuuKH.DataSource, "NgaySinh");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", tbTraCuuKH.DataSource, "Email");
            txtTenSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("Text", tbTraCuuKH.DataSource, "TenSP");
            txtTienNo.DataBindings.Clear();
            txtTienNo.DataBindings.Add("Text", tbTraCuuKH.DataSource, "ConThieu");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            try
            { 
                //int i=KhachHangBUS.KhachHang_GetMaKH(txtTenKH.Text);
                kh.MaKH = int.Parse(txtMaKH.Text);
                kh.TenKhachHang = txtTenKH.Text;
                kh.CMND = txtCMND.Text;
                kh.SDT = txtSoDienThoai.Text;
                kh.Email = txtEmail.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
                KhachHangBUS.KhachHang_Update(kh);
                MessageBox.Show("Sửa Thông Tin Thành Công!");
                DSTraCuu();
                Binding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtMaKH.Text);
                double y = double.Parse(txtThanhToan.Text);
                KhachHangBUS.KhachHang_ThanhToan(x, y, txtTenSP.Text);
                KhachHang kh = new KhachHang();
                MessageBox.Show("Thanh Toán Thành Công!");
                DSTraCuu();
                Binding();
                txtThanhToan.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
