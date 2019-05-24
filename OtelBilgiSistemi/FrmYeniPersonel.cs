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
    public partial class FrmYeniPersonel : Form
    {
        public FrmYeniPersonel()
        {
            InitializeComponent();
        }
        SQLVeriGetirme sql = new SQLVeriGetirme();
        Personel personel = new Personel();

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            sql.PersonelEkle(new Personel
            {
            TC = txtTc.Text,
            PerAd = txtAd.Text,
            PerSoyad = txtSoyad.Text,
            PerTelefon = txtTelefon.Text,
            PerAdres = txtAdres.Text,
            PerEposta = txtMail.Text,
            Departman = txtDepartman.Text,
            Pozisyon = txtPosizyon.Text,
            PersonelPuani = txtPersonelPuani.Text,
            CalistigiOtel = txtCalistigiOtel.Text,
        });
            MessageBox.Show("Personel eklenmiştir");

        }

        private void FrmYeniPersonel_Load(object sender, EventArgs e)
        {
            İkiliAramaAgaci ikiliAramaAgaci = new İkiliAramaAgaci();
            List<Otel> oteller = new List<Otel>();
            List<Personel> personels = new List<Personel>();

            oteller = sql.OtelBilgiGetir();

            for (int i = 0; i < oteller.Count; i++)
            {
                ikiliAramaAgaci.Ekle(oteller[i]);
            }

            personels = sql.PersonelBilgiGetir();

            Otel tempOtel = new Otel();
            for (int i = 0; i < personels.Count; i++)
            {
                string otelIsmi = personels[i].CalistigiOtel;
                tempOtel = ikiliAramaAgaci.Ara(otelIsmi).otel;
                tempOtel.PersonelHead.InsertLast(personels[i]);
            }
        }
    }
}
