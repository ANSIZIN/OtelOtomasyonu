using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelBilgiSistemi
{
    public partial class FrmOtelGuncelleme : Form
    {
        public FrmOtelGuncelleme()
        {
            InitializeComponent();
        }


        private void FrmOtelGuncelleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelBilgiSistemiDataSet3.OtelBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.otelBilgiTableAdapter.Fill(this.otelBilgiSistemiDataSet3.OtelBilgi);
            İkiliAramaAgaci ikiliAramaAgaci = new İkiliAramaAgaci();
            SQLVeriGetirme verigetir = new SQLVeriGetirme();
            List<Otel> oteller = new List<Otel>();
            List<OtelYorum> otelyorumları = new List<OtelYorum>();
            List<Personel> personels = new List<Personel>();

            oteller = verigetir.OtelBilgiGetir();

            for (int i = 0; i < oteller.Count; i++)
            {
                ikiliAramaAgaci.Ekle(oteller[i]);
            }

            personels = verigetir.PersonelBilgiGetir();

            Otel tempOtel = new Otel();
            for (int i = 0; i < personels.Count; i++)
            {
                string otelIsmi = personels[i].CalistigiOtel;
                tempOtel = ikiliAramaAgaci.Ara(otelIsmi).otel;
                tempOtel.PersonelHead.InsertLast(personels[i]);
            }

            otelyorumları = verigetir.OtelYorumGetir();

            for (int i = 0; i < otelyorumları.Count; i++)
            {
                string otelIsmi = otelyorumları[i].YorumlananOtel;
                tempOtel = ikiliAramaAgaci.Ara(otelIsmi).otel;

                tempOtel.OtelYorumHead.InsertLast(otelyorumları[i]);

            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtOtelAd.Text = dr["OtelAd"].ToString();
            txtOtelIL.Text = dr["il"].ToString();
            txtOtelIlce.Text = dr["ilce"].ToString();
            txtOtelTelefon.Text = dr["Telefon"].ToString();
            rtbAdres.Text = dr["Adres"].ToString();
            txtOtelEmail.Text = dr["Eposta"].ToString();
            txtOtelOdaSayisi.Text = dr["OdaSayisi"].ToString();
            txtOtelPuan.Text = dr["OtelPuani"].ToString();
            txtOtelYildizSayisi.Text = dr["YildizSayisi"].ToString();
            txtPlakaKodu.Text = dr["PlakaKodu"].ToString();
        }
        SQLVeriGetirme sql = new SQLVeriGetirme();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Otel otel = new Otel
            {
                OtelAd = txtOtelAd.Text,
                Il = txtOtelIL.Text,
                Ilce = txtOtelIlce.Text,
                Telefon = txtOtelTelefon.Text,
                Adres = rtbAdres.Text,
                Eposta = txtOtelEmail.Text,
                OdaSayisi =int.Parse(txtOtelOdaSayisi.Text),
                OtelPuani = txtOtelPuan.Text,
                YildizSayisi = int.Parse(txtOtelYildizSayisi.Text),
                plakaKodu = int.Parse(txtPlakaKodu.Text),
            };
            sql.OtelGuncelle(otel);
            MessageBox.Show("İşlem Tamamlandı");
        }
        SQLVeriGetirme SQL = new SQLVeriGetirme();
        private void BtnSil_Click(object sender, EventArgs e)
        {
            SQL.OtelSil(txtOtelAd.Text);
            MessageBox.Show("Silme İşlemi Derçekleştirildi");

        }

    }
}
