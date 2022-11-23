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
    public partial class AdminHesap : Form
    {
        public AdminHesap()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
        private void BtnCikis2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminHesap_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT  Uyeler.UyeAdi, Uyeler.UyeSoyadi, Uyeler.Telefon, Uyeler.Mail, Uyeler.Sifre, Uyeler.UyeAdres, Uyeilce.IlceAdi, Uyeil.IlAdi FROM Uyeil INNER JOIN Uyeilce ON Uyeil.Id = Uyeilce.ilid INNER JOIN Uyeler ON Uyeil.Id = Uyeler.ilid AND Uyeilce.Id = Uyeler.ilceid where Uyeler.tipid = 1 ",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                TxtAdminAd.Text = read["UyeAdi"].ToString();
                TxtAdminSoyad.Text = read["UyeSoyadi"].ToString();
                TxtAdminTelefon.Text = read["Telefon"].ToString();
                TxtAdminMail.Text = read["Mail"].ToString();                
                TxtAdminSifre.Text = read["Sifre"].ToString();
            }
            baglanti.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        } //hatalı tıklama

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update  Uyeler set UyeAdi='" + TxtAdminAd.Text + "',UyeSoyadi='" + TxtAdminSoyad.Text + "',Telefon='" + TxtAdminTelefon.Text + "',Mail='" + TxtAdminMail.Text + "',Sifre='" + TxtAdminSifre.Text+"' where tipid=1", baglanti);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Admin Bilgileri Güncellendi");
        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT  Uyeler.UyeAdi, Uyeler.UyeSoyadi, Uyeler.Telefon, Uyeler.Mail, Uyeler.Sifre, Uyeler.UyeAdres, Uyeilce.IlceAdi, Uyeil.IlAdi FROM Uyeil INNER JOIN Uyeilce ON Uyeil.Id = Uyeilce.ilid INNER JOIN Uyeler ON Uyeil.Id = Uyeler.ilid AND Uyeilce.Id = Uyeler.ilceid where Uyeler.tipid = 1 ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                TxtAdminAd.Text = read["UyeAdi"].ToString();
                TxtAdminSoyad.Text = read["UyeSoyadi"].ToString();
                TxtAdminTelefon.Text = read["Telefon"].ToString();
                TxtAdminMail.Text = read["Mail"].ToString();
                TxtAdminSifre.Text = read["Sifre"].ToString();
            }
            baglanti.Close();
        }
    }
}
