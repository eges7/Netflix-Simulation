using Microsoft.Win32;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Netflix
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer üretilen kod
        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_kayit = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kayit_button = new System.Windows.Forms.Button();
            this.dogumtarihi_textbox = new System.Windows.Forms.MaskedTextBox();
            this.sifre_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.kullanici_adi_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_giris = new System.Windows.Forms.Panel();
            this.oturum_button = new System.Windows.Forms.Button();
            this.kayıt_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sifre_giris = new System.Windows.Forms.TextBox();
            this.email_giris = new System.Windows.Forms.TextBox();
            this.panel_kategorisec = new System.Windows.Forms.Panel();
            this.but_kategorisec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel_kategori = new System.Windows.Forms.Panel();
            this.anasayfa_icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Kategori_label = new System.Windows.Forms.Label();
            this.KullaniciAdi_label = new System.Windows.Forms.Label();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.textBox_arama = new System.Windows.Forms.TextBox();
            this.Romantik = new System.Windows.Forms.Label();
            this.RealityProgram = new System.Windows.Forms.Label();
            this.Korku = new System.Windows.Forms.Label();
            this.Komedi = new System.Windows.Forms.Label();
            this.Gerilim = new System.Windows.Forms.Label();
            this.Drama = new System.Windows.Forms.Label();
            this.ÇocukveAile = new System.Windows.Forms.Label();
            this.BilimveDoğa = new System.Windows.Forms.Label();
            this.BilimKurguveFantastik = new System.Windows.Forms.Label();
            this.Belgesel = new System.Windows.Forms.Label();
            this.Anime = new System.Windows.Forms.Label();
            this.AksiyonveMacera = new System.Windows.Forms.Label();
            this.panel_icerik = new System.Windows.Forms.Panel();
            this.panel_kayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_giris.SuspendLayout();
            this.panel_kategorisec.SuspendLayout();
            this.panel_kategori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anasayfa_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_kayit
            // 
            this.panel_kayit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_kayit.BackgroundImage")));
            this.panel_kayit.Controls.Add(this.pictureBox1);
            this.panel_kayit.Controls.Add(this.kayit_button);
            this.panel_kayit.Controls.Add(this.dogumtarihi_textbox);
            this.panel_kayit.Controls.Add(this.sifre_textbox);
            this.panel_kayit.Controls.Add(this.email_textbox);
            this.panel_kayit.Controls.Add(this.kullanici_adi_textbox);
            this.panel_kayit.Controls.Add(this.label8);
            this.panel_kayit.Controls.Add(this.label7);
            this.panel_kayit.Controls.Add(this.label6);
            this.panel_kayit.Controls.Add(this.label5);
            this.panel_kayit.Location = new System.Drawing.Point(0, 0);
            this.panel_kayit.Name = "panel_kayit";
            this.panel_kayit.Size = new System.Drawing.Size(1024, 768);
            this.panel_kayit.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 547);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kayit_button
            // 
            this.kayit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.kayit_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.kayit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayit_button.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayit_button.ForeColor = System.Drawing.Color.Silver;
            this.kayit_button.Location = new System.Drawing.Point(519, 547);
            this.kayit_button.Name = "kayit_button";
            this.kayit_button.Size = new System.Drawing.Size(128, 34);
            this.kayit_button.TabIndex = 28;
            this.kayit_button.Text = "Kayıt Ol";
            this.kayit_button.UseVisualStyleBackColor = false;
            this.kayit_button.Click += new System.EventHandler(this.kayit_ol);
            // 
            // dogumtarihi_textbox
            // 
            this.dogumtarihi_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dogumtarihi_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dogumtarihi_textbox.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogumtarihi_textbox.ForeColor = System.Drawing.Color.Gray;
            this.dogumtarihi_textbox.Location = new System.Drawing.Point(388, 485);
            this.dogumtarihi_textbox.Mask = "00/00/0000";
            this.dogumtarihi_textbox.Name = "dogumtarihi_textbox";
            this.dogumtarihi_textbox.PromptChar = '#';
            this.dogumtarihi_textbox.Size = new System.Drawing.Size(111, 34);
            this.dogumtarihi_textbox.TabIndex = 26;
            this.dogumtarihi_textbox.ValidatingType = typeof(System.DateTime);
            // 
            // sifre_textbox
            // 
            this.sifre_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sifre_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifre_textbox.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre_textbox.ForeColor = System.Drawing.Color.Silver;
            this.sifre_textbox.Location = new System.Drawing.Point(388, 400);
            this.sifre_textbox.Name = "sifre_textbox";
            this.sifre_textbox.Size = new System.Drawing.Size(256, 34);
            this.sifre_textbox.TabIndex = 25;
            // 
            // email_textbox
            // 
            this.email_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_textbox.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textbox.ForeColor = System.Drawing.Color.Silver;
            this.email_textbox.Location = new System.Drawing.Point(388, 315);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(256, 34);
            this.email_textbox.TabIndex = 24;
            // 
            // kullanici_adi_textbox
            // 
            this.kullanici_adi_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kullanici_adi_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kullanici_adi_textbox.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanici_adi_textbox.ForeColor = System.Drawing.Color.Silver;
            this.kullanici_adi_textbox.Location = new System.Drawing.Point(388, 230);
            this.kullanici_adi_textbox.Name = "kullanici_adi_textbox";
            this.kullanici_adi_textbox.Size = new System.Drawing.Size(256, 34);
            this.kullanici_adi_textbox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(384, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 27);
            this.label8.TabIndex = 22;
            this.label8.Text = "Doğum Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(384, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kullanıcı Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(384, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(384, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email:";
            // 
            // panel_giris
            // 
            this.panel_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_giris.BackgroundImage")));
            this.panel_giris.Controls.Add(this.oturum_button);
            this.panel_giris.Controls.Add(this.kayıt_label);
            this.panel_giris.Controls.Add(this.label2);
            this.panel_giris.Controls.Add(this.label1);
            this.panel_giris.Controls.Add(this.sifre_giris);
            this.panel_giris.Controls.Add(this.email_giris);
            this.panel_giris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_giris.Location = new System.Drawing.Point(0, 0);
            this.panel_giris.Name = "panel_giris";
            this.panel_giris.Size = new System.Drawing.Size(1008, 729);
            this.panel_giris.TabIndex = 28;
            // 
            // oturum_button
            // 
            this.oturum_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.oturum_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.oturum_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oturum_button.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oturum_button.ForeColor = System.Drawing.Color.Silver;
            this.oturum_button.Location = new System.Drawing.Point(519, 578);
            this.oturum_button.Margin = new System.Windows.Forms.Padding(0);
            this.oturum_button.Name = "oturum_button";
            this.oturum_button.Size = new System.Drawing.Size(128, 34);
            this.oturum_button.TabIndex = 28;
            this.oturum_button.Text = "Oturum Aç";
            this.oturum_button.UseVisualStyleBackColor = false;
            this.oturum_button.Click += new System.EventHandler(this.oturum_button_Click);
            // 
            // kayıt_label
            // 
            this.kayıt_label.AutoSize = true;
            this.kayıt_label.BackColor = System.Drawing.Color.Transparent;
            this.kayıt_label.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayıt_label.ForeColor = System.Drawing.Color.Silver;
            this.kayıt_label.Location = new System.Drawing.Point(561, 532);
            this.kayıt_label.Name = "kayıt_label";
            this.kayıt_label.Size = new System.Drawing.Size(86, 14);
            this.kayıt_label.TabIndex = 11;
            this.kayıt_label.Text = "Netflix\'e üye ol !";
            this.kayıt_label.Click += new System.EventHandler(this.kayıt_label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(387, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(384, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email:";
            // 
            // sifre_giris
            // 
            this.sifre_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sifre_giris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifre_giris.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre_giris.ForeColor = System.Drawing.Color.Silver;
            this.sifre_giris.Location = new System.Drawing.Point(391, 496);
            this.sifre_giris.Name = "sifre_giris";
            this.sifre_giris.Size = new System.Drawing.Size(256, 32);
            this.sifre_giris.TabIndex = 7;
            // 
            // email_giris
            // 
            this.email_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email_giris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_giris.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_giris.ForeColor = System.Drawing.Color.Silver;
            this.email_giris.Location = new System.Drawing.Point(388, 411);
            this.email_giris.Name = "email_giris";
            this.email_giris.Size = new System.Drawing.Size(256, 34);
            this.email_giris.TabIndex = 6;
            // 
            // panel_kategorisec
            // 
            this.panel_kategorisec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_kategorisec.BackgroundImage")));
            this.panel_kategorisec.Controls.Add(this.but_kategorisec);
            this.panel_kategorisec.Controls.Add(this.label3);
            this.panel_kategorisec.Controls.Add(this.checkBox12);
            this.panel_kategorisec.Controls.Add(this.checkBox11);
            this.panel_kategorisec.Controls.Add(this.checkBox10);
            this.panel_kategorisec.Controls.Add(this.checkBox9);
            this.panel_kategorisec.Controls.Add(this.checkBox8);
            this.panel_kategorisec.Controls.Add(this.checkBox7);
            this.panel_kategorisec.Controls.Add(this.checkBox6);
            this.panel_kategorisec.Controls.Add(this.checkBox5);
            this.panel_kategorisec.Controls.Add(this.checkBox4);
            this.panel_kategorisec.Controls.Add(this.checkBox3);
            this.panel_kategorisec.Controls.Add(this.checkBox2);
            this.panel_kategorisec.Controls.Add(this.checkBox1);
            this.panel_kategorisec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_kategorisec.Location = new System.Drawing.Point(0, 0);
            this.panel_kategorisec.Name = "panel_kategorisec";
            this.panel_kategorisec.Size = new System.Drawing.Size(1008, 729);
            this.panel_kategorisec.TabIndex = 29;
            // 
            // but_kategorisec
            // 
            this.but_kategorisec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.but_kategorisec.FlatAppearance.BorderSize = 0;
            this.but_kategorisec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_kategorisec.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_kategorisec.ForeColor = System.Drawing.Color.Silver;
            this.but_kategorisec.Location = new System.Drawing.Point(688, 488);
            this.but_kategorisec.Name = "but_kategorisec";
            this.but_kategorisec.Size = new System.Drawing.Size(146, 47);
            this.but_kategorisec.TabIndex = 43;
            this.but_kategorisec.Text = "Devam et";
            this.but_kategorisec.UseVisualStyleBackColor = false;
            this.but_kategorisec.Click += new System.EventHandler(this.but_kategorisec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(161, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 27);
            this.label3.TabIndex = 42;
            this.label3.Text = "# Önerilenleriniz için en fazla 3 kategori seçin...";
            // 
            // checkBox12
            // 
            this.checkBox12.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox12.AutoSize = true;
            this.checkBox12.BackColor = System.Drawing.Color.Transparent;
            this.checkBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox12.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.ForeColor = System.Drawing.Color.Gray;
            this.checkBox12.Location = new System.Drawing.Point(611, 399);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(138, 44);
            this.checkBox12.TabIndex = 41;
            this.checkBox12.Text = "Romantik";
            this.checkBox12.UseVisualStyleBackColor = false;
            // 
            // checkBox11
            // 
            this.checkBox11.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox11.AutoSize = true;
            this.checkBox11.BackColor = System.Drawing.Color.Transparent;
            this.checkBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.ForeColor = System.Drawing.Color.Gray;
            this.checkBox11.Location = new System.Drawing.Point(611, 349);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(214, 44);
            this.checkBox11.TabIndex = 40;
            this.checkBox11.Text = "Reality Program";
            this.checkBox11.UseVisualStyleBackColor = false;
            // 
            // checkBox10
            // 
            this.checkBox10.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox10.AutoSize = true;
            this.checkBox10.BackColor = System.Drawing.Color.Transparent;
            this.checkBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox10.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.ForeColor = System.Drawing.Color.Gray;
            this.checkBox10.Location = new System.Drawing.Point(611, 299);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(94, 44);
            this.checkBox10.TabIndex = 39;
            this.checkBox10.Text = "Korku";
            this.checkBox10.UseVisualStyleBackColor = false;
            // 
            // checkBox9
            // 
            this.checkBox9.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox9.AutoSize = true;
            this.checkBox9.BackColor = System.Drawing.Color.Transparent;
            this.checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.ForeColor = System.Drawing.Color.Gray;
            this.checkBox9.Location = new System.Drawing.Point(611, 249);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(117, 44);
            this.checkBox9.TabIndex = 38;
            this.checkBox9.Text = "Komedi";
            this.checkBox9.UseVisualStyleBackColor = false;
            // 
            // checkBox8
            // 
            this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox8.AutoSize = true;
            this.checkBox8.BackColor = System.Drawing.Color.Transparent;
            this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ForeColor = System.Drawing.Color.Gray;
            this.checkBox8.Location = new System.Drawing.Point(611, 199);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(111, 44);
            this.checkBox8.TabIndex = 37;
            this.checkBox8.Text = "Gerilim";
            this.checkBox8.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox7.AutoSize = true;
            this.checkBox7.BackColor = System.Drawing.Color.Transparent;
            this.checkBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.Gray;
            this.checkBox7.Location = new System.Drawing.Point(611, 149);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(104, 44);
            this.checkBox7.TabIndex = 36;
            this.checkBox7.Text = "Drama";
            this.checkBox7.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.AutoSize = true;
            this.checkBox6.BackColor = System.Drawing.Color.Transparent;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.Gray;
            this.checkBox6.Location = new System.Drawing.Point(161, 399);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(184, 44);
            this.checkBox6.TabIndex = 35;
            this.checkBox6.Text = "Çocuk ve Aile";
            this.checkBox6.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.Transparent;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.Gray;
            this.checkBox5.Location = new System.Drawing.Point(161, 349);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(156, 44);
            this.checkBox5.TabIndex = 34;
            this.checkBox5.Text = "Bilim Doğa";
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.Gray;
            this.checkBox4.Location = new System.Drawing.Point(161, 299);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(308, 44);
            this.checkBox4.TabIndex = 33;
            this.checkBox4.Text = "Bilim Kurgu ve Fantastik";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.Gray;
            this.checkBox3.Location = new System.Drawing.Point(161, 249);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(123, 44);
            this.checkBox3.TabIndex = 32;
            this.checkBox3.Text = "Belgesel";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Gray;
            this.checkBox2.Location = new System.Drawing.Point(161, 199);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 44);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "Anime";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Gray;
            this.checkBox1.Location = new System.Drawing.Point(161, 149);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(245, 44);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Aksiyon ve Macera";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // panel_kategori
            // 
            this.panel_kategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel_kategori.Controls.Add(this.anasayfa_icon);
            this.panel_kategori.Controls.Add(this.panel1);
            this.panel_kategori.Controls.Add(this.Kategori_label);
            this.panel_kategori.Controls.Add(this.KullaniciAdi_label);
            this.panel_kategori.Controls.Add(this.pictureBox_user);
            this.panel_kategori.Controls.Add(this.textBox_arama);
            this.panel_kategori.Controls.Add(this.Romantik);
            this.panel_kategori.Controls.Add(this.RealityProgram);
            this.panel_kategori.Controls.Add(this.Korku);
            this.panel_kategori.Controls.Add(this.Komedi);
            this.panel_kategori.Controls.Add(this.Gerilim);
            this.panel_kategori.Controls.Add(this.Drama);
            this.panel_kategori.Controls.Add(this.ÇocukveAile);
            this.panel_kategori.Controls.Add(this.BilimveDoğa);
            this.panel_kategori.Controls.Add(this.BilimKurguveFantastik);
            this.panel_kategori.Controls.Add(this.Belgesel);
            this.panel_kategori.Controls.Add(this.Anime);
            this.panel_kategori.Controls.Add(this.AksiyonveMacera);
            this.panel_kategori.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_kategori.Location = new System.Drawing.Point(0, 0);
            this.panel_kategori.Name = "panel_kategori";
            this.panel_kategori.Size = new System.Drawing.Size(260, 729);
            this.panel_kategori.TabIndex = 29;
            // 
            // anasayfa_icon
            // 
            this.anasayfa_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anasayfa_icon.BackgroundImage")));
            this.anasayfa_icon.Location = new System.Drawing.Point(205, 172);
            this.anasayfa_icon.Name = "anasayfa_icon";
            this.anasayfa_icon.Size = new System.Drawing.Size(32, 32);
            this.anasayfa_icon.TabIndex = 0;
            this.anasayfa_icon.TabStop = false;
            this.anasayfa_icon.Click += new System.EventHandler(this.anasayfa_icon_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(260, 717);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 12);
            this.panel1.TabIndex = 0;
            // 
            // Kategori_label
            // 
            this.Kategori_label.AutoSize = true;
            this.Kategori_label.BackColor = System.Drawing.Color.Transparent;
            this.Kategori_label.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kategori_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Kategori_label.Location = new System.Drawing.Point(10, 177);
            this.Kategori_label.Name = "Kategori_label";
            this.Kategori_label.Size = new System.Drawing.Size(135, 27);
            this.Kategori_label.TabIndex = 15;
            this.Kategori_label.Text = "# Kategoriler:";
            // 
            // KullaniciAdi_label
            // 
            this.KullaniciAdi_label.AutoSize = true;
            this.KullaniciAdi_label.BackColor = System.Drawing.Color.Transparent;
            this.KullaniciAdi_label.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullaniciAdi_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KullaniciAdi_label.Location = new System.Drawing.Point(105, 50);
            this.KullaniciAdi_label.Name = "KullaniciAdi_label";
            this.KullaniciAdi_label.Size = new System.Drawing.Size(0, 24);
            this.KullaniciAdi_label.TabIndex = 14;
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_user.BackgroundImage")));
            this.pictureBox_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_user.Location = new System.Drawing.Point(15, 25);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_user.TabIndex = 13;
            this.pictureBox_user.TabStop = false;
            // 
            // textBox_arama
            // 
            this.textBox_arama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.textBox_arama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_arama.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_arama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_arama.Location = new System.Drawing.Point(10, 120);
            this.textBox_arama.Name = "textBox_arama";
            this.textBox_arama.Size = new System.Drawing.Size(240, 32);
            this.textBox_arama.TabIndex = 12;
            this.textBox_arama.TextChanged += new System.EventHandler(this.textBox_arama_TextChanged);
            // 
            // Romantik
            // 
            this.Romantik.AutoSize = true;
            this.Romantik.BackColor = System.Drawing.Color.Transparent;
            this.Romantik.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Romantik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Romantik.Location = new System.Drawing.Point(10, 657);
            this.Romantik.Name = "Romantik";
            this.Romantik.Size = new System.Drawing.Size(89, 24);
            this.Romantik.TabIndex = 11;
            this.Romantik.Text = "Romantik";
            this.Romantik.Click += new System.EventHandler(this.Romantik_Click);
            // 
            // RealityProgram
            // 
            this.RealityProgram.AutoSize = true;
            this.RealityProgram.BackColor = System.Drawing.Color.Transparent;
            this.RealityProgram.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealityProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RealityProgram.Location = new System.Drawing.Point(10, 617);
            this.RealityProgram.Name = "RealityProgram";
            this.RealityProgram.Size = new System.Drawing.Size(144, 24);
            this.RealityProgram.TabIndex = 10;
            this.RealityProgram.Text = "Reality Program";
            this.RealityProgram.Click += new System.EventHandler(this.RealityProgram_Click);
            // 
            // Korku
            // 
            this.Korku.AutoSize = true;
            this.Korku.BackColor = System.Drawing.Color.Transparent;
            this.Korku.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Korku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Korku.Location = new System.Drawing.Point(10, 577);
            this.Korku.Name = "Korku";
            this.Korku.Size = new System.Drawing.Size(59, 24);
            this.Korku.TabIndex = 9;
            this.Korku.Text = "Korku";
            this.Korku.Click += new System.EventHandler(this.Korku_Click);
            // 
            // Komedi
            // 
            this.Komedi.AutoSize = true;
            this.Komedi.BackColor = System.Drawing.Color.Transparent;
            this.Komedi.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Komedi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Komedi.Location = new System.Drawing.Point(10, 537);
            this.Komedi.Name = "Komedi";
            this.Komedi.Size = new System.Drawing.Size(74, 24);
            this.Komedi.TabIndex = 8;
            this.Komedi.Text = "Komedi";
            this.Komedi.Click += new System.EventHandler(this.Komedi_Click);
            // 
            // Gerilim
            // 
            this.Gerilim.AutoSize = true;
            this.Gerilim.BackColor = System.Drawing.Color.Transparent;
            this.Gerilim.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerilim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Gerilim.Location = new System.Drawing.Point(10, 497);
            this.Gerilim.Name = "Gerilim";
            this.Gerilim.Size = new System.Drawing.Size(71, 24);
            this.Gerilim.TabIndex = 7;
            this.Gerilim.Text = "Gerilim";
            this.Gerilim.Click += new System.EventHandler(this.Gerilim_Click);
            // 
            // Drama
            // 
            this.Drama.AutoSize = true;
            this.Drama.BackColor = System.Drawing.Color.Transparent;
            this.Drama.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Drama.Location = new System.Drawing.Point(10, 457);
            this.Drama.Name = "Drama";
            this.Drama.Size = new System.Drawing.Size(66, 24);
            this.Drama.TabIndex = 6;
            this.Drama.Text = "Drama";
            this.Drama.Click += new System.EventHandler(this.Drama_Click);
            // 
            // ÇocukveAile
            // 
            this.ÇocukveAile.AutoSize = true;
            this.ÇocukveAile.BackColor = System.Drawing.Color.Transparent;
            this.ÇocukveAile.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ÇocukveAile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ÇocukveAile.Location = new System.Drawing.Point(10, 417);
            this.ÇocukveAile.Name = "ÇocukveAile";
            this.ÇocukveAile.Size = new System.Drawing.Size(123, 24);
            this.ÇocukveAile.TabIndex = 5;
            this.ÇocukveAile.Text = "Çocuk ve Aile";
            this.ÇocukveAile.Click += new System.EventHandler(this.ÇocukveAile_Click);
            // 
            // BilimveDoğa
            // 
            this.BilimveDoğa.AutoSize = true;
            this.BilimveDoğa.BackColor = System.Drawing.Color.Transparent;
            this.BilimveDoğa.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BilimveDoğa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BilimveDoğa.Location = new System.Drawing.Point(10, 377);
            this.BilimveDoğa.Name = "BilimveDoğa";
            this.BilimveDoğa.Size = new System.Drawing.Size(126, 24);
            this.BilimveDoğa.TabIndex = 4;
            this.BilimveDoğa.Text = "Bilim ve Doğa";
            this.BilimveDoğa.Click += new System.EventHandler(this.BilimveDoğa_Click);
            // 
            // BilimKurguveFantastik
            // 
            this.BilimKurguveFantastik.AutoSize = true;
            this.BilimKurguveFantastik.BackColor = System.Drawing.Color.Transparent;
            this.BilimKurguveFantastik.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BilimKurguveFantastik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BilimKurguveFantastik.Location = new System.Drawing.Point(10, 337);
            this.BilimKurguveFantastik.Name = "BilimKurguveFantastik";
            this.BilimKurguveFantastik.Size = new System.Drawing.Size(211, 24);
            this.BilimKurguveFantastik.TabIndex = 3;
            this.BilimKurguveFantastik.Text = "Bilim Kurgu ve Fantastik";
            this.BilimKurguveFantastik.Click += new System.EventHandler(this.BilimKurguveFantastik_Click);
            // 
            // Belgesel
            // 
            this.Belgesel.AutoSize = true;
            this.Belgesel.BackColor = System.Drawing.Color.Transparent;
            this.Belgesel.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Belgesel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Belgesel.Location = new System.Drawing.Point(10, 297);
            this.Belgesel.Name = "Belgesel";
            this.Belgesel.Size = new System.Drawing.Size(80, 24);
            this.Belgesel.TabIndex = 2;
            this.Belgesel.Text = "Belgesel";
            this.Belgesel.Click += new System.EventHandler(this.Belgesel_Click);
            // 
            // Anime
            // 
            this.Anime.AutoSize = true;
            this.Anime.BackColor = System.Drawing.Color.Transparent;
            this.Anime.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Anime.Location = new System.Drawing.Point(10, 257);
            this.Anime.Name = "Anime";
            this.Anime.Size = new System.Drawing.Size(64, 24);
            this.Anime.TabIndex = 1;
            this.Anime.Text = "Anime";
            this.Anime.Click += new System.EventHandler(this.Anime_Click);
            // 
            // AksiyonveMacera
            // 
            this.AksiyonveMacera.AutoSize = true;
            this.AksiyonveMacera.BackColor = System.Drawing.Color.Transparent;
            this.AksiyonveMacera.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AksiyonveMacera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AksiyonveMacera.Location = new System.Drawing.Point(10, 217);
            this.AksiyonveMacera.Name = "AksiyonveMacera";
            this.AksiyonveMacera.Size = new System.Drawing.Size(167, 24);
            this.AksiyonveMacera.TabIndex = 0;
            this.AksiyonveMacera.Text = "Aksiyon ve Macera";
            this.AksiyonveMacera.Click += new System.EventHandler(this.AksiyonveMacera_Click);
            // 
            // panel_icerik
            // 
            this.panel_icerik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel_icerik.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_icerik.Location = new System.Drawing.Point(260, 0);
            this.panel_icerik.Name = "panel_icerik";
            this.panel_icerik.Size = new System.Drawing.Size(792, 729);
            this.panel_icerik.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel_kategori);
            this.Controls.Add(this.panel_icerik);
            this.Controls.Add(this.panel_giris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netflix";
            this.panel_kayit.ResumeLayout(false);
            this.panel_kayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_giris.ResumeLayout(false);
            this.panel_giris.PerformLayout();
            this.panel_kategorisec.ResumeLayout(false);
            this.panel_kategorisec.PerformLayout();
            this.panel_kategori.ResumeLayout(false);
            this.panel_kategori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anasayfa_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panel_kayit;
        private System.Windows.Forms.Button kayit_button;
        private System.Windows.Forms.MaskedTextBox dogumtarihi_textbox;
        private System.Windows.Forms.TextBox sifre_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox kullanici_adi_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_giris;
        private System.Windows.Forms.Label kayıt_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifre_giris;
        private System.Windows.Forms.TextBox email_giris;
        private System.Windows.Forms.Button oturum_button;
        private System.Windows.Forms.Panel panel_kategori;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.TextBox textBox_arama;
        private System.Windows.Forms.Label Romantik;
        private System.Windows.Forms.Label RealityProgram;
        private System.Windows.Forms.Label Korku;
        private System.Windows.Forms.Label Komedi;
        private System.Windows.Forms.Label Gerilim;
        private System.Windows.Forms.Label Drama;
        private System.Windows.Forms.Label ÇocukveAile;
        private System.Windows.Forms.Label BilimveDoğa;
        private System.Windows.Forms.Label BilimKurguveFantastik;
        private System.Windows.Forms.Label Belgesel;
        private System.Windows.Forms.Label Anime;
        private System.Windows.Forms.Label AksiyonveMacera;
        private System.Windows.Forms.Label Kategori_label;
        private System.Windows.Forms.Label KullaniciAdi_label;
        private System.Windows.Forms.Panel panel_icerik;
        private System.Windows.Forms.Panel panel_kategorisec;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button but_kategorisec;
        private System.Windows.Forms.Label label3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox anasayfa_icon;
    }
}

