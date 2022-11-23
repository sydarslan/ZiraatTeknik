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
    public partial class Admin_Altkategoriekle : Form
    {
        public Admin_Altkategoriekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
        private void btnaltkategoriekle_Click(object sender, EventArgs e)
        {
            //kontrol işlemleri:
            //1-Aynı altkategori tekrar girmeyecek...
            //Girerse hata mesajı
            //2- text içine sadece karakter girilecek rakam girdirme
            //TExt alanları boş bırakılmayacak
            //Bırakılırsa hata mesajı
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into UrunAltKategori(AltKategoriAdi,kategorid) values('" + txtaltkategoriadi.Text + "', '" + comboBoxkategori.SelectedValue + "')", baglanti);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Eklendi");
            txtaltkategoriadi.Text = "";
            comboBoxkategori.SelectedIndex = -1;
            comboBoxkategori.Text = "Seçiniz...";
        }

        private void altkategoriekle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void kategorigetir()
        {
            SqlCommand komut = new SqlCommand("Select Id,KategoriAdi From UrunKategori", baglanti);
            SqlDataAdapter read = new SqlDataAdapter(komut); //hafızaya alınan veriler ile sql arasında köprü kurucak
            DataTable dt = new DataTable(); //hafızada sanal tablo oluşturuldu
            read.Fill(dt);
            comboBoxkategori.ValueMember = "Id";
            comboBoxkategori.DisplayMember = "KategoriAdi";
            comboBoxkategori.DataSource = dt;
            comboBoxkategori.SelectedIndex = -1;
            comboBoxkategori.Text = "Seçiniz...";
        }
    }
}
