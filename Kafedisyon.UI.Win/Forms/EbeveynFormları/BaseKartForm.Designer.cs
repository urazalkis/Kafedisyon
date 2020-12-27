namespace Kafedisyon.UI.Win.Forms.BaseForms
{
    partial class BaseKartForm
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnYeni = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGeriAl = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSil = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.BtnYeni,
            this.BtnKaydet,
            this.BtnCikis,
            this.BtnSil,
            this.BtnGeriAl});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnYeni, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnKaydet, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnGeriAl, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnSil, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnCikis, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // BtnYeni
            // 
            this.BtnYeni.Caption = "Yeni";
            this.BtnYeni.Id = 1;
            this.BtnYeni.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.add_16x161;
            this.BtnYeni.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.add_32x32;
            this.BtnYeni.Name = "BtnYeni";
            this.BtnYeni.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnYeni_ItemClick);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Caption = "Kaydet";
            this.BtnKaydet.Enabled = false;
            this.BtnKaydet.Id = 2;
            this.BtnKaydet.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.save_16x16;
            this.BtnKaydet.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.save_32x32;
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKaydet_ItemClick);
            // 
            // BtnGeriAl
            // 
            this.BtnGeriAl.Caption = "Geri Al";
            this.BtnGeriAl.Id = 7;
            this.BtnGeriAl.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.reset_16x161;
            this.BtnGeriAl.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.reset_32x321;
            this.BtnGeriAl.Name = "BtnGeriAl";
            this.BtnGeriAl.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // BtnSil
            // 
            this.BtnSil.Caption = "Sil";
            this.BtnSil.Id = 5;
            this.BtnSil.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.removeitem_16x16;
            this.BtnSil.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.removeitem_32x32;
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // BtnCikis
            // 
            this.BtnCikis.Caption = "Çıkış";
            this.BtnCikis.Enabled = false;
            this.BtnCikis.Id = 3;
            this.BtnCikis.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.cancel_16x161;
            this.BtnCikis.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.cancel_32x321;
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnIptal_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(787, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 416);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(787, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 386);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(787, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 386);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // BaseKartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 416);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BaseKartForm";
            this.Load += new System.EventHandler(this.BaseKartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem BtnYeni;
        private DevExpress.XtraBars.BarButtonItem BtnKaydet;
        private DevExpress.XtraBars.BarButtonItem BtnCikis;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        protected DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnSil;
        private DevExpress.XtraBars.BarButtonItem BtnGeriAl;
    }
}