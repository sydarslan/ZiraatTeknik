
namespace ZiraatTeknik
{
    partial class FormUyeOl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUyeOl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnUyeOl = new System.Windows.Forms.Button();
            this.TxtKayıtAd = new System.Windows.Forms.TextBox();
            this.TxtKayitSoyad = new System.Windows.Forms.TextBox();
            this.TxtKayitTelefon = new System.Windows.Forms.TextBox();
            this.TxtKayitMail = new System.Windows.Forms.TextBox();
            this.TxtKayitSifre = new System.Windows.Forms.TextBox();
            this.TxtKayitAdres = new System.Windows.Forms.TextBox();
            this.CmbKayitil = new System.Windows.Forms.ComboBox();
            this.CmbKayitilce = new System.Windows.Forms.ComboBox();
            this.linkGirisYap = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(271, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(271, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(271, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(271, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(271, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(271, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(271, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "İl :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(271, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "İlçe :";
            // 
            // BtnUyeOl
            // 
            this.BtnUyeOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnUyeOl.Font = new System.Drawing.Font("Courier New", 12F);
            this.BtnUyeOl.Location = new System.Drawing.Point(355, 336);
            this.BtnUyeOl.Name = "BtnUyeOl";
            this.BtnUyeOl.Size = new System.Drawing.Size(97, 36);
            this.BtnUyeOl.TabIndex = 8;
            this.BtnUyeOl.Text = "Üye Ol";
            this.BtnUyeOl.UseVisualStyleBackColor = false;
            this.BtnUyeOl.Click += new System.EventHandler(this.BtnUyeOl_Click);
            // 
            // TxtKayıtAd
            // 
            this.TxtKayıtAd.Location = new System.Drawing.Point(355, 22);
            this.TxtKayıtAd.Name = "TxtKayıtAd";
            this.TxtKayıtAd.Size = new System.Drawing.Size(189, 20);
            this.TxtKayıtAd.TabIndex = 9;
            // 
            // TxtKayitSoyad
            // 
            this.TxtKayitSoyad.Location = new System.Drawing.Point(355, 64);
            this.TxtKayitSoyad.Name = "TxtKayitSoyad";
            this.TxtKayitSoyad.Size = new System.Drawing.Size(189, 20);
            this.TxtKayitSoyad.TabIndex = 10;
            // 
            // TxtKayitTelefon
            // 
            this.TxtKayitTelefon.Location = new System.Drawing.Point(355, 105);
            this.TxtKayitTelefon.Name = "TxtKayitTelefon";
            this.TxtKayitTelefon.Size = new System.Drawing.Size(189, 20);
            this.TxtKayitTelefon.TabIndex = 11;
            // 
            // TxtKayitMail
            // 
            this.TxtKayitMail.Location = new System.Drawing.Point(355, 143);
            this.TxtKayitMail.Name = "TxtKayitMail";
            this.TxtKayitMail.Size = new System.Drawing.Size(189, 20);
            this.TxtKayitMail.TabIndex = 12;
            // 
            // TxtKayitSifre
            // 
            this.TxtKayitSifre.Location = new System.Drawing.Point(355, 183);
            this.TxtKayitSifre.Name = "TxtKayitSifre";
            this.TxtKayitSifre.Size = new System.Drawing.Size(189, 20);
            this.TxtKayitSifre.TabIndex = 13;
            // 
            // TxtKayitAdres
            // 
            this.TxtKayitAdres.Location = new System.Drawing.Point(355, 222);
            this.TxtKayitAdres.Name = "TxtKayitAdres";
            this.TxtKayitAdres.Size = new System.Drawing.Size(189, 20);
            this.TxtKayitAdres.TabIndex = 14;
            // 
            // CmbKayitil
            // 
            this.CmbKayitil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbKayitil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbKayitil.FormattingEnabled = true;
            this.CmbKayitil.Location = new System.Drawing.Point(355, 259);
            this.CmbKayitil.Name = "CmbKayitil";
            this.CmbKayitil.Size = new System.Drawing.Size(189, 21);
            this.CmbKayitil.TabIndex = 15;
            this.CmbKayitil.SelectedIndexChanged += new System.EventHandler(this.CmbKayitil_SelectedIndexChanged);
            // 
            // CmbKayitilce
            // 
            this.CmbKayitilce.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbKayitilce.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbKayitilce.FormattingEnabled = true;
            this.CmbKayitilce.Location = new System.Drawing.Point(355, 297);
            this.CmbKayitilce.Name = "CmbKayitilce";
            this.CmbKayitilce.Size = new System.Drawing.Size(189, 21);
            this.CmbKayitilce.TabIndex = 16;
            // 
            // linkGirisYap
            // 
            this.linkGirisYap.AutoSize = true;
            this.linkGirisYap.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkGirisYap.Location = new System.Drawing.Point(337, 386);
            this.linkGirisYap.Name = "linkGirisYap";
            this.linkGirisYap.Size = new System.Drawing.Size(142, 13);
            this.linkGirisYap.TabIndex = 18;
            this.linkGirisYap.TabStop = true;
            this.linkGirisYap.Text = "Zaten Üye Misiniz? Giriş Yap";
            this.linkGirisYap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGirisYap_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 419);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FormUyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 419);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkGirisYap);
            this.Controls.Add(this.CmbKayitilce);
            this.Controls.Add(this.CmbKayitil);
            this.Controls.Add(this.TxtKayitAdres);
            this.Controls.Add(this.TxtKayitSifre);
            this.Controls.Add(this.TxtKayitMail);
            this.Controls.Add(this.TxtKayitTelefon);
            this.Controls.Add(this.TxtKayitSoyad);
            this.Controls.Add(this.TxtKayıtAd);
            this.Controls.Add(this.BtnUyeOl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUyeOl";
            this.Text = "FormUyeOl";
            this.Load += new System.EventHandler(this.FormUyeOl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnUyeOl;
        private System.Windows.Forms.TextBox TxtKayıtAd;
        private System.Windows.Forms.TextBox TxtKayitSoyad;
        private System.Windows.Forms.TextBox TxtKayitTelefon;
        private System.Windows.Forms.TextBox TxtKayitMail;
        private System.Windows.Forms.TextBox TxtKayitSifre;
        private System.Windows.Forms.TextBox TxtKayitAdres;
        private System.Windows.Forms.ComboBox CmbKayitil;
        private System.Windows.Forms.ComboBox CmbKayitilce;
        private System.Windows.Forms.LinkLabel linkGirisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}