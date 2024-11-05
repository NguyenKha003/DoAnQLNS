namespace QLNHANSU
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDanToc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonGiao = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTangCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUngLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiDB = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanTocN = new DevExpress.XtraBars.BarButtonItem();
            this.btnCongTy = new DevExpress.XtraBars.BarButtonItem();
            this.btnBoPhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.Turquoise;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ribbon.ForeColor = System.Drawing.Color.Silver;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDanToc,
            this.btnTonGiao,
            this.barButtonItem1,
            this.btnNhanVien,
            this.btnPhongBan,
            this.btnLoaiCa,
            this.btnLoaiCong,
            this.btnPhucap,
            this.btnTangCa,
            this.btnUngLuong,
            this.btnBangCong,
            this.btnBangLuong,
            this.btnDoiMatKhau,
            this.btnBackup,
            this.btnPhucHoiDB,
            this.btnThoat,
            this.btnDanTocN,
            this.btnCongTy,
            this.btnBoPhan,
            this.btnChucVu,
            this.barButtonItem3,
            this.btnDangXuat});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 31;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(1249, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnDanToc
            // 
            this.btnDanToc.Id = 24;
            this.btnDanToc.Name = "btnDanToc";
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.Caption = "Tôn giáo";
            this.btnTonGiao.Id = 2;
            this.btnTonGiao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTonGiao.ImageOptions.SvgImage")));
            this.btnTonGiao.Name = "btnTonGiao";
            this.btnTonGiao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTonGiao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTonGiao_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.AccessibleDescription = "btnTrinhDo";
            this.barButtonItem1.Caption = "Trình độ";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Id = 4;
            this.btnNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhanVien.ImageOptions.SvgImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Caption = "Phòng ban";
            this.btnPhongBan.Id = 5;
            this.btnPhongBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhongBan.ImageOptions.SvgImage")));
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhongBan_ItemClick);
            // 
            // btnLoaiCa
            // 
            this.btnLoaiCa.Caption = "Loại ca";
            this.btnLoaiCa.Id = 10;
            this.btnLoaiCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaiCa.ImageOptions.SvgImage")));
            this.btnLoaiCa.Name = "btnLoaiCa";
            // 
            // btnLoaiCong
            // 
            this.btnLoaiCong.Caption = "Loại Công";
            this.btnLoaiCong.Id = 11;
            this.btnLoaiCong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaiCong.ImageOptions.SvgImage")));
            this.btnLoaiCong.Name = "btnLoaiCong";
            // 
            // btnPhucap
            // 
            this.btnPhucap.Caption = "Phụ Cấp";
            this.btnPhucap.Id = 12;
            this.btnPhucap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucap.ImageOptions.SvgImage")));
            this.btnPhucap.Name = "btnPhucap";
            // 
            // btnTangCa
            // 
            this.btnTangCa.Caption = "Tăng ca";
            this.btnTangCa.Id = 13;
            this.btnTangCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTangCa.ImageOptions.SvgImage")));
            this.btnTangCa.Name = "btnTangCa";
            // 
            // btnUngLuong
            // 
            this.btnUngLuong.Caption = "Ứng lương";
            this.btnUngLuong.Id = 14;
            this.btnUngLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUngLuong.ImageOptions.SvgImage")));
            this.btnUngLuong.Name = "btnUngLuong";
            // 
            // btnBangCong
            // 
            this.btnBangCong.Caption = "Bảng công";
            this.btnBangCong.Id = 15;
            this.btnBangCong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBangCong.ImageOptions.SvgImage")));
            this.btnBangCong.Name = "btnBangCong";
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.Caption = "Bảng lương";
            this.btnBangLuong.Id = 16;
            this.btnBangLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBangLuong.ImageOptions.SvgImage")));
            this.btnBangLuong.Name = "btnBangLuong";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 17;
            this.btnDoiMatKhau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoiMatKhau.ImageOptions.SvgImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu dữ liệu";
            this.btnBackup.Id = 18;
            this.btnBackup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBackup.ImageOptions.SvgImage")));
            this.btnBackup.Name = "btnBackup";
            // 
            // btnPhucHoiDB
            // 
            this.btnPhucHoiDB.Caption = "Phục hồi dữ Liệu";
            this.btnPhucHoiDB.Id = 19;
            this.btnPhucHoiDB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoiDB.ImageOptions.SvgImage")));
            this.btnPhucHoiDB.Name = "btnPhucHoiDB";
            // 
            // btnThoat
            // 
            this.btnThoat.AllowRightClickInMenu = false;
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 20;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // btnDanTocN
            // 
            this.btnDanTocN.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.btnDanTocN.Caption = "Dân tộc";
            this.btnDanTocN.Id = 23;
            this.btnDanTocN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDanTocN.ImageOptions.SvgImage")));
            this.btnDanTocN.Name = "btnDanTocN";
            this.btnDanTocN.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanTocN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanTocN_ItemClick);
            // 
            // btnCongTy
            // 
            this.btnCongTy.Caption = "Công ty";
            this.btnCongTy.Id = 25;
            this.btnCongTy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCongTy.ImageOptions.SvgImage")));
            this.btnCongTy.Name = "btnCongTy";
            this.btnCongTy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCongTy_ItemClick);
            // 
            // btnBoPhan
            // 
            this.btnBoPhan.Caption = "Bộ Phận";
            this.btnBoPhan.Id = 26;
            this.btnBoPhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBoPhan.ImageOptions.SvgImage")));
            this.btnBoPhan.Name = "btnBoPhan";
            this.btnBoPhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBoPhan_ItemClick);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Caption = "Chức vụ";
            this.btnChucVu.Id = 27;
            this.btnChucVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChucVu.ImageOptions.SvgImage")));
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChucVu_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Đóng";
            this.barButtonItem3.Id = 28;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 30;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoiMatKhau);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBackup, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPhucHoiDB, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Nhân sự";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanTocN, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTonGiao, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPhongBan, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCongTy, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBoPhan, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhanVien, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChucVu, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thông tin";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 686);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1249, 24);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1249, 710);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phần mềm quản lý nhân sự";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnDanToc;
        private DevExpress.XtraBars.BarButtonItem btnTonGiao;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnPhongBan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnLoaiCa;
        private DevExpress.XtraBars.BarButtonItem btnLoaiCong;
        private DevExpress.XtraBars.BarButtonItem btnPhucap;
        private DevExpress.XtraBars.BarButtonItem btnTangCa;
        private DevExpress.XtraBars.BarButtonItem btnUngLuong;
        private DevExpress.XtraBars.BarButtonItem btnBangCong;
        private DevExpress.XtraBars.BarButtonItem btnBangLuong;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiDB;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnDanTocN;
        private DevExpress.XtraBars.BarButtonItem btnCongTy;
        private DevExpress.XtraBars.BarButtonItem btnBoPhan;
        private DevExpress.XtraBars.BarButtonItem btnChucVu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
    }
}