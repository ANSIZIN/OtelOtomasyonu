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
    public partial class FrmOtelListele : Form
    {
        public FrmOtelListele()
        {
            InitializeComponent();
        }
        İkiliAramaAgaci ikiliAramaAgaci = new İkiliAramaAgaci();
        SQLVeriGetirme verigetir = new SQLVeriGetirme();
        List<Otel> oteller = new List<Otel>();
        List<OtelYorum> otelyorumları = new List<OtelYorum>();
        List<Personel> personels = new List<Personel>();
        DataTable dt = new DataTable();
        HashZincirleme hasharama = new HashZincirleme();
        private void FrmOtelListele_Load(object sender, EventArgs e)
        {
            oteller = verigetir.OtelBilgiGetir();
            
            for (int i = 0; i < oteller.Count; i++)
            {
                ikiliAramaAgaci.Ekle(oteller[i]);
                hasharama.OtelEkle(oteller[i].plakaKodu, oteller[i]);
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

        private void btnListele_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            List<Otel> hotels = new List<Otel>();



            if (rdbPuan.Checked==true)
            {
               hotels= hasharama.IlIlceOtelleriPuanli(Convert.ToInt32(comboBox1.SelectedIndex+1), txtIlce.Text);
                foreach(Otel otel in hotels)
                {
                    dt.Rows.Add(otel.OtelAd, otel.Il, otel.Ilce, otel.Adres, otel.Telefon, otel.Eposta
                   ,otel.YildizSayisi, otel.OtelPuani, otel.OdaSayisi);
                    dgwPYilce.DataSource = dt;
                }

            }
            else if(rdbYildiz.Checked==true)
            {
                hotels = hasharama.IlIlceOtelleriYildizli(Convert.ToInt32(comboBox1.SelectedIndex + 1), txtIlce.Text);
                foreach (Otel otel in hotels)
                {
                    dt.Rows.Add(otel.OtelAd, otel.Il, otel.Ilce, otel.Adres, otel.Telefon, otel.Eposta
                   , otel.YildizSayisi, otel.OtelPuani, otel.OdaSayisi);
                    dgwPYilce.DataSource = dt;
                }
            }
            else if(rdbPuan.Checked==false && rdbYildiz.Checked==false)
            {


                //hasharama.IlOtelleri(Convert.ToInt32(comboBox1.SelectedIndex));

                hotels = hasharama.IlIlceOtelleri(Convert.ToInt32(comboBox1.SelectedIndex+1),txtIlce.Text);
                foreach (Otel otel in hotels)
                {
                    dt.Rows.Add(otel.OtelAd, otel.Il, otel.Ilce, otel.Adres, otel.Telefon, otel.Eposta
                   , otel.YildizSayisi, otel.OtelPuani, otel.OdaSayisi);
                    dgwPYilce.DataSource = dt;
                }

            }
            else
            {
                MessageBox.Show("Lütfen kutucukları doldurun");
            }
        }


    }
}
