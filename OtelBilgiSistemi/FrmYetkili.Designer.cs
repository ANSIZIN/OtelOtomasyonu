namespace OtelBilgiSistemi
{
    partial class FrmYetkili
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYetkili));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnYeniKayit = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuncellemeSilme = new DevExpress.XtraBars.BarButtonItem();
            this.btnYeniPersonel = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersonelGuncelleme = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersonelListele = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonOtelIslem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPersonelIslem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnYeniKayit,
            this.btnGuncellemeSilme,
            this.btnYeniPersonel,
            this.btnPersonelGuncelleme,
            this.btnPersonelListele});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonOtelIslem,
            this.ribbonPersonelIslem});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(988, 112);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Caption = "YENİ KAYIT";
            this.btnYeniKayit.Id = 1;
            this.btnYeniKayit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniKayit.ImageOptions.Image")));
            this.btnYeniKayit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayit.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnYeniKayit.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniKayit.ItemAppearance.Normal.Options.UseFont = true;
            this.btnYeniKayit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayit.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYeniKayit_ItemClick);
            // 
            // btnGuncellemeSilme
            // 
            this.btnGuncellemeSilme.Caption = "OTEL GÜNCELLEME-SİLME";
            this.btnGuncellemeSilme.Id = 2;
            this.btnGuncellemeSilme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncellemeSilme.ImageOptions.Image")));
            this.btnGuncellemeSilme.ItemAppearance.Hovered.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncellemeSilme.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnGuncellemeSilme.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncellemeSilme.ItemAppearance.Normal.Options.UseFont = true;
            this.btnGuncellemeSilme.ItemAppearance.Pressed.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncellemeSilme.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnGuncellemeSilme.Name = "btnGuncellemeSilme";
            this.btnGuncellemeSilme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuncellemeSilme_ItemClick);
            // 
            // btnYeniPersonel
            // 
            this.btnYeniPersonel.Caption = "YENİ PERSONEL";
            this.btnYeniPersonel.Id = 3;
            this.btnYeniPersonel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniPersonel.ImageOptions.Image")));
            this.btnYeniPersonel.ItemAppearance.Hovered.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniPersonel.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnYeniPersonel.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniPersonel.ItemAppearance.Normal.Options.UseFont = true;
            this.btnYeniPersonel.ItemAppearance.Pressed.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniPersonel.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnYeniPersonel.Name = "btnYeniPersonel";
            this.btnYeniPersonel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYeniPersonel_ItemClick);
            // 
            // btnPersonelGuncelleme
            // 
            this.btnPersonelGuncelleme.Caption = "PERSONEL GÜNCELLEME";
            this.btnPersonelGuncelleme.Id = 4;
            this.btnPersonelGuncelleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelGuncelleme.ImageOptions.Image")));
            this.btnPersonelGuncelleme.ItemAppearance.Hovered.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGuncelleme.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnPersonelGuncelleme.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGuncelleme.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPersonelGuncelleme.ItemAppearance.Pressed.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGuncelleme.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnPersonelGuncelleme.Name = "btnPersonelGuncelleme";
            this.btnPersonelGuncelleme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersonelGuncelleme_ItemClick);
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.Caption = "PERSONEL LİSTELEME";
            this.btnPersonelListele.Id = 5;
            this.btnPersonelListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelListele.ImageOptions.Image")));
            this.btnPersonelListele.ItemAppearance.Hovered.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelListele.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnPersonelListele.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelListele.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPersonelListele.ItemAppearance.Pressed.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelListele.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnPersonelListele.Name = "btnPersonelListele";
            // 
            // ribbonOtelIslem
            // 
            this.ribbonOtelIslem.Appearance.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonOtelIslem.Appearance.Options.UseFont = true;
            this.ribbonOtelIslem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonOtelIslem.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOtelIslem.Image")));
            this.ribbonOtelIslem.Name = "ribbonOtelIslem";
            this.ribbonOtelIslem.Text = "OTEL İŞLEMLERİ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYeniKayit);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGuncellemeSilme);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPersonelIslem
            // 
            this.ribbonPersonelIslem.Appearance.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonPersonelIslem.Appearance.Options.UseFont = true;
            this.ribbonPersonelIslem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPersonelIslem.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPersonelIslem.Image")));
            this.ribbonPersonelIslem.Name = "ribbonPersonelIslem";
            this.ribbonPersonelIslem.Text = "PERSONEL İŞLEMLERİ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnYeniPersonel);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPersonelGuncelleme);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPersonelListele);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmYetkili
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 744);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmYetkili";
            this.Ribbon = this.ribbonControl1;
            this.Text = "YÖNETİCİ PANELİ";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnYeniKayit;
        private DevExpress.XtraBars.BarButtonItem btnGuncellemeSilme;
        private DevExpress.XtraBars.BarButtonItem btnYeniPersonel;
        private DevExpress.XtraBars.BarButtonItem btnPersonelGuncelleme;
        private DevExpress.XtraBars.BarButtonItem btnPersonelListele;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonOtelIslem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPersonelIslem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}