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
    public partial class FormUyeGirisi : Form
    {
        public FormUyeGirisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUyeOl uyeol = new FormUyeOl();
            uyeol.Show();
            this.Hide();
        }
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtGirisEmail.Text == "" && TxtGirisSifre.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız...");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from Uyeler where Mail='" + TxtGirisEmail.Text + "' and Sifre='" + TxtGirisSifre.Text + "'", baglanti);  //sqlcommand ile sorgu cümlesi yazılır.
                SqlDataReader oku = komut.ExecuteReader();  //sqldatareader ile sql veritabanındaki dataları okur
                if (oku.HasRows) //Girilen mais ve şifre dahiline gelen kayıt var ise:
                {
                    while (oku.Read())
                    {
                        if (oku["tipid"].ToString() == "1") //kullanıcı admin ise:
                        {
                            AdminPanel admin = new AdminPanel();
                            admin.Show();
                            this.Hide();
                        }
                        else
                        {
                            //anasayfayı göster
                            Anasayfa anasayfa = new Anasayfa();
                            anasayfa.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    //Reader SATIR döndüremiyorsa mail şifre Yanlış Demekdir
                    oku.Close();
                    MessageBox.Show("Geçersiz Mail veya Şifre...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtGirisEmail.Text = "";
                    TxtGirisSifre.Text = "";
                    TxtGirisEmail.Focus();
                }
                baglanti.Close();
            }
        }
    }
}
