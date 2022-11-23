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
    public partial class Admin_Markaekle : Form
    {
        public Admin_Markaekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
        private void btnmarkaekle_Click(object sender, EventArgs e)
        {
            //kontrol işlemleri:
            //1-Aynı marka tekrar girmeyecek...
            //Girerse hata mesajı
            //2- text içine sadece karakter girilecek rakam girdirme
            //TExt alanları boş bırakılmayacak
            //Bırakılırsa hata mesajı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Markalar(MarkaAdi) values('" + txtmarkaadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Marka Eklendi");
            txtmarkaadi.Text = "";
        }
    }
}
