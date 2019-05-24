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
    public partial class FrmTumOteller : Form
    {
        public FrmTumOteller()
        {
            InitializeComponent();
        }
        İkiliAramaAgaci aramaagaci=new İkiliAramaAgaci();
        İkiliAramaAgacDugumu dugum = new İkiliAramaAgacDugumu();
       // İkiliAramaAgacDugumu iad = new İkiliAramaAgacDugumu();
        SQLVeriGetirme verigetir = new SQLVeriGetirme();
        List<Otel> oteller = new List<Otel>();
        List<OtelYorum> otelyorumları = new List<OtelYorum>();
        List<Personel> personels = new List<Personel>();
        DataTable dt = new DataTable();
        private void FrmTumOteller_Load(object sender, EventArgs e)
        {
            oteller = verigetir.OtelBilgiGetir();

            for (int i = 0; i < oteller.Count; i++)
            {
                aramaagaci.Ekle(oteller[i]);
            }

            personels = verigetir.PersonelBilgiGetir();

            Otel tempOtel = new Otel();
            for (int i = 0; i < personels.Count; i++)
            {
                string otelIsmi = personels[i].CalistigiOtel;
                tempOtel = aramaagaci.Ara(otelIsmi).otel;
                tempOtel.PersonelHead.InsertLast(personels[i]);
            }

            otelyorumları = verigetir.OtelYorumGetir();

            for (int i = 0; i < otelyorumları.Count; i++)
            {
                string otelIsmi = otelyorumları[i].YorumlananOtel;
                tempOtel = aramaagaci.Ara(otelIsmi).otel;
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
            if (aramaagaci == null)
            {
                MessageBox.Show("Ağaç üzerinde dolaşmak için öncelikle ağacı oluşturmalısınız!");
            }
            else
            {
                switch (cmbGezinme.SelectedIndex)
                {
                    case 0:
                        aramaagaci.PreOrder();
                        break;
                    case 1:
                        aramaagaci.InOrder();
                        break;
                    case 2:
                        aramaagaci.PostOrder();
                        break;
                    default:
                        break;
                }

                List<İkiliAramaAgacDugumu> nw = new List<İkiliAramaAgacDugumu>();
                nw = aramaagaci.DugumleriYazdir();
                 for(int i=0;i<nw.Count;i++)
                 {
                    dt.Rows.Add(nw[i].otel.OtelAd, nw[i].otel.Il, nw[i].otel.Ilce, nw[i].otel.Adres, nw[i].otel.Telefon, nw[i].otel.Eposta,
                        nw[i].otel.YildizSayisi, nw[i].otel.OtelPuani, nw[i].otel.OdaSayisi);
                    
                 }
                lblToplamOtel.Text = nw.Count.ToString();
                dgwTumOteller.DataSource = dt; 

            }
        }


        
    }
}
