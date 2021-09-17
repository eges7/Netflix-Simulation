using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netflix
{
    public class ContentBox 
    {   
        public Form form_popup = new Form();

        public void draw(Panel icerik_paneli, int x, int y, string path, string name)
        {
            PictureBox icerik_box = new PictureBox();
            icerik_box.BackgroundImageLayout = ImageLayout.Stretch;
            icerik_box.Size = new System.Drawing.Size(169, 250);
            icerik_box.Location = new System.Drawing.Point(x, y);
            icerik_box.BackColor = System.Drawing.Color.White;
            icerik_box.BackgroundImage = Image.FromFile(path);
            icerik_box.Click += delegate (object sender, EventArgs e) { click_icerik_box(sender, e, name, path); };
            icerik_paneli.Controls.Add(icerik_box);
        }

        private void click_icerik_box(object sender, EventArgs e, string name, string path)
        {
            Panel panel_popup = draw_panel_popup();
            build_form(form_popup);

            if(form_popup.Visible == false)
            {
                form_popup.Visible = true;
            }
            form_popup.Controls.Add(panel_popup);

            draw_button_durdur(panel_popup);
            draw_button_baslat(panel_popup);
            draw_puan(panel_popup);
            draw_player(panel_popup);
            draw_button_back(panel_popup);
            draw_labels(name, panel_popup);
            draw_image_box(panel_popup, 30, 30, path, name);
        }

        public Form build_form(Form form_popup)
        {
            form_popup.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form_popup.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form_popup.BackColor = System.Drawing.SystemColors.Control;
            form_popup.ClientSize = new System.Drawing.Size(1024, 768);
            form_popup.FormBorderStyle = FormBorderStyle.FixedSingle;
            form_popup.MaximizeBox = false;
            form_popup.StartPosition = FormStartPosition.CenterScreen;
            form_popup.ShowInTaskbar = false;
            form_popup.ControlBox = false;
            return form_popup;
        }

        public Panel draw_panel_popup()
        {
            Panel panel_popup = new Panel();
            panel_popup.BackColor = Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            panel_popup.ForeColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            panel_popup.Location = new System.Drawing.Point(0, 0);
            panel_popup.Size = new System.Drawing.Size(1024, 768);
            return panel_popup;
        }

        public void draw_button_back(Panel icerik_paneli)
        {
            Button button_back = new Button();
            button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            button_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_back.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button_back.ForeColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            button_back.Location = new System.Drawing.Point(919, 30);
            button_back.Size = new System.Drawing.Size(75, 50);
            button_back.Text = "Geri";
            button_back.UseVisualStyleBackColor = false;
            button_back.Click += button_back_click;
            icerik_paneli.Controls.Add(button_back);
        }

        private void button_back_click(object sender, EventArgs e)
        {
            form_popup.Visible = false;
            form_popup.Controls.Clear();
        }

        public void draw_image_box(Panel icerik_paneli, int x, int y, string path, string name)
        {
            PictureBox icerik_box = new PictureBox();
            icerik_box.BackgroundImageLayout = ImageLayout.Stretch;
            icerik_box.Size = new System.Drawing.Size(350, 500);
            icerik_box.Location = new System.Drawing.Point(x, y);
            icerik_box.BackColor = System.Drawing.Color.White;
            icerik_box.BackgroundImage = Image.FromFile(path);
            icerik_box.Click += delegate (object sender, EventArgs e) { click_icerik_box(sender, e, name, path); };
            icerik_paneli.Controls.Add(icerik_box);
        }

        public void draw_labels(string name, Panel icerik_paneli)
        {
            Veritabani veritabani = new Veritabani();
            string tip = veritabani.program_tipi_get(name);
            int bolum_sayisi = veritabani.program_bolum_sayisi_get(name);
            int uzunluk = veritabani.program_uzunluk_getir(name);

            Label label_ad = new Label();
            label_ad.AutoSize = true;
            label_ad.BackColor = System.Drawing.Color.Transparent;
            label_ad.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label_ad.Text = $"# Program Adı:  {name}";
            label_ad.Location = new System.Drawing.Point(30, 40+525);
            icerik_paneli.Controls.Add(label_ad);

            Label label_tip = new Label();
            label_tip.AutoSize = true;
            label_tip.BackColor = System.Drawing.Color.Transparent;
            label_tip.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label_tip.Text = $"# Program Tipi:  {tip}";
            label_tip.Location = new System.Drawing.Point(30, 70+525);
            icerik_paneli.Controls.Add(label_tip);

            Label label_bolum = new Label();
            label_bolum.AutoSize = true;
            label_bolum.BackColor = System.Drawing.Color.Transparent;
            label_bolum.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_bolum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label_bolum.Text = $"# Bölüm Sayisi:  {bolum_sayisi}";
            label_bolum.Location = new System.Drawing.Point(30, 100+525);
            icerik_paneli.Controls.Add(label_bolum);

            Label label_uzunluk = new Label();
            label_uzunluk.AutoSize = true;
            label_uzunluk.BackColor = System.Drawing.Color.Transparent;
            label_uzunluk.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_uzunluk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label_uzunluk.Text = $"# Toplam Uzunluk:  {uzunluk} dk";
            label_uzunluk.Location = new System.Drawing.Point(30, 130+525);
            icerik_paneli.Controls.Add(label_uzunluk);

        }

        public void draw_player(Panel icerik_paneli)
        {
            PictureBox player_box = new PictureBox();
            player_box.BackgroundImageLayout = ImageLayout.Stretch;
            player_box.Size = new System.Drawing.Size(584, 375);
            player_box.Location = new System.Drawing.Point(410, 105);
            player_box.BackColor = System.Drawing.Color.White;
            player_box.BackgroundImage = Image.FromFile("..\\..\\icerik_gorselleri\\video-player.jpg");
            icerik_paneli.Controls.Add(player_box);
        }

        public void draw_puan(Panel icerik_paneli)
        {
            ComboBox puan_box = new ComboBox();
            for(int i=1; i<=10; i++)
            {
                puan_box.Items.Add(i);
            }
            puan_box.Text = "Puan";
            puan_box.AutoSize = true;
            puan_box.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            puan_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            puan_box.Location = new System.Drawing.Point(914, 498);
            puan_box.Size = new System.Drawing.Size(80, 20);
            puan_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            puan_box.FlatStyle = FlatStyle.Flat;



            icerik_paneli.Controls.Add(puan_box);
        }

        public void draw_button_baslat(Panel icerik_paneli)
        {
            Button button_baslat = new Button();
            button_baslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            button_baslat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            button_baslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_baslat.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button_baslat.ForeColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            button_baslat.Location = new System.Drawing.Point(410, 498);
            button_baslat.Size = new System.Drawing.Size(75, 32);
            button_baslat.Text = "Yürüt";
            button_baslat.UseVisualStyleBackColor = false;
            button_baslat.Click += delegate (object sender, EventArgs e) { button_baslat_click(sender, e); };
            icerik_paneli.Controls.Add(button_baslat);
        }

        public void draw_button_durdur(Panel icerik_paneli)
        {
            Button button_durdur = new Button();
            button_durdur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            button_durdur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            button_durdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_durdur.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button_durdur.ForeColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            button_durdur.Location = new System.Drawing.Point(515, 498);
            button_durdur.Size = new System.Drawing.Size(80, 32);
            button_durdur.Text = "Durdur";
            button_durdur.UseVisualStyleBackColor = false;
            button_durdur.Click += delegate (object sender, EventArgs e) { button_durdur_click(sender, e); };
            icerik_paneli.Controls.Add(button_durdur);
        }

        private void button_durdur_click(object sender, EventArgs e)
        {
            //TODO
        }

        private void button_baslat_click(object sender, EventArgs e)
        {
            //TODO
        }
    } 
}
