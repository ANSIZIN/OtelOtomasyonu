namespace OtelBilgiSistemi
{
    partial class FrmOtelListele
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
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbPuan = new System.Windows.Forms.RadioButton();
            this.rdbYildiz = new System.Windows.Forms.RadioButton();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgwPYilce = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPYilce)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(146, 69);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(100, 22);
            this.txtIlce.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(96, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "İl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(85, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "İlçe:";
            // 
            // rdbPuan
            // 
            this.rdbPuan.AutoSize = true;
            this.rdbPuan.Location = new System.Drawing.Point(52, 107);
            this.rdbPuan.Name = "rdbPuan";
            this.rdbPuan.Size = new System.Drawing.Size(106, 21);
            this.rdbPuan.TabIndex = 5;
            this.rdbPuan.TabStop = true;
            this.rdbPuan.Text = "Puana Göre";
            this.rdbPuan.UseVisualStyleBackColor = true;
            // 
            // rdbYildiz
            // 
            this.rdbYildiz.AutoSize = true;
            this.rdbYildiz.Location = new System.Drawing.Point(209, 107);
            this.rdbYildiz.Name = "rdbYildiz";
            this.rdbYildiz.Size = new System.Drawing.Size(106, 21);
            this.rdbYildiz.TabIndex = 6;
            this.rdbYildiz.TabStop = true;
            this.rdbYildiz.Text = "Yıldıza Göre";
            this.rdbYildiz.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Appearance.Options.UseFont = true;
            this.btnListele.Location = new System.Drawing.Point(110, 143);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(136, 33);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.comboBox1.Location = new System.Drawing.Point(146, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // dgwPYilce
            // 
            this.dgwPYilce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPYilce.Location = new System.Drawing.Point(6, 220);
            this.dgwPYilce.Name = "dgwPYilce";
            this.dgwPYilce.RowTemplate.Height = 24;
            this.dgwPYilce.Size = new System.Drawing.Size(964, 338);
            this.dgwPYilce.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(451, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(424, 148);
            this.listBox1.TabIndex = 10;
            // 
            // FrmOtelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 842);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dgwPYilce);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.rdbYildiz);
            this.Controls.Add(this.rdbPuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIlce);
            this.Name = "FrmOtelListele";
            this.Text = "Otel Ara";
            this.Load += new System.EventHandler(this.FrmOtelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPYilce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbPuan;
        private System.Windows.Forms.RadioButton rdbYildiz;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgwPYilce;
        private System.Windows.Forms.ListBox listBox1;
    }
}