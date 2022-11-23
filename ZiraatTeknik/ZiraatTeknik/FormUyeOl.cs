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
    public partial class FormUyeOl : Form
    {
        public FormUyeOl()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
        private void FormUyeOl_Load(object sender, EventArgs e)
        {
            ilgetir();
            ilcegetir();
        }
        private void BtnUyeOl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Uyeler  " +
                "where  Mail='" + TxtKayitMail.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read()) //Girilen mais ve şifre dahiline gelen kayıt var ise:
            {
                MessageBox.Show("Bu kullanıcı mail adresi zaten kayıtlı... Giriş Yap Ekranına Gidiniz...");
            }
            else
            {
                oku.Close();
                
                if (TxtKayitMail.Text!="seydarslan098@gmail.com")
                {
                    string today = DateTime.Now.ToString("yyyy/MM/dd");
                    SqlCommand kayit = new SqlCommand("insert into Uyeler(UyeAdi,UyeSoyadi,Telefon,Mail, Sifre,UyelikTarihi,UyelikDurumu,tipid,UyeAdres,ilid,ilceid)" +
                    "values('"+TxtKayıtAd.Text+"','"+ TxtKayitSoyad.Text+"', '"+TxtKayitTelefon.Text+"', '"+TxtKayitMail.Text+"', '"+TxtKayitSifre.Text+"', '"+today+"','"+1+"', '"+2+"', '"+TxtKayitAdres.Text+"', '"+CmbKayitil.SelectedValue.ToString()+"', '"+CmbKayitilce.SelectedValue.ToString()+"')", baglanti);
                    if (TxtKayıtAd.Text.Length>0)//kutular boş mu
                    {
                        kayit.ExecuteNonQuery();
                        MessageBox.Show("Kayıt işlemi başarıyla yapıldı...");
                    }
                    else
                    {
                        MessageBox.Show("Boş alanları doldurunuz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                FormUyeGirisi girisEkrani = new FormUyeGirisi();
                girisEkrani.Show();
                this.Hide();
            }
            baglanti.Close();
        }
        private void linkGirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUyeGirisi girisEkrani = new FormUyeGirisi();
            girisEkrani.Show();
            this.Close();
        }

        private void ilgetir()
        {
            SqlCommand komut = new SqlCommand("Select Id,IlAdi From Uyeil", baglanti);
            SqlDataAdapter read = new SqlDataAdapter(komut); //hafızaya alınan veriler ile sql arasında köprü kurucak
            DataTable dt = new DataTable(); //hafızada sanal tablo oluşturuldu
            read.Fill(dt);
            CmbKayitil.ValueMember = "Id";
            CmbKayitil.DisplayMember = "IlAdi";
            CmbKayitil.DataSource = dt;
            CmbKayitil.SelectedIndex = -1;
            CmbKayitil.Text = "Seçiniz...";
        }

        private void ilcegetir()
        {
            SqlCommand komut = new SqlCommand("Select Id,IlceAdi From Uyeilce where ilid='"+CmbKayitil.SelectedValue+"'", baglanti);
            SqlDataAdapter read = new SqlDataAdapter(komut); //hafızaya alınan veriler ile sql arasında köprü kurucak
            DataTable dt = new DataTable(); //hafızada sanal tablo oluşturuldu
            read.Fill(dt);
            CmbKayitilce.ValueMember = "Id";
            CmbKayitilce.DisplayMember = "IlceAdi";
            CmbKayitilce.DataSource = dt;
            CmbKayitilce.SelectedIndex = -1;
            CmbKayitilce.Text = "Seçiniz...";
        }

        private void CmbKayitil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbKayitil.SelectedIndex != -1)
            {
                ilcegetir();
            }
        }
    }
}
