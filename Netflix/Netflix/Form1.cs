using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netflix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            sifre_giris.PasswordChar = '*';
            this.AcceptButton = oturum_button;
            panel_kategori.Visible = false;
            panel_icerik.Visible = false;
            anasayfa_icon_Click(null, new EventArgs());
        }

        public string uyari_title = "Uyarı";
        public string uyari_mesaji = "Bilgileri eksiksiz giriniz!";
        public string uyari_mesaji_email = "Geçerli bir email giriniz!";
        public string uyari_mesaji_email_var = "Bu email hesabıyla kayıtlı bir kullanıcı zaten var!";
        public string uyari_mesaji_dogumtarihi = "Geçerli bir doğum tarihi giriniz!";
        public string kayit_basarili_title = "OK";
        public string kayit_basarili = "Kaydınız başarıyla gerçekleştirildi!";
        public string uyari_mesaji_vd_kullanici = "Bu email adresiyle kayıtlı bir kullanıcı bulunmamaktadır! Yeni kayıt eklemek ister misiniz?";
        public string uyari_hatali_sifre = "Hatalı şifre girdiniz!";
        public string uyari_kategori = "En fazla 3 adet kategori seçebilirsiniz!";
        public string uyari_kategori2 = "3 kategori seçin!";
        public MessageBoxButtons button_ok = MessageBoxButtons.OK;
        public MessageBoxButtons buttons = MessageBoxButtons.YesNo;

        private void kayıt_label_Click(object sender, EventArgs e)
        {
            panel_giris.Visible = false;
            this.Controls.Add(panel_kayit);
            panel_kayit.Visible = true;
            this.AcceptButton = kayit_button;
            sifre_textbox.PasswordChar = '*';
        }

        private void kayit_ol(object sender, EventArgs e)
        {
            DateTime dogumtarihi;
            bool vd_dogumtarihi = DateTime.TryParseExact(dogumtarihi_textbox.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dogumtarihi);

            Regex ValidEmailRegex = CreateValidEmailRegex();
            Regex CreateValidEmailRegex()
            {
                string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                    + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                    + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

                return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
            }
            bool vd_email = ValidEmailRegex.IsMatch(email_textbox.Text);

            Veritabani veritabani = new Veritabani();

            if (email_textbox.Text == "" || sifre_textbox.Text == "" || kullanici_adi_textbox.Text == "" || dogumtarihi_textbox.Text == "")
            {
                MessageBox.Show(uyari_mesaji, uyari_title, button_ok, MessageBoxIcon.Warning);
            }else if (veritabani.kullanici_varlik_kontrol(email_textbox.Text) == 1)
            {
                MessageBox.Show(uyari_mesaji_email_var, uyari_title, button_ok, MessageBoxIcon.Warning);
            }
            else if (vd_dogumtarihi == false)
            {
                MessageBox.Show(uyari_mesaji_dogumtarihi, uyari_title, button_ok, MessageBoxIcon.Warning);
            }
            else if (vd_email == false)
            {
                MessageBox.Show(uyari_mesaji_email, uyari_title, button_ok, MessageBoxIcon.Warning);
            }
            else
            {
                veritabani.kullanici_ekle(kullanici_adi_textbox.Text, email_textbox.Text, sifre_textbox.Text, dogumtarihi);
                MessageBox.Show(kayit_basarili, kayit_basarili_title, button_ok, MessageBoxIcon.Information);
                panel_giris.Visible = false;
                panel_kayit.Visible = false;
                this.Controls.Add(panel_kategorisec);
                panel_kategorisec.Visible = true;
            }
        }

        private void oturum_button_Click(object sender, EventArgs e)
        {
            Regex ValidEmailRegex = CreateValidEmailRegex();
            Regex CreateValidEmailRegex()
            {
                string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                    + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                    + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

                return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
            }
            bool vd_email = ValidEmailRegex.IsMatch(email_giris.Text);
            if (vd_email == false)
            {
                MessageBox.Show(uyari_mesaji_email, uyari_title, button_ok, MessageBoxIcon.Warning);
            }
            else
            {
                Veritabani veritabani = new Veritabani();
                int vd_kullanıcı = veritabani.kullanici_kontrol(email_giris.Text, sifre_giris.Text);
                if (vd_kullanıcı == 0)
                {
                    DialogResult buton = MessageBox.Show(uyari_mesaji_vd_kullanici, uyari_title, buttons, MessageBoxIcon.Warning);
                    if (buton == DialogResult.Yes)
                    {
                        this.kayıt_label_Click(null, new EventArgs());
                    }
                    else
                    {
                        panel_kayit.Visible = false;
                        panel_giris.Visible = true;
                    }
                }
                else if (vd_kullanıcı == 1)
                {
                    panel_giris.Visible = false;
                    string aktif_kullanici_adi = veritabani.kullanici_adi_getir(email_giris.Text);
                    KullaniciAdi_label.Text = aktif_kullanici_adi;
                    panel_kategori.Visible = true;
                    panel_icerik.Visible = true;
                    panel_icerik.AutoScroll = true;
                }
                else
                {
                    MessageBox.Show(uyari_hatali_sifre, uyari_title, button_ok, MessageBoxIcon.Warning);
                }
            }
        }

        public List<CheckBox> kategori_box = new List<CheckBox>();

        private void but_kategorisec_Click(object sender, EventArgs e)
        {
            Veritabani veritabani = new Veritabani();
            kategori_box.Add(checkBox1);
            kategori_box.Add(checkBox2);
            kategori_box.Add(checkBox3);
            kategori_box.Add(checkBox4);
            kategori_box.Add(checkBox5);
            kategori_box.Add(checkBox6);
            kategori_box.Add(checkBox7);
            kategori_box.Add(checkBox8);
            kategori_box.Add(checkBox9);
            kategori_box.Add(checkBox10);
            kategori_box.Add(checkBox11);
            kategori_box.Add(checkBox12);
            int sayac = 0;
            for (int i = 0; i < 12; i++)
            {
                if (kategori_box[i].Checked)
                {
                    sayac++;
                }
            }
            if (sayac == 3)
            {
                panel_giris.Visible = false;
                panel_kategorisec.Visible = false;
                string aktif_kullanici_adi = veritabani.kullanici_adi_getir(email_textbox.Text);
                KullaniciAdi_label.Text = aktif_kullanici_adi;
                panel_kategori.Visible = true;
                panel_icerik.Visible = true;
                panel_icerik.AutoScroll = true;
            }
            else if(sayac > 3)
            {
                MessageBox.Show(uyari_kategori, uyari_title, button_ok, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(uyari_kategori2, uyari_title, button_ok, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel_kayit.Visible = false;
            panel_giris.Visible = true;
        }

        private List<int> gosterilecek_icerikler_listesi(int turıd)
        {
            Veritabani veritabani = new Veritabani();
            List<int> show_by_category_list = veritabani.kategoriye_gore_liste(turıd.ToString());
            return show_by_category_list;
        }

        public void draw_boxes(List<string> icerikler_listesi)
        {
            ContentBox contentbox = new ContentBox();
            panel_icerik.Controls.Clear();
            int x = 12, y = 12, x_artis = 185, y_artis = 265;
            int index = 0;
            for (int i = 0; i <= (icerikler_listesi.Count / 4); i++)
            {
                x = 12;
                for (int j = 0; j < 4; j++)
                {
                    try
                    {
                        contentbox.draw(panel_icerik, x, y, $"..\\..\\icerik_gorselleri\\{icerikler_listesi[index]}.jpg", icerikler_listesi[index]);                      
                    }
                    catch
                    {

                    }
                    x += x_artis;
                    index += 1;
                }
                y += y_artis;
                GC.Collect();
            }
        }

        private void AksiyonveMacera_Click(object sender, EventArgs e)
        {
            panel_icerik.Controls.Clear();
            Veritabani veritabani = new Veritabani();
            List<string> cizdirilecek_programlar_list = veritabani.program_adi_get(gosterilecek_icerikler_listesi(1));
            draw_boxes(cizdirilecek_programlar_list);
        }

        private void Anime_Click(object sender, EventArgs e)
        {
            panel_icerik.Controls.Clear();
            Veritabani veritabani = new Veritabani();
            List<string> cizdirilecek_programlar_list = veritabani.program_adi_get(gosterilecek_icerikler_listesi(2));
            draw_boxes(cizdirilecek_programlar_list);
        }

        private void Belgesel_Click(object sender, EventArgs e)
        {
            panel_icerik.Controls.Clear();
            Veritabani veritabani = new Veritabani();
            List<string> cizdirilecek_programlar_list = veritabani.program_adi_get(gosterilecek_icerikler_listesi(3));
            draw_boxes(cizdirilecek_programlar_list);
        }

        private void BilimKurguveFantastik_Click(object sender, EventArgs e)
        {
            panel_icerik.Controls.Clear();
            Veritabani veritabani = new Veritabani();
            List<string> cizdirilecek_programlar_list = veritabani.program_adi_get(gosterilecek_icerikler_listesi(4));
            draw_boxes(cizdirilecek_programlar_list);
        }

        private void BilimveDoğa_Click(object sender, EventArgs e)
        {
            panel_icerik.Controls.Clear();
            Veritabani veritabani = new Veritabani();
            List<string> cizdirilecek_programlar_list = veritabani.program_adi_get(gosterilecek_icerikler_listesi(5));
            draw_boxes(cizdirilecek_programlar_list);
        }

        private void ÇocukveAile_Click(object sender, EventArgs e)
        {
            panel_icerik.Controls.Clear();
            Veritabani veritabani = new Veritabani();
            List<string> cizdirilecek_programlar_list = veritabani.program_adi_get(gosterilecek_icerikler_listesi(6));
            draw_boxes(cizdirilecek_programlar_list);
        }

        private void Drama_Click(object sender, EventArgs e)
        {
            panel_icerik.Controls.Clear();
            Veritabani veritabani = new Veritabani();
            List<string> cizdirilecek_programlar_list = veritabani.program_adi_get(gosterilecek_icerikler_listesi(7));
            draw_boxes(cizdirilecek_programlar_list);
        }

        private void Gerilim_Click(object sender, EventArgs e)
        {
            panel_icerik.Controls.Clear();
            Veritabani veritabani = new Veritabani();
            List<string> cizdirilecek_programlar_list = veritabani.program_adi_get(gosterilecek_icerikler_listesi(8));
            draw_boxes(cizdirilecek_programlar_list);
        }

        private void Komedi_Click(object sender, EventArgs e)
        {
            panel_icerik.Controls.Clear();
            Veritabani veritabani = new Veritabani();
            List<string> cizdirilecek_programlar_list = veritabani.program_adi_get(gosterilecek_icerikler_listesi(9));
            draw_boxes(cizdirilecek_programlar_list);
        }

        private void Korku_Click(object sender, EventArgs e)
        {
            panel_icerik.Controls.Clear();
            Veritabani veritabani = new Veritabani();
            List<string> cizdirilecek_programlar_list = veritabani.program_adi_get(gosterilecek_icerikler_listesi(10));
            draw_boxes(cizdirilecek_programlar_list);
        }

        private void RealityProgram_Click(object sender, EventArgs e)
        {
            panel_icerik.Controls.Clear();
            Veritabani veritabani = new Veritabani();
            List<string> cizdirilecek_programlar_list = veritabani.program_adi_get(gosterilecek_icerikler_listesi(11));
            draw_boxes(cizdirilecek_programlar_list);
        }

        private void Romantik_Click(object sender, EventArgs e)
        {
            panel_icerik.Controls.Clear();
            Veritabani veritabani = new Veritabani();
            List<string> cizdirilecek_programlar_list = veritabani.program_adi_get(gosterilecek_icerikler_listesi(12));
            draw_boxes(cizdirilecek_programlar_list);
        }

        private void textBox_arama_TextChanged(object sender, EventArgs e)
        {
            Veritabani veritabani = new Veritabani();
            List<string> arama_sonucu = veritabani.arama_sonuclari_get(textBox_arama.Text);
            draw_boxes(arama_sonucu);
        }

        private void anasayfa_icon_Click(object sender, EventArgs e)
        {
            Veritabani veritabani = new Veritabani();
            List<string> icerikler_listesi = veritabani.icerikler();
            draw_boxes(icerikler_listesi);
        }
    }
}