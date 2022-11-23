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
namespace ZiraatTeknik
{

    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
        private Form activeForm = null;
        private void openChilForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 4)
            {
                imageNumber = 1;

            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }


        private void Anasayfa_Load(object sender, EventArgs e)
        {

            kampanyaurun1();
            kampanyaurun2();
            urungetir();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void BtnKampanya1_Click(object sender, EventArgs e)
        {
            //openChilForm(new UrunDetaylari());
            UrunDetaylari detay = new UrunDetaylari();
            detay.Show();
            baglanti.Open();
            SqlCommand getir = new SqlCommand("SELECT Urunler.UrunAdi,Urunler.UrunFiyat,Urunler.UrunAciklama, Urunler.UrunKodu,Markalar.MarkaAdi,UrunKategori.KategoriAdi, UrunAltKategori.AltKategoriAdi  FROM Urunler INNER JOIN Markalar On Urunler.markaid=Markalar.Id INNER JOIN UrunKategori ON Urunler.kategorid = UrunKategori.Id INNER JOIN UrunAltKategori ON Urunler.altkategorid = UrunAltKategori.Id where Urunler.Id = 24", baglanti);
            SqlDataReader dr = getir.ExecuteReader();
            if (dr.Read())
            {
                detay.LblAd.Text = dr["UrunAdi"].ToString();
                detay.LblKategori.Text = dr["KategoriAdi"].ToString();
                detay.LblAltkategori.Text = dr["AltKategoriAdi"].ToString();
                detay.LblFiyat.Text = dr["UrunFiyat"].ToString();
                detay.LblAciklama.Text = dr["UrunAciklama"].ToString();
                detay.LblKod.Text = dr["UrunKodu"].ToString();
                detay.LblMarka.Text = dr["MarkaAdi"].ToString();
                dr.Close();
                baglanti.Close();
            }
        } //ürün detay sayfası verileri

        private void aNASAYFAToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void urungetir() //arama alanı için
        {
            SqlCommand komut = new SqlCommand("Select Id,UrunAdi From Urunler", baglanti);
            SqlDataAdapter read = new SqlDataAdapter(komut); //hafızaya alınan veriler ile sql arasında köprü kurucak
            DataTable dt = new DataTable(); //hafızada sanal tablo oluşturuldu
            read.Fill(dt);
            cmburunara.ValueMember = "Id";
            cmburunara.DisplayMember = "UrunAdi";
            cmburunara.DataSource = dt;
            cmburunara.SelectedIndex = -1;
            cmburunara.Text = "Ürün Ara";
        }
        private void kampanyaurun1()
        {
            baglanti.Open();
            SqlCommand getir = new SqlCommand("SELECT Urunler.UrunAdi, Urunler.UrunFiyat,UrunKategori.KategoriAdi, UrunKampanya.KampanyaFiyati FROM UrunKampanya INNER JOIN Urunler ON UrunKampanya.urunid = Urunler.Id INNER JOIN UrunKategori ON UrunKategori.Id = Urunler.kategorid WHERE Urunler.Id = 24", baglanti);
            SqlDataReader dr = getir.ExecuteReader();
            if (dr.Read())
            {
                lblad1.Text = dr["UrunAdi"].ToString();
                lblkategori1.Text = dr["KategoriAdi"].ToString();
                lblfiyat1.Text = dr["UrunFiyat"].ToString();
                lblkampanyaf1.Text = dr["KampanyaFiyati"].ToString();
                dr.Close();
                baglanti.Close();
            }
        }

        private void kampanyaurun2()
        {
            baglanti.Open();
            SqlCommand getir = new SqlCommand("SELECT Urunler.UrunAdi, Urunler.UrunFiyat,UrunKategori.KategoriAdi, UrunKampanya.KampanyaFiyati FROM UrunKampanya INNER JOIN Urunler ON UrunKampanya.urunid = Urunler.Id INNER JOIN UrunKategori ON UrunKategori.Id = Urunler.kategorid WHERE Urunler.Id = 1029", baglanti);
            SqlDataReader dr = getir.ExecuteReader();
            if (dr.Read())
            {
                lblad2.Text = dr["UrunAdi"].ToString();
                lblkategori2.Text = dr["KategoriAdi"].ToString();
                lblfiyat2.Text = dr["UrunFiyat"].ToString();
                lblkampanyaf2.Text = dr["KampanyaFiyati"].ToString();
                dr.Close();
                baglanti.Close();
            }
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUyeGirisi girisyap = new FormUyeGirisi();
            girisyap.Show();
        }

        private void HakkimizdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChilForm(new MenuHakkimizda());
        }

        private void ProjelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChilForm(new MenuProjeler());
        }

        private void IletisimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChilForm(new MenuIetisim());
        }

        private void BtnKampanya2_Click(object sender, EventArgs e)
        {
            UrunDetaylari detay = new UrunDetaylari();
            detay.Show();
            baglanti.Open();
            SqlCommand getir = new SqlCommand("SELECT Urunler.UrunAdi,Urunler.UrunFiyat,Urunler.UrunAciklama, Urunler.UrunKodu,Markalar.MarkaAdi,UrunKategori.KategoriAdi, UrunAltKategori.AltKategoriAdi  FROM Urunler INNER JOIN Markalar On Urunler.markaid=Markalar.Id INNER JOIN UrunKategori ON Urunler.kategorid = UrunKategori.Id INNER JOIN UrunAltKategori ON Urunler.altkategorid = UrunAltKategori.Id where Urunler.Id = 1029", baglanti);
            SqlDataReader dr = getir.ExecuteReader();
            if (dr.Read())
            {
                detay.LblAd.Text = dr["UrunAdi"].ToString();
                detay.LblKategori.Text = dr["KategoriAdi"].ToString();
                detay.LblAltkategori.Text = dr["AltKategoriAdi"].ToString();
                detay.LblFiyat.Text = dr["UrunFiyat"].ToString();
                detay.LblAciklama.Text = dr["UrunAciklama"].ToString();
                detay.LblKod.Text = dr["UrunKodu"].ToString();
                detay.LblMarka.Text = dr["MarkaAdi"].ToString();
                dr.Close();
                baglanti.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
             
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }
    }
}
