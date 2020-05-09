namespace N16DCCN150_HoPhuongThanh
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLenhMua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLenhBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangGiaTT = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapLenh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnLenhMua,
            this.btnLenhBan,
            this.btnBangGiaTT,
            this.btnNhapLenh});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(995, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnLenhMua
            // 
            this.btnLenhMua.Caption = "Giao Dịch";
            this.btnLenhMua.Id = 1;
            this.btnLenhMua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLenhMua.ImageOptions.Image")));
            this.btnLenhMua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLenhMua.ImageOptions.LargeImage")));
            this.btnLenhMua.Name = "btnLenhMua";
            this.btnLenhMua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLenhDat_ItemClick);
            // 
            // btnLenhBan
            // 
            this.btnLenhBan.Caption = "Lệnh bán";
            this.btnLenhBan.Id = 2;
            this.btnLenhBan.Name = "btnLenhBan";
            // 
            // btnBangGiaTT
            // 
            this.btnBangGiaTT.Caption = "Bảng giá trực tuyến";
            this.btnBangGiaTT.Id = 3;
            this.btnBangGiaTT.Name = "btnBangGiaTT";
            // 
            // btnNhapLenh
            // 
            this.btnNhapLenh.Caption = "Bảng Giá Trực Tuyến";
            this.btnNhapLenh.Id = 4;
            this.btnNhapLenh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapLenh.ImageOptions.Image")));
            this.btnNhapLenh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhapLenh.ImageOptions.LargeImage")));
            this.btnNhapLenh.Name = "btnNhapLenh";
            this.btnNhapLenh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapLenh_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chứng khoán";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLenhMua);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNhapLenh);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 609);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(995, 37);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 646);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnLenhMua;
        private DevExpress.XtraBars.BarButtonItem btnLenhBan;
        private DevExpress.XtraBars.BarButtonItem btnBangGiaTT;
        private DevExpress.XtraBars.BarButtonItem btnNhapLenh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}