using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OtelBilgiSistemi
{
    
        public class SQLVeriGetirme
        {
            SqlConnection _baglanti = new SqlConnection(@"Data Source=DESKTOP-JLM6HOC;Initial Catalog=OtelBilgiSistemi;Integrated Security=True");
            List<Otel> Oteller = new List<Otel>();
            List<Personel> Personeller = new List<Personel>();
            List<OtelYorum> OtelYorumlar = new List<OtelYorum>();

            public List<Otel> OtelBilgiGetir()
            {
                
                if (_baglanti.State == ConnectionState.Closed)
                {
                    _baglanti.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM OtelBilgi", _baglanti);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                Otel otel = new Otel
                {
                    OtelAd = reader["OtelAd"].ToString(),
                    Il = reader["il"].ToString(),
                    Ilce = reader["ilce"].ToString(),
                    Adres = reader["Adres"].ToString(),
                    Telefon = reader["Telefon"].ToString(),
                    Eposta = reader["Eposta"].ToString(),
                    YildizSayisi = Convert.ToInt32(reader["YildizSayisi"]),
                    OdaSayisi = Convert.ToInt32(reader["OdaSayisi"]),
                    OtelPuani = reader["OtelPuani"].ToString(),
                    plakaKodu= Convert.ToInt32(reader["plakaKodu"]),
                    };
                    Oteller.Add(otel);
                }
                reader.Close();
                _baglanti.Close();
                return Oteller;
            }
            public List<Personel> PersonelBilgiGetir()
            {


                if (_baglanti.State == ConnectionState.Closed)
                {
                    _baglanti.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM PersonelBilgi", _baglanti);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Personel personel = new Personel
                    {
                        TC = reader["TcNo"].ToString(),
                        PerAd = reader["Ad"].ToString(),
                        PerSoyad = reader["Soyad"].ToString(),
                        PerTelefon = reader["Telefon"].ToString(),
                        PerAdres = reader["Adres"].ToString(),
                        
                        PerEposta = reader["Eposta"].ToString(),
                        Departman = reader["Departman"].ToString(),
                        Pozisyon = reader["Pozisyon"].ToString(),
                        PersonelPuani = reader["PersonelPuani"].ToString(),
                        CalistigiOtel = reader["CalistigiOtel"].ToString(),
                    };
                    Personeller.Add(personel);
                }
                reader.Close();
                _baglanti.Close();
                return Personeller;
            }
            public List<OtelYorum> OtelYorumGetir()
            {
                if (_baglanti.State == ConnectionState.Closed)
                {
                    _baglanti.Open();
                }
                SqlCommand command = new SqlCommand("SELECT* From OtelDegerlendirme", _baglanti);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    OtelYorum otelyorum = new OtelYorum
                    {
                        YorumcuEposta = reader["YorumYapan"].ToString(),
                        YorumMetni = reader["Yorumu"].ToString(),
                        YorumcuPuan = reader["OtelPuani"].ToString(),
                        YorumlananOtel= reader["OtelAdi"].ToString(),
                    };
                    OtelYorumlar.Add(otelyorum);
                }
                reader.Close();
                _baglanti.Close();
                return OtelYorumlar;
            }
        public void OtelEkle(Otel otel)
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand command = new SqlCommand("INSERT into OtelBilgi " +
                "values (@OtelAd,@il,@ilce,@Adres,@Telefon,@Eposta,@YildizSayisi,@OdaSayisi,@OtelPuani,@PlakaKodu)"
                , _baglanti);
            command.Parameters.AddWithValue("@OtelAd", otel.OtelAd);
            command.Parameters.AddWithValue("@il", otel.Il);
            command.Parameters.AddWithValue("@ilce", otel.Ilce);
            command.Parameters.AddWithValue("@Adres", otel.Adres);
            command.Parameters.AddWithValue("@Telefon", otel.Telefon);
            command.Parameters.AddWithValue("@Eposta", otel.Eposta);
            command.Parameters.AddWithValue("@YildizSayisi", otel.YildizSayisi);
            command.Parameters.AddWithValue("@OdaSayisi", otel.OdaSayisi);
            command.Parameters.AddWithValue("@OtelPuani", otel.OtelPuani);
            command.Parameters.AddWithValue("@PlakaKodu", otel.plakaKodu);
            command.ExecuteNonQuery();
            _baglanti.Close();
        }

        public void OtelSil(string OtelAd)
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }

            SqlCommand komutsil = new SqlCommand("Delete From OtelBilgi where OtelAd=@p1",_baglanti);
            komutsil.Parameters.AddWithValue("@p1",OtelAd);
            komutsil.ExecuteNonQuery();
            _baglanti.Close();          
        }
        public void OtelGuncelle(Otel otel)
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }       
                SqlCommand sc = new SqlCommand("UPDATE OtelBilgi SET " +
                "OtelAd=@p1,il=@p2,ilce=@p3,Adres=@p4,Telefon=@p5,Eposta=@p6,YildizSayisi=@p7,OdaSayisi=@p8,OtelPuani=@p9,PlakaKodu=@p10 where OtelAd=@p11",_baglanti);
                sc.Parameters.AddWithValue("@p1", otel.OtelAd);
                sc.Parameters.AddWithValue("@p2", otel.Il);
                sc.Parameters.AddWithValue("@p3", otel.Ilce);
                sc.Parameters.AddWithValue("@p4", otel.Adres);
                sc.Parameters.AddWithValue("@p5", otel.Telefon);
                sc.Parameters.AddWithValue("@p6", otel.Eposta);
                sc.Parameters.AddWithValue("@p7", otel.YildizSayisi);
                sc.Parameters.AddWithValue("@p8", otel.OdaSayisi);
                sc.Parameters.AddWithValue("@p9", otel.OtelPuani);
                sc.Parameters.AddWithValue("@p10", otel.plakaKodu);
               sc.Parameters.AddWithValue("@p11", otel.OtelAd);
            sc.ExecuteNonQuery();
            _baglanti.Close();            
        }





        public void PersonelEkle(Personel personel)
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO PersonelBilgi " +
                    "(TcNo,Ad,Soyad,Telefon,Adres,Eposta,Departman,Pozisyon,PersonelPuani,CalistigiOtel) " +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", _baglanti);
            command.Parameters.AddWithValue("@p1", personel.TC);
            command.Parameters.AddWithValue("@p2", personel.PerAd);
            command.Parameters.AddWithValue("@p3", personel.PerSoyad);
            command.Parameters.AddWithValue("@p4", personel.PerTelefon);
            command.Parameters.AddWithValue("@p5", personel.PerAdres);
            command.Parameters.AddWithValue("@p6", personel.PerEposta);
            command.Parameters.AddWithValue("@p7", personel.Departman);
            command.Parameters.AddWithValue("@p8", personel.Pozisyon);
            command.Parameters.AddWithValue("@p9", personel.PersonelPuani);
            command.Parameters.AddWithValue("@p10", personel.CalistigiOtel);
            command.ExecuteNonQuery();
            _baglanti.Dispose();
            _baglanti.Close();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void PersonelSil(string TcNo)
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }

            SqlCommand komutsil = new SqlCommand("Delete From PersonelBilgi where TcNo=@p1", _baglanti);
            komutsil.Parameters.AddWithValue("@p1", TcNo);
            komutsil.ExecuteNonQuery();
            _baglanti.Close();
        }

        public void PersonelGuncelle(Personel personel)
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand command = new SqlCommand("UPDATE PersonelBilgi SET Ad=@Ad,Soyad= @Soyad,Telefon= @Telefon,Adres= @Adres,Eposta= @Eposta,Departman= @Departman,Pozisyon= @Pozisyon, PersonelPuani=@PersonelPuani,CalistigiOtel= @CalistigiOtel where TcNo=@TcNo", _baglanti);
            //command.Parameters.AddWithValue("@TcNo", personel.TC);
            command.Parameters.AddWithValue("@Ad", personel.PerAd);
            command.Parameters.AddWithValue("@Soyad", personel.PerSoyad);
            command.Parameters.AddWithValue("@Telefon", personel.PerTelefon);
            command.Parameters.AddWithValue("@Adres", personel.PerAdres);
            command.Parameters.AddWithValue("@Eposta", personel.PerEposta);
            command.Parameters.AddWithValue("@Departman", personel.Departman);
            command.Parameters.AddWithValue("@Pozisyon", personel.Pozisyon);
            command.Parameters.AddWithValue("@PersonelPuani", personel.PersonelPuani);
            command.Parameters.AddWithValue("@CalistigiOtel", personel.CalistigiOtel);
            command.Parameters.AddWithValue("@TcNo", personel.TC);
            command.ExecuteNonQuery();

            _baglanti.Close();
        }
        public void OtelYorumEkle(OtelYorum otelyorum)
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }

            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO OtelDegerlendirme " +
                    "(YorumYapan,Yorumu,OtelPuani,OtelAdi) " +
                    "values (@p1,@p2,@p3,@p4)", _baglanti);
                command.Parameters.AddWithValue("@p1", otelyorum.YorumcuEposta);
                command.Parameters.AddWithValue("@p2", otelyorum.YorumMetni);
                command.Parameters.AddWithValue("@p3", otelyorum.YorumcuPuan);
                command.Parameters.AddWithValue("@p4", otelyorum.YorumlananOtel);
                command.ExecuteNonQuery();
                _baglanti.Dispose();
                _baglanti.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}

