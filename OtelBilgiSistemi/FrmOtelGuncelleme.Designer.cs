namespace OtelBilgiSistemi
{
    partial class FrmOtelGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOtelGuncelleme));
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rtbAdres = new System.Windows.Forms.RichTextBox();
            this.txtOtelPuan = new DevExpress.XtraEditors.TextEdit();
            this.txtOtelYildizSayisi = new DevExpress.XtraEditors.TextEdit();
            this.txtOtelOdaSayisi = new DevExpress.XtraEditors.TextEdit();
            this.txtOtelEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtOtelTelefon = new DevExpress.XtraEditors.TextEdit();
            this.txtOtelIlce = new DevExpress.XtraEditors.TextEdit();
            this.txtOtelIL = new DevExpress.XtraEditors.TextEdit();
            this.txtOtelAd = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.otelBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelBilgiSistemiDataSet3 = new OtelBilgiSistemi.OtelBilgiSistemiDataSet3();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOtelAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colilce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEposta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYildizSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdaSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtelPuani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlakaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.otelBilgiTableAdapter = new OtelBilgiSistemi.OtelBilgiSistemiDataSet3TableAdapters.OtelBilgiTableAdapter();
            this.txtPlakaKodu = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelPuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelYildizSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelOdaSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelIL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelBilgiSistemiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlakaKodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(793, 223);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(177, 48);
            this.BtnSil.TabIndex = 59;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(598, 223);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(177, 48);
            this.BtnKaydet.TabIndex = 58;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // rtbAdres
            // 
            this.rtbAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbAdres.Location = new System.Drawing.Point(211, 147);
            this.rtbAdres.Name = "rtbAdres";
            this.rtbAdres.Size = new System.Drawing.Size(177, 96);
            this.rtbAdres.TabIndex = 57;
            this.rtbAdres.Text = "";
            // 
            // txtOtelPuan
            // 
            this.txtOtelPuan.Location = new System.Drawing.Point(569, 122);
            this.txtOtelPuan.Name = "txtOtelPuan";
            this.txtOtelPuan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOtelPuan.Properties.Appearance.Options.UseFont = true;
            this.txtOtelPuan.Size = new System.Drawing.Size(177, 28);
            this.txtOtelPuan.TabIndex = 56;
            // 
            // txtOtelYildizSayisi
            // 
            this.txtOtelYildizSayisi.Location = new System.Drawing.Point(569, 88);
            this.txtOtelYildizSayisi.Name = "txtOtelYildizSayisi";
            this.txtOtelYildizSayisi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOtelYildizSayisi.Properties.Appearance.Options.UseFont = true;
            this.txtOtelYildizSayisi.Size = new System.Drawing.Size(177, 28);
            this.txtOtelYildizSayisi.TabIndex = 55;
            // 
            // txtOtelOdaSayisi
            // 
            this.txtOtelOdaSayisi.Location = new System.Drawing.Point(569, 54);
            this.txtOtelOdaSayisi.Name = "txtOtelOdaSayisi";
            this.txtOtelOdaSayisi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOtelOdaSayisi.Properties.Appearance.Options.UseFont = true;
            this.txtOtelOdaSayisi.Size = new System.Drawing.Size(177, 28);
            this.txtOtelOdaSayisi.TabIndex = 54;
            // 
            // txtOtelEmail
            // 
            this.txtOtelEmail.Location = new System.Drawing.Point(569, 20);
            this.txtOtelEmail.Name = "txtOtelEmail";
            this.txtOtelEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOtelEmail.Properties.Appearance.Options.UseFont = true;
            this.txtOtelEmail.Size = new System.Drawing.Size(177, 28);
            this.txtOtelEmail.TabIndex = 53;
            // 
            // txtOtelTelefon
            // 
            this.txtOtelTelefon.Location = new System.Drawing.Point(211, 113);
            this.txtOtelTelefon.Name = "txtOtelTelefon";
            this.txtOtelTelefon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOtelTelefon.Properties.Appearance.Options.UseFont = true;
            this.txtOtelTelefon.Size = new System.Drawing.Size(177, 28);
            this.txtOtelTelefon.TabIndex = 52;
            // 
            // txtOtelIlce
            // 
            this.txtOtelIlce.Location = new System.Drawing.Point(211, 79);
            this.txtOtelIlce.Name = "txtOtelIlce";
            this.txtOtelIlce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOtelIlce.Properties.Appearance.Options.UseFont = true;
            this.txtOtelIlce.Size = new System.Drawing.Size(177, 28);
            this.txtOtelIlce.TabIndex = 51;
            // 
            // txtOtelIL
            // 
            this.txtOtelIL.Location = new System.Drawing.Point(211, 45);
            this.txtOtelIL.Name = "txtOtelIL";
            this.txtOtelIL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOtelIL.Properties.Appearance.Options.UseFont = true;
            this.txtOtelIL.Size = new System.Drawing.Size(177, 28);
            this.txtOtelIL.TabIndex = 50;
            // 
            // txtOtelAd
            // 
            this.txtOtelAd.Location = new System.Drawing.Point(211, 10);
            this.txtOtelAd.Name = "txtOtelAd";
            this.txtOtelAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOtelAd.Properties.Appearance.Options.UseFont = true;
            this.txtOtelAd.Size = new System.Drawing.Size(177, 28);
            this.txtOtelAd.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(410, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 25);
            this.label10.TabIndex = 48;
            this.label10.Text = "OTEL PUANI :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(414, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "ODA SAYISI :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(398, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "YILDIZ SAYISI :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(468, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "EMAIL :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(89, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "TELEFON :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(113, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "ADRES :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(137, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "ILCE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(165, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "IL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(154, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "AD :";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.otelBilgiBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 277);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(958, 396);
            this.gridControl1.TabIndex = 61;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // otelBilgiBindingSource
            // 
            this.otelBilgiBindingSource.DataMember = "OtelBilgi";
            this.otelBilgiBindingSource.DataSource = this.otelBilgiSistemiDataSet3;
            // 
            // otelBilgiSistemiDataSet3
            // 
            this.otelBilgiSistemiDataSet3.DataSetName = "OtelBilgiSistemiDataSet3";
            this.otelBilgiSistemiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOtelAd,
            this.colil,
            this.colilce,
            this.colAdres,
            this.colTelefon,
            this.colEposta,
            this.colYildizSayisi,
            this.colOdaSayisi,
            this.colOtelPuani,
            this.colPlakaKodu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colOtelAd
            // 
            this.colOtelAd.FieldName = "OtelAd";
            this.colOtelAd.Name = "colOtelAd";
            this.colOtelAd.Visible = true;
            this.colOtelAd.VisibleIndex = 0;
            // 
            // colil
            // 
            this.colil.FieldName = "il";
            this.colil.Name = "colil";
            this.colil.Visible = true;
            this.colil.VisibleIndex = 1;
            // 
            // colilce
            // 
            this.colilce.FieldName = "ilce";
            this.colilce.Name = "colilce";
            this.colilce.Visible = true;
            this.colilce.VisibleIndex = 2;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 3;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 4;
            // 
            // colEposta
            // 
            this.colEposta.FieldName = "Eposta";
            this.colEposta.Name = "colEposta";
            this.colEposta.Visible = true;
            this.colEposta.VisibleIndex = 5;
            // 
            // colYildizSayisi
            // 
            this.colYildizSayisi.FieldName = "YildizSayisi";
            this.colYildizSayisi.Name = "colYildizSayisi";
            this.colYildizSayisi.Visible = true;
            this.colYildizSayisi.VisibleIndex = 6;
            // 
            // colOdaSayisi
            // 
            this.colOdaSayisi.FieldName = "OdaSayisi";
            this.colOdaSayisi.Name = "colOdaSayisi";
            this.colOdaSayisi.Visible = true;
            this.colOdaSayisi.VisibleIndex = 7;
            // 
            // colOtelPuani
            // 
            this.colOtelPuani.FieldName = "OtelPuani";
            this.colOtelPuani.Name = "colOtelPuani";
            this.colOtelPuani.Visible = true;
            this.colOtelPuani.VisibleIndex = 8;
            // 
            // colPlakaKodu
            // 
            this.colPlakaKodu.FieldName = "PlakaKodu";
            this.colPlakaKodu.Name = "colPlakaKodu";
            this.colPlakaKodu.Visible = true;
            this.colPlakaKodu.VisibleIndex = 9;
            // 
            // otelBilgiTableAdapter
            // 
            this.otelBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // txtPlakaKodu
            // 
            this.txtPlakaKodu.Location = new System.Drawing.Point(569, 169);
            this.txtPlakaKodu.Name = "txtPlakaKodu";
            this.txtPlakaKodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlakaKodu.Properties.Appearance.Options.UseFont = true;
            this.txtPlakaKodu.Size = new System.Drawing.Size(177, 28);
            this.txtPlakaKodu.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(410, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "PLAKA KODU";
            // 
            // FrmOtelGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlakaKodu);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.rtbAdres);
            this.Controls.Add(this.txtOtelPuan);
            this.Controls.Add(this.txtOtelYildizSayisi);
            this.Controls.Add(this.txtOtelOdaSayisi);
            this.Controls.Add(this.txtOtelEmail);
            this.Controls.Add(this.txtOtelTelefon);
            this.Controls.Add(this.txtOtelIlce);
            this.Controls.Add(this.txtOtelIL);
            this.Controls.Add(this.txtOtelAd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmOtelGuncelleme";
            this.Text = "FrmOtelGuncelleme";
            this.Load += new System.EventHandler(this.FrmOtelGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelPuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelYildizSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelOdaSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelIL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtelAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelBilgiSistemiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlakaKodu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox rtbAdres;
        private DevExpress.XtraEditors.TextEdit txtOtelPuan;
        private DevExpress.XtraEditors.TextEdit txtOtelYildizSayisi;
        private DevExpress.XtraEditors.TextEdit txtOtelOdaSayisi;
        private DevExpress.XtraEditors.TextEdit txtOtelEmail;
        private DevExpress.XtraEditors.TextEdit txtOtelTelefon;
        private DevExpress.XtraEditors.TextEdit txtOtelIlce;
        private DevExpress.XtraEditors.TextEdit txtOtelIL;
        private DevExpress.XtraEditors.TextEdit txtOtelAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private OtelBilgiSistemiDataSet3 otelBilgiSistemiDataSet3;
        private System.Windows.Forms.BindingSource otelBilgiBindingSource;
        private OtelBilgiSistemiDataSet3TableAdapters.OtelBilgiTableAdapter otelBilgiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colOtelAd;
        private DevExpress.XtraGrid.Columns.GridColumn colil;
        private DevExpress.XtraGrid.Columns.GridColumn colilce;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colEposta;
        private DevExpress.XtraGrid.Columns.GridColumn colYildizSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colOdaSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colOtelPuani;
        private DevExpress.XtraGrid.Columns.GridColumn colPlakaKodu;
        private DevExpress.XtraEditors.TextEdit txtPlakaKodu;
        private System.Windows.Forms.Label label1;
    }
}