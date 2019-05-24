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
    public partial class FrmYeniOtel : Form
    {
        public FrmYeniOtel()
        {
            InitializeComponent();
        }
        SQLVeriGetirme SQL = new SQLVeriGetirme();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Otel otel = new Otel
            {
                OtelAd = txtOtelAd.Text,
                Il = txtOtelIL.Text,
                Ilce = txtOtelIlce.Text,
                Telefon = txtOtelTelefon.Text,
                Eposta = txtOtelEmail.Text,
                OdaSayisi = int.Parse(txtOtelOdaSayisi.Text),
                YildizSayisi = int.Parse(txtOtelYildizSayisi.Text),
                OtelPuani = txtOtelPuan.Text,
                Adres = rtbAdres.Text,
                plakaKodu =int.Parse(txtPlakaKodu.Text),

            };
            SQL.OtelEkle(otel);
            MessageBox.Show("Otel Başarı İle Eklenmiştir");
        }

        private void FrmYeniOtel_Load(object sender, EventArgs e)
        {
            İkiliAramaAgaci ikiliAramaAgaci = new İkiliAramaAgaci();
            List<Otel> oteller = new List<Otel>();
            List<OtelYorum> otelyorumları = new List<OtelYorum>();
            List<Personel> personels = new List<Personel>();

            oteller = SQL.OtelBilgiGetir();

            for (int i = 0; i < oteller.Count; i++)
            {
                ikiliAramaAgaci.Ekle(oteller[i]);
            }

            personels = SQL.PersonelBilgiGetir();

            Otel tempOtel = new Otel();
            for (int i = 0; i < personels.Count; i++)
            {
                string otelIsmi = personels[i].CalistigiOtel;
                tempOtel = ikiliAramaAgaci.Ara(otelIsmi).otel;
                tempOtel.PersonelHead.InsertLast(personels[i]);
            }

            otelyorumları = SQL.OtelYorumGetir();

            for (int i = 0; i < otelyorumları.Count; i++)
            {
                string otelIsmi = otelyorumları[i].YorumlananOtel;
                tempOtel = ikiliAramaAgaci.Ara(otelIsmi).otel;

                tempOtel.OtelYorumHead.InsertLast(otelyorumları[i]);

            }
        }
    }
}
