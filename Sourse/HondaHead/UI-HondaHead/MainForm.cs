using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevComponents.DotNetBar;
using System.Threading;

namespace UI_HondaHead
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            btnQuanLyKH.Enabled = true;
            btnBaoDuong.Enabled = true;
            btnTraCuuNV.Enabled = true;
            btnTraCuuKH.Enabled = true;
            btnNhapHang.Enabled = true;
            btnXuatHang.Enabled = true;
            btnBaoCaoTon.Enabled = true;
            btnDoanhSo.Enabled = true;
            btnQuanLyKho.Enabled = true;
            btnNhanVien.Enabled = true;
           
        }
        public MainForm(int j)
        {
            InitializeComponent();
            // Thread t = new Thread(new ThreadStart(SplashScreen));
            // t.Start();
            // Thread.Sleep(3000);
            //  t.Abort();
            if (j == 2)
            {
                btnNhapHang.Enabled=true;;
                btnXuatHang.Enabled=true;
                btnTraCuuKH.Enabled = true;
            }
            if (j == 1)
            {
                btnQuanLyKH.Enabled = true;
                btnBaoDuong.Enabled = true;
                btnDoanhSo.Enabled = true;
                btnXuatHang.Enabled = true;
            }
            if(j==3)
            {
                btnQuanLyKho.Enabled = true;
                btnBaoCaoTon.Enabled = true;
            }
            if(j==4)
            {
                btnNhanVien.Enabled = true;
                btnTraCuuNV.Enabled = true;
                btnBaoCaoTon.Enabled = true;
                btnDoanhSo.Enabled = true;
            }
        }
        public bool CheckOpenTabs(string name)
        {
            for (int i = 0; i < superTabControl1.Tabs.Count; i++)
            {
                if (superTabControl1.Tabs[i].Text == name)
                {
                    superTabControl1.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }
        
        private void btnQuanLyKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Quản Lý Khách Hàng"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Quản Lý Khách Hàng");
                frmQuanLyKH frm = new frmQuanLyKH();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }

        private void btnBaoDuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Bảo Dưỡng"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Bảo Dưỡng");
                frmBaoDuong frm = new frmBaoDuong();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }

        private void btnTraCuuKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Tra Cứu Khách Hàng"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Tra Cứu Khách Hàng");
                frmTraCuuKH frm = new frmTraCuuKH();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }

        private void btnTraCuuNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Tra Cứu Nhân Viên"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Tra Cứu Nhân Viên");
                frmTraCuuNV frm = new frmTraCuuNV();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }

        private void btnNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Nhập Hàng"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Nhập Hàng");
                frmHoaDonNhapHang frm = new frmHoaDonNhapHang();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;

        }

        private void btnXuatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Bán Hàng"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Bán Hàng");
                frmHoaDonXuatHang frm = new frmHoaDonXuatHang();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }

        private void btnDoanhSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Báo cáo doanh số"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Báo cáo doanh số");
                frmDoanhSo frm = new frmDoanhSo();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }

        private void btnBaoCaoTon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Báo cáo tồn"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Báo cáo tồn");
                frmBaoCaoTon frm = new frmBaoCaoTon();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Quản Lý Nhân Viên"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Quản Lý Nhân Viên");
                frmQuanLyNV frm = new frmQuanLyNV();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }


        private void btnQuanLyKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Quản Lý Kho"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Quản Lý Kho");
                frmQuanLyKho frm = new frmQuanLyKho();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}