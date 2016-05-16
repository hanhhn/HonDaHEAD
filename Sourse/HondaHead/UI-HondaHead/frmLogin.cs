using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using BUSSINESSHondaHead;

namespace UI_HondaHead
{
    public partial class frmLogin : SplashScreen
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if(user=="s" && pass=="s")
            {
                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                int i = NhanVienBUS.NhanVien_LayQuyen(user, pass);
                if (i == 1)
                {
                    MainForm frm = new MainForm(1);
                    frm.Show();
                    this.Hide();
                }
                else
                    if (i == 2)
                    {
                        MainForm frm = new MainForm(2);
                        frm.Show();
                        this.Hide();
                    }
                    else
                        if (i == 3)
                        {
                            MainForm frm = new MainForm(3);
                            frm.Show();
                            this.Hide();
                        }
                        else
                            if (i == 4)
                            {
                                MainForm frm = new MainForm(4);
                                frm.Show();
                                this.Hide();
                            }
                            else
                                MessageBox.Show("Tai khoan hoac mat khau khong chinh xac!!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}