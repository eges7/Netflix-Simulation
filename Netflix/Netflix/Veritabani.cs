using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Netflix
{
    public class Veritabani
    {
        string kisisel_baglanti_stringi = "DESKTOP-KRGF8H7\\SQLEXPRESS";
        SqlConnection baglanti;
        SqlCommand komut;
        
        public void kullanici_ekle(string ad, string email, string sifre, DateTime dogumtarihi)
        {
            baglanti = new SqlConnection("Data Source=" + kisisel_baglanti_stringi + ";Initial Catalog=Netflix;Integrated Security=SSPI");
            string kullanici_ekle_sorgu = "INSERT INTO Kullanıcılar(Ad, Email, Şifre, DoğumTarihi) VALUES (@ad, @email, @sifre, @dogumtarihi)";
            baglanti.Open();
            komut = new SqlCommand(kullanici_ekle_sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@email", email);
            komut.Parameters.AddWithValue("@sifre", sifre);
            komut.Parameters.AddWithValue("@dogumtarihi", dogumtarihi);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public int kullanici_varlik_kontrol(string email)
        {
            baglanti = new SqlConnection("Data Source=" + kisisel_baglanti_stringi + ";Initial Catalog=Netflix;Integrated Security=SSPI");
            string kullanici_varlik_kontrol_sorgu = "SELECT COUNT(1) FROM Kullanıcılar WHERE Email = '" + email + "';";
            baglanti.Open();
            komut = new SqlCommand(kullanici_varlik_kontrol_sorgu, baglanti);
            int sonuc = (int)komut.ExecuteScalar();
            baglanti.Close();
            return sonuc;
        }

        public int kullanici_kontrol(string email, string sifre)
        {
            baglanti = new SqlConnection("Data Source=" + kisisel_baglanti_stringi + ";Initial Catalog=Netflix;Integrated Security=SSPI");
            string kullanici_kontrol_sorgu = "SELECT COUNT(1) FROM Kullanıcılar WHERE Email = '" + email + "';";
            baglanti.Open();
            komut = new SqlCommand(kullanici_kontrol_sorgu, baglanti);
            int sonuc = (int)komut.ExecuteScalar();
            if (sonuc == 1)
            {
                string kullanici_id = "SELECT Id FROM Kullanıcılar WHERE Email = '" + email + "';";
                komut = new SqlCommand(kullanici_id, baglanti);
                int aktif_kullanici_id = (int)komut.ExecuteScalar();
                string kullanici_sifre = "SELECT Şifre FROM Kullanıcılar WHERE Id = " + aktif_kullanici_id.ToString() + ";";
                komut = new SqlCommand(kullanici_sifre, baglanti);
                string aktif_kullanici_sifre = (string)komut.ExecuteScalar();

                baglanti.Close();
                if (sifre == aktif_kullanici_sifre)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return 0;
            }
        }

        public string kullanici_adi_getir(string email)
        {
            baglanti = new SqlConnection("Data Source=" + kisisel_baglanti_stringi + ";Initial Catalog=Netflix;Integrated Security=SSPI");
            baglanti.Open();

            string kullanici_adi_sorgu = "SELECT Ad FROM Kullanıcılar WHERE Email = '" + email + "';";
            komut = new SqlCommand(kullanici_adi_sorgu, baglanti);
            string kullanici_adi = (string)komut.ExecuteScalar();

            baglanti.Close();
            return kullanici_adi;
        }

        public List<string> icerikler()
        {
            List<string> icerikler_listesi = new List<string>();
            baglanti = new SqlConnection("Data Source=" + kisisel_baglanti_stringi + ";Initial Catalog=Netflix;Integrated Security=SSPI");
            baglanti.Open();

            string icerikler_sorgu = "SELECT Ad FROM Programlar";
            komut = new SqlCommand(icerikler_sorgu, baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                icerikler_listesi.Add(reader.GetString(0));
            }

            reader.Close();
            baglanti.Close();
            return icerikler_listesi;
        }

        public List<int> kategoriye_gore_liste(string kategori_adi)
        {
            List<int> filmler = new List<int>();
            baglanti = new SqlConnection("Data Source=" + kisisel_baglanti_stringi + ";Initial Catalog=Netflix;Integrated Security=SSPI");
            baglanti.Open();

            string filmler_sorgu = "SELECT ProgramId FROM ProgramTür WHERE TürId = " + kategori_adi + ";";
            komut = new SqlCommand(filmler_sorgu, baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                filmler.Add(reader.GetInt32(0));
            }

            reader.Close();
            baglanti.Close();
            return filmler;
        }

        public List<string> program_adi_get(List<int> program_id_listesi)
        {
            List<string> program_adlari_listesi = new List<string>();
            baglanti = new SqlConnection("Data Source=" + kisisel_baglanti_stringi + ";Initial Catalog=Netflix;Integrated Security=SSPI");
            baglanti.Open();

            for(int index = 0; index < program_id_listesi.Count; index++)
            {
                string program_adlari_sorgu = "SELECT Ad FROM Programlar WHERE Id = " + program_id_listesi[index].ToString() + ";";
                komut = new SqlCommand(program_adlari_sorgu, baglanti);
                SqlDataReader reader = komut.ExecuteReader();
                reader.Read();
                program_adlari_listesi.Add(reader.GetString(0));
                reader.Close();
            }

            baglanti.Close();
            return program_adlari_listesi;
        }

        public List<string> arama_sonuclari_get(string aranan_kelime)
        {
            List<string> arama_sonuclari = new List<string>();
            baglanti = new SqlConnection("Data Source=" + kisisel_baglanti_stringi + ";Initial Catalog=Netflix;Integrated Security=SSPI");
            baglanti.Open();

            string arama_sorgu = "SELECT * FROM Programlar WHERE Ad LIKE '%" + aranan_kelime + "%';";
            komut = new SqlCommand(arama_sorgu, baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                arama_sonuclari.Add(reader.GetString(1));
            }

            reader.Close();
            baglanti.Close();
            return arama_sonuclari;
        }

        public string program_tipi_get(string name)
        {
            string tip;
            baglanti = new SqlConnection("Data Source=" + kisisel_baglanti_stringi + ";Initial Catalog=Netflix;Integrated Security=SSPI");
            baglanti.Open();

            name = kacis_karakteri(name);
            string program_tipi_sorgu = $"SELECT Tip FROM Programlar WHERE Ad = '{name}';";
            komut = new SqlCommand(program_tipi_sorgu, baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            reader.Read();
            tip = reader.GetString(0);

            reader.Close();
            baglanti.Close();
            return tip;
        }

        public int program_bolum_sayisi_get(string name)
        {
            int bolum_sayisi;
            baglanti = new SqlConnection("Data Source=" + kisisel_baglanti_stringi + ";Initial Catalog=Netflix;Integrated Security=SSPI");
            baglanti.Open();

            name = kacis_karakteri(name);
            string program_bolumsayisi_sorgu = $"SELECT BölümSayisi FROM Programlar WHERE Ad = '{name}';";
            komut = new SqlCommand(program_bolumsayisi_sorgu, baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            reader.Read();
            bolum_sayisi = reader.GetInt32(0);

            reader.Close();
            baglanti.Close();
            return bolum_sayisi;
        }

        public int program_uzunluk_getir(string name)
        {
            int uzunluk;
            baglanti = new SqlConnection("Data Source=" + kisisel_baglanti_stringi + ";Initial Catalog=Netflix;Integrated Security=SSPI");
            baglanti.Open();

            name = kacis_karakteri(name);
            string program_uzunluk_sorgu = $"SELECT Uzunluk FROM Programlar WHERE Ad = '{name}';";
            komut = new SqlCommand(program_uzunluk_sorgu, baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            reader.Read();
            uzunluk = reader.GetInt32(0);

            reader.Close();
            baglanti.Close();
            return uzunluk;
        }

        public string kacis_karakteri(string name)
        {
            string modded = name;
            int sonuc = name.IndexOf("'");
            if (sonuc > 0)
            {
                modded = modded.Insert(sonuc, "'");
            }
            return modded; 
        }

    }
}

