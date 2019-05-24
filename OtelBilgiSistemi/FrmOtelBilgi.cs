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
    public partial class FrmOtelBilgi : Form
    {
        public FrmOtelBilgi()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        İkiliAramaAgaci ikiliAramaAgaci = new İkiliAramaAgaci();
        private void FrmOtelBilgi_Load(object sender, EventArgs e)
        {
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
            dt.Columns.Add("Otel ADI", typeof(string));
            dt.Columns.Add("İl", typeof(string));
            dt.Columns.Add("İlçe", typeof(string));
            dt.Columns.Add("Adres", typeof(string));
            dt.Columns.Add("Telefon", typeof(string));
            dt.Columns.Add("Eposta", typeof(string));
            dt.Columns.Add("Yıldız Sayısı", typeof(int));
            dt.Columns.Add("Otel Puanı", typeof(string));
            dt.Columns.Add("Oda Sayısı", typeof(int));
        }

        private void btnOtelBilgi_Click(object sender, EventArgs e)
        {
            İkiliAramaAgacDugumu dugum = ikiliAramaAgaci.Ara(txtOtelAd.Text);
            if (dugum != null)
            {
                dt.Rows.Add(dugum.otel.OtelAd, dugum.otel.Il, dugum.otel.Ilce, dugum.otel.Adres, dugum.otel.Telefon, dugum.otel.Eposta
                    , dugum.otel.YildizSayisi, dugum.otel.OtelPuani, dugum.otel.OdaSayisi);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show(txtOtelAd.Text + " oteli bulunamadı....");
            }

            //HashZincirleme hashZincirleme = new HashZincirleme();

            /*for (int i = 0; i < oteller.Count; i++)
            {
                hashZincirleme.OtelEkle(oteller[i].plakaKodu, oteller[i]);
            }*/

            //Veritabanına eklemek için.
            /* ikiliAramaAgaci.InOrder();
             ikiliAramaAgaci.DugumleriYazdir();*/
        }

    }
}
