namespace Kafedisyon.UI.Win.Forms.BaseForms
{
    partial class BaseKartlarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseKartlarForm));
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnYeni = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnSec = new DevExpress.XtraBars.BarButtonItem();
            this.StatusBarAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.btnDuzelt = new DevExpress.XtraBars.BarButtonItem();
            this.btnYenile = new DevExpress.XtraBars.BarButtonItem();
            this.btnFiltrele = new DevExpress.XtraBars.BarButtonItem();
            this.btnKolonlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.btnGonder = new DevExpress.XtraBars.BarButtonItem();
            this.btnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar2 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonbuton1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 462);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Size = new System.Drawing.Size(848, 20);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonControl
            // 
            this.ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnYeni,
            this.btnSil,
            this.btnSec,
            this.StatusBarAciklama,
            this.btnDuzelt,
            this.btnYenile,
            this.btnFiltrele,
            this.btnKolonlar,
            this.btnYazdir,
            this.btnGonder,
            this.btnCikis});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 12;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowQatLocationSelector = false;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(848, 135);
            this.ribbonControl.StatusBar = this.ribbonStatusBar2;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnYeni
            // 
            this.btnYeni.Caption = "Yeni";
            this.btnYeni.Id = 1;
            this.btnYeni.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.add_16x162;
            this.btnYeni.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.add_32x321;
            this.btnYeni.Name = "btnYeni";
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 2;
            this.btnSil.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.removeitem_16x161;
            this.btnSil.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.removeitem_32x321;
            this.btnSil.Name = "btnSil";
            // 
            // btnSec
            // 
            this.btnSec.Caption = "Seç";
            this.btnSec.Id = 3;
            this.btnSec.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.selectall2_16x16;
            this.btnSec.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.selectall2_32x32;
            this.btnSec.Name = "btnSec";
            // 
            // StatusBarAciklama
            // 
            this.StatusBarAciklama.Caption = "Açıklama";
            this.StatusBarAciklama.Id = 4;
            this.StatusBarAciklama.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.question_16x16;
            this.StatusBarAciklama.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.question_32x32;
            this.StatusBarAciklama.Name = "StatusBarAciklama";
            this.StatusBarAciklama.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Caption = "Düzelt";
            this.btnDuzelt.Id = 5;
            this.btnDuzelt.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.edit_16x16;
            this.btnDuzelt.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.edit_32x32;
            this.btnDuzelt.Name = "btnDuzelt";
            // 
            // btnYenile
            // 
            this.btnYenile.Caption = "Yenile";
            this.btnYenile.Id = 6;
            this.btnYenile.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.refresh_16x162;
            this.btnYenile.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.refresh_32x322;
            this.btnYenile.Name = "btnYenile";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Caption = "Filtrele";
            this.btnFiltrele.Id = 7;
            this.btnFiltrele.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.masterfilter_16x16;
            this.btnFiltrele.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.masterfilter_32x32;
            this.btnFiltrele.Name = "btnFiltrele";
            // 
            // btnKolonlar
            // 
            this.btnKolonlar.Caption = "Kolonlar";
            this.btnKolonlar.Id = 8;
            this.btnKolonlar.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.contentarrangeincolums_16x16;
            this.btnKolonlar.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.contentarrangeincolums_32x32;
            this.btnKolonlar.Name = "btnKolonlar";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Caption = "Yazdır";
            this.btnYazdir.Id = 9;
            this.btnYazdir.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.printer_16x16;
            this.btnYazdir.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.printer_32x32;
            this.btnYazdir.Name = "btnYazdir";
            // 
            // btnGonder
            // 
            this.btnGonder.Caption = "Gönder";
            this.btnGonder.Id = 10;
            this.btnGonder.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.send_16x16;
            this.btnGonder.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.send_32x32;
            this.btnGonder.Name = "btnGonder";
            // 
            // btnCikis
            // 
            this.btnCikis.Caption = "Çıkış";
            this.btnCikis.Id = 11;
            this.btnCikis.ImageOptions.Image = global::Kafedisyon.UI.Win.Properties.Resources.cancel_16x162;
            this.btnCikis.ImageOptions.LargeImage = global::Kafedisyon.UI.Win.Properties.Resources.cancel_32x322;
            this.btnCikis.Name = "btnCikis";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYeni);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSec);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDuzelt);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYenile);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFiltrele);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKolonlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYazdir);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGonder);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar2
            // 
            this.ribbonStatusBar2.ItemLinks.Add(this.StatusBarAciklama);
            this.ribbonStatusBar2.Location = new System.Drawing.Point(0, 432);
            this.ribbonStatusBar2.Name = "ribbonStatusBar2";
            this.ribbonStatusBar2.Ribbon = this.ribbonControl;
            this.ribbonStatusBar2.Size = new System.Drawing.Size(848, 30);
            // 
            // ribbonbuton1
            // 
            this.ribbonbuton1.Caption = "Yeni";
            this.ribbonbuton1.Id = 0;
            this.ribbonbuton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonbuton1.ImageOptions.Image")));
            this.ribbonbuton1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonbuton1.ImageOptions.LargeImage")));
            this.ribbonbuton1.Name = "ribbonbuton1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Yeni";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Yeni";
            this.barButtonItem5.Id = 0;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Yeni";
            this.barButtonItem6.Id = 0;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // BaseKartlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 482);
            this.Controls.Add(this.ribbonStatusBar2);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.MinimizeBox = false;
            this.Name = "BaseKartlarForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar2;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnYeni;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.BarButtonItem btnSec;
        private DevExpress.XtraBars.BarButtonItem ribbonbuton1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarStaticItem StatusBarAciklama;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar2;
        private DevExpress.XtraBars.BarButtonItem btnDuzelt;
        private DevExpress.XtraBars.BarButtonItem btnYenile;
        private DevExpress.XtraBars.BarButtonItem btnFiltrele;
        private DevExpress.XtraBars.BarButtonItem btnKolonlar;
        private DevExpress.XtraBars.BarButtonItem btnYazdir;
        private DevExpress.XtraBars.BarButtonItem btnGonder;
        private DevExpress.XtraBars.BarButtonItem btnCikis;
        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
    }
}