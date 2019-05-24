namespace OtelBilgiSistemi
{
    partial class FrmOtelBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOtelBilgi));
            this.txtOtelAd = new System.Windows.Forms.TextBox();
            this.btnOtelBilgi = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOtelAd
            // 
            this.txtOtelAd.Location = new System.Drawing.Point(331, 60);
            this.txtOtelAd.Name = "txtOtelAd";
            this.txtOtelAd.Size = new System.Drawing.Size(329, 22);
            this.txtOtelAd.TabIndex = 1;
            // 
            // btnOtelBilgi
            // 
            this.btnOtelBilgi.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOtelBilgi.Appearance.Options.UseFont = true;
            this.btnOtelBilgi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOtelBilgi.ImageOptions.Image")));
            this.btnOtelBilgi.Location = new System.Drawing.Point(394, 99);
            this.btnOtelBilgi.Name = "btnOtelBilgi";
            this.btnOtelBilgi.Size = new System.Drawing.Size(214, 42);
            this.btnOtelBilgi.TabIndex = 4;
            this.btnOtelBilgi.Text = "Bilgileri gör";
            this.btnOtelBilgi.Click += new System.EventHandler(this.btnOtelBilgi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(403, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Otelin Adını Giriniz:\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(965, 397);
            this.dataGridView1.TabIndex = 11;
            // 
            // FrmOtelBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 842);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOtelBilgi);
            this.Controls.Add(this.txtOtelAd);
            this.Name = "FrmOtelBilgi";
            this.Text = "Otel Bilgi";
            this.Load += new System.EventHandler(this.FrmOtelBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOtelAd;
        private DevExpress.XtraEditors.SimpleButton btnOtelBilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}