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
    public partial class Admin_Kupon : Form
    {
        public Admin_Kupon()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
        private void BtnKuponEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //üyeleri combobox ile getir. gelen üyenin id bilgisini buraya ekle Eğer null ise hata veriyor???
            SqlCommand ekle = new SqlCommand("insert into Kuponlar(KuponKodu, KuponFiyati,uyeid,Aktiflik) values('" + TxtKod.Text + "', '" + TxtFiyat.Text.ToString() + "', '" + TxtUye.Text.ToString() + "','" + checkBoxKuponAktif.Checked.ToString() + "' )", baglanti);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kupon eklendi");
            Textbos();
        }
        private void Textbos()
        {
            TxtKod.Text = "";
            TxtFiyat.Text = "";
            TxtUye.Text = "";
            checkBoxKuponAktif.Checked =false; 
        }
        private void Admin_Kupon_Load(object sender, EventArgs e) //Kuponlar sayfası açılınca gelen veriler
        {
            string sorgu = "SELECT * from Kuponlar";
            DataTable kupongetir = Yardimci.VeriOku(sorgu);
            dataKuponlar.DataSource = kupongetir;
        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
