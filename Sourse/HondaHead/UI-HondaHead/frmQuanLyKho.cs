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
    public partial class frmQuanLyKho : MyFormPage
    {
        public frmQuanLyKho()
        {
            InitializeComponent();
            this.pnl = panel1;
            DSSP();
            Binding();
        }
        private void DSSP()
        {
            try
            {
                tbSP.DataSource = SanPhamBUS.SanPham_GetAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Binding()
        {
            txtMaSP.DataBindings.Clear();
            txtMaSP.DataBindings.Add("Text", tbSP.DataSource, "MaSP");
            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", tbSP.DataSource, "TenSP");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", tbSP.DataSource, "SoLuong");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", tbSP.DataSource, "DonGia");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sp = new SanPham();
                sp.MaSP = int.Parse(txtMaSP.Text);
                sp.TenSP = txtTenSanPham.Text;
                sp.SoLuong = int.Parse(txtSoLuong.Text);
                sp.DonGia = double.Parse(txtDonGia.Text);
                SanPhamBUS.SanPham_Update(sp);
                MessageBox.Show("Cập nhật thành công!!");
                DSSP();
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
                SanPham sp = new SanPham();
                sp.MaSP = int.Parse(txtMaSP.Text);
                SanPhamBUS.SanPham_Delete(sp);
                MessageBox.Show("Xoá thành công!!");
                DSSP();
                Binding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
