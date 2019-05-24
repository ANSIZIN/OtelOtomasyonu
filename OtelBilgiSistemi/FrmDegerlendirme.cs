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
    public partial class FrmDegerlendirme : Form
    {
        public FrmDegerlendirme()
        {
            InitializeComponent();
        }
        SQLVeriGetirme sql = new SQLVeriGetirme();
        OtelYorum personel = new OtelYorum();
        İkiliAramaAgaci ikiliAramaAgaci = new İkiliAramaAgaci();
        private void btnTamamla_Click(object sender, EventArgs e)
        {
            sql.OtelYorumEkle(new OtelYorum
            {
                YorumcuEposta = txtMusEposta.Text,
                YorumcuPuan = cmbPuan.Text,
                YorumlananOtel = txtOtelAd.Text,
                YorumMetni = rtbMetin.Text,               
            });
            MessageBox.Show("Değerlendirmeniz Başarıyla Eklenmiştir");

        }

        private void FrmDegerlendirme_Load(object sender, EventArgs e)
        {
            List<Otel> oteller = new List<Otel>();
            List<OtelYorum> otelyorumları = new List<OtelYorum>();
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

            otelyorumları = sql.OtelYorumGetir();

            for (int i = 0; i < otelyorumları.Count; i++)
            {
                string otelIsmi = otelyorumları[i].YorumlananOtel;
                tempOtel = ikiliAramaAgaci.Ara(otelIsmi).otel;

                tempOtel.OtelYorumHead.InsertLast(otelyorumları[i]);

            }
        }
    }
}
