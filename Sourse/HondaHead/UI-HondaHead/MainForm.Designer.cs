namespace UI_HondaHead
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnQuanLyKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoDuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraCuuKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraCuuNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoanhSo = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoTon = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnChamCong = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnQuanLyKH,
            this.btnBaoDuong,
            this.btnTraCuuKH,
            this.btnTraCuuNV,
            this.btnNhapHang,
            this.btnXuatHang,
            this.btnDoanhSo,
            this.btnBaoCaoTon,
            this.btnNhanVien,
            this.btnQuanLyKho,
            this.btnChamCong});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbon.Size = new System.Drawing.Size(1910, 171);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnQuanLyKH
            // 
            this.btnQuanLyKH.Caption = "          Quản Lý                  Khách Hàng       ";
            this.btnQuanLyKH.Enabled = false;
            this.btnQuanLyKH.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyKH.Glyph")));
            this.btnQuanLyKH.Id = 1;
            this.btnQuanLyKH.Name = "btnQuanLyKH";
            this.btnQuanLyKH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQuanLyKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyKH_ItemClick);
            // 
            // btnBaoDuong
            // 
            this.btnBaoDuong.Caption = "    Bảo Dưỡng                       ";
            this.btnBaoDuong.Enabled = false;
            this.btnBaoDuong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBaoDuong.Glyph")));
            this.btnBaoDuong.Id = 2;
            this.btnBaoDuong.Name = "btnBaoDuong";
            this.btnBaoDuong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBaoDuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoDuong_ItemClick);
            // 
            // btnTraCuuKH
            // 
            this.btnTraCuuKH.Caption = "        Khách Hàng                              ";
            this.btnTraCuuKH.Enabled = false;
            this.btnTraCuuKH.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTraCuuKH.Glyph")));
            this.btnTraCuuKH.Id = 3;
            this.btnTraCuuKH.Name = "btnTraCuuKH";
            this.btnTraCuuKH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTraCuuKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraCuuKH_ItemClick);
            // 
            // btnTraCuuNV
            // 
            this.btnTraCuuNV.Caption = "      Nhân Viên                              ";
            this.btnTraCuuNV.Enabled = false;
            this.btnTraCuuNV.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTraCuuNV.Glyph")));
            this.btnTraCuuNV.Id = 4;
            this.btnTraCuuNV.Name = "btnTraCuuNV";
            this.btnTraCuuNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTraCuuNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraCuuNV_ItemClick);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Caption = "       Nhập Hàng                              ";
            this.btnNhapHang.Enabled = false;
            this.btnNhapHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhapHang.Glyph")));
            this.btnNhapHang.Id = 5;
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhapHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapHang_ItemClick);
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.Caption = "       Bán Hàng                              ";
            this.btnXuatHang.Enabled = false;
            this.btnXuatHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXuatHang.Glyph")));
            this.btnXuatHang.Id = 6;
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnXuatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatHang_ItemClick);
            // 
            // btnDoanhSo
            // 
            this.btnDoanhSo.Caption = "        Doanh Số                              ";
            this.btnDoanhSo.Enabled = false;
            this.btnDoanhSo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDoanhSo.Glyph")));
            this.btnDoanhSo.Id = 7;
            this.btnDoanhSo.Name = "btnDoanhSo";
            this.btnDoanhSo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDoanhSo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoanhSo_ItemClick);
            // 
            // btnBaoCaoTon
            // 
            this.btnBaoCaoTon.Caption = "       Báo Cáo Tồn                             ";
            this.btnBaoCaoTon.Enabled = false;
            this.btnBaoCaoTon.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoTon.Glyph")));
            this.btnBaoCaoTon.Id = 8;
            this.btnBaoCaoTon.Name = "btnBaoCaoTon";
            this.btnBaoCaoTon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBaoCaoTon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoCaoTon_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "        Nhân viên                              ";
            this.btnNhanVien.Enabled = false;
            this.btnNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Glyph")));
            this.btnNhanVien.Id = 9;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnQuanLyKho
            // 
            this.btnQuanLyKho.Caption = "       Quản Lý Kho                             ";
            this.btnQuanLyKho.Enabled = false;
            this.btnQuanLyKho.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyKho.Glyph")));
            this.btnQuanLyKho.Id = 10;
            this.btnQuanLyKho.Name = "btnQuanLyKho";
            this.btnQuanLyKho.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQuanLyKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyKho_ItemClick);
            // 
            // btnChamCong
            // 
            this.btnChamCong.Id = 12;
            this.btnChamCong.Name = "btnChamCong";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Khách hàng    ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQuanLyKH);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "                            ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBaoDuong);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Tra cứu    ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTraCuuKH);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTraCuuNV);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Hoá đơn    ";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnNhapHang);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnXuatHang);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.ribbonPage4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo    ";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDoanhSo);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnBaoCaoTon);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9,
            this.ribbonPageGroup10});
            this.ribbonPage5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage5.Image")));
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Quản lý    ";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnQuanLyKho);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 1048);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1910, 31);
            // 
            // superTabControl1
            // 
            this.superTabControl1.CloseButtonOnTabsVisible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.Location = new System.Drawing.Point(0, 171);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(1910, 877);
            this.superTabControl1.TabFont = new System.Drawing.Font("Tahoma", 7.8F);
            this.superTabControl1.TabIndex = 2;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.pictureBox1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 28);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(1910, 849);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::UI_HondaHead.Properties.Resources.New_Honda_NSX_Wallpaper_HD_1765;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1910, 849);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.CloseButtonVisible = false;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "Welcome!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 1079);
            this.Controls.Add(this.superTabControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Cửa Hàng HONDA HEAD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyKH;
        private DevExpress.XtraBars.BarButtonItem btnBaoDuong;
        private DevExpress.XtraBars.BarButtonItem btnTraCuuKH;
        private DevExpress.XtraBars.BarButtonItem btnTraCuuNV;
        private DevExpress.XtraBars.BarButtonItem btnNhapHang;
        private DevExpress.XtraBars.BarButtonItem btnXuatHang;
        private DevExpress.XtraBars.BarButtonItem btnDoanhSo;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoTon;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevExpress.XtraBars.BarButtonItem btnChamCong;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}