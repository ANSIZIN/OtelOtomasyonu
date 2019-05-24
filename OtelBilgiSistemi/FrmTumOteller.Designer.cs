namespace OtelBilgiSistemi
{
    partial class FrmTumOteller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTumOteller));
            this.dgwTumOteller = new System.Windows.Forms.DataGridView();
            this.cmbGezinme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.lblToplamOtel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTumOteller)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTumOteller
            // 
            this.dgwTumOteller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTumOteller.Location = new System.Drawing.Point(46, 289);
            this.dgwTumOteller.Name = "dgwTumOteller";
            this.dgwTumOteller.RowTemplate.Height = 24;
            this.dgwTumOteller.Size = new System.Drawing.Size(895, 257);
            this.dgwTumOteller.TabIndex = 0;
            // 
            // cmbGezinme
            // 
            this.cmbGezinme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGezinme.FormattingEnabled = true;
            this.cmbGezinme.Items.AddRange(new object[] {
            "Preorder",
            "Inorder",
            "Postorder"});
            this.cmbGezinme.Location = new System.Drawing.Point(234, 44);
            this.cmbGezinme.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGezinme.Name = "cmbGezinme";
            this.cmbGezinme.Size = new System.Drawing.Size(120, 24);
            this.cmbGezinme.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gezinme Şekli:";
            // 
            // btnListele
            // 
            this.btnListele.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Appearance.Options.UseFont = true;
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(55, 161);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(178, 36);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Otel Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblToplamOtel
            // 
            this.lblToplamOtel.AutoSize = true;
            this.lblToplamOtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamOtel.Location = new System.Drawing.Point(231, 109);
            this.lblToplamOtel.Name = "lblToplamOtel";
            this.lblToplamOtel.Size = new System.Drawing.Size(69, 17);
            this.lblToplamOtel.TabIndex = 10;
            this.lblToplamOtel.Text = "OtelSayi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Toplam Otel Sayısı:";
            // 
            // FrmTumOteller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 842);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToplamOtel);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGezinme);
            this.Controls.Add(this.dgwTumOteller);
            this.Name = "FrmTumOteller";
            this.Text = "FrmTumOteller";
            this.Load += new System.EventHandler(this.FrmTumOteller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTumOteller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTumOteller;
        private System.Windows.Forms.ComboBox cmbGezinme;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private System.Windows.Forms.Label lblToplamOtel;
        private System.Windows.Forms.Label label3;
    }
}