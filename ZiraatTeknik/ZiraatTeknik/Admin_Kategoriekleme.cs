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
    public partial class Admin_Kategoriekleme : Form
    {
        public Admin_Kategoriekleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");

        private void btnkategoriekle_Click(object sender, EventArgs e)
        {
            //kontrol işlemleri:
               //1-Aynı kategori tekrar girmeyecek...
                 //Girerse hata mesajı
               //2- text içine sadece karakter girilecek rakam girdirme
               //TExt alanları boş bırakılmayacak
                 //Bırakılırsa hata mesajı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into UrunKategori(KategoriAdi,KategoriDurum) values('"+txtadi.Text+"', '"+checkBoxkategori.Checked+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            txtadi.Text = "";
            checkBoxkategori.Checked = false;
            MessageBox.Show("Kategori Eklendi");
        }
    }
}
