using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OtelBilgiSistemi
{
    public partial class FrmPersonelGuncelleme : Form
    {
        public FrmPersonelGuncelleme()
        {
            InitializeComponent();
        }
        SQLVeriGetirme sql = new SQLVeriGetirme();
        private void BtnSil_Click(object sender, EventArgs e)
        {
            string Tc = txtTc.Text;
            sql.PersonelSil(Tc);
            MessageBox.Show("Personel Silinmiştir");


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Personel personel= new Personel
            {
             TC = txtTc.Text,
             PerAd= txtAd.Text,
             PerSoyad = txtSoyad.Text,
             PerTelefon = txtTelefon.Text,
             PerAdres = txtAdres.Text,
             PerEposta = txtEposta.Text,
             Departman = txtDepartman.Text,
             Pozisyon = txtPozisyon.Text,
             PersonelPuani = txtPersonelPuani.Text,
             CalistigiOtel = txtCalistigiOtel.Text,
            };
            sql.PersonelGuncelle(personel);
            MessageBox.Show("İşlem Tamamlandı");


        }


        /*private void dgwPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dgwPersoneller.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dgwPersoneller.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgwPersoneller.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dgwPersoneller.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dgwPersoneller.CurrentRow.Cells[4].Value.ToString();
            txtEposta.Text = dgwPersoneller.CurrentRow.Cells[5].Value.ToString();
            txtDepartman.Text = dgwPersoneller.CurrentRow.Cells[6].Value.ToString();
            txtPozisyon.Text = dgwPersoneller.CurrentRow.Cells[7].Value.ToString();
            txtPersonelPuani.Text = dgwPersoneller.CurrentRow.Cells[8].Value.ToString();
            txtCalistigiOtel.Text = dgwPersoneller.CurrentRow.Cells[9].Value.ToString();
        }*/

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtTc.Text = dr["TcNo"].ToString();
            txtAd.Text = dr["Ad"].ToString();
            txtSoyad.Text = dr["Soyad"].ToString();
            txtTelefon.Text = dr["Telefon"].ToString();
            txtAdres.Text = dr["Adres"].ToString();
            txtEposta.Text = dr["Eposta"].ToString();
            txtDepartman.Text = dr["Departman"].ToString();
            txtPozisyon.Text = dr["Pozisyon"].ToString();
            txtPersonelPuani.Text = dr["PersonelPuani"].ToString();
            txtCalistigiOtel.Text = dr["CalistigiOtel"].ToString();

        }

        private void FrmPersonelGuncelleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelBilgiSistemiDataSet2.PersonelBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelBilgiTableAdapter1.Fill(this.otelBilgiSistemiDataSet2.PersonelBilgi);
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
