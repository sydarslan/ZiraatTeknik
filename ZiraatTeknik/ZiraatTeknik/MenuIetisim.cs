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
    public partial class MenuIetisim : Form
    {
        public MenuIetisim()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string today = DateTime.Now.ToString("yyyy/MM/dd");
            SqlCommand ekle = new SqlCommand("insert into IletisimFormu(GonderenAdi,Mail,Telefon,mesaj,MesajTarihi) values('" + TxtAd.Text + "', '" + TxtMail.Text + "','" + TxtTelefon.Text + "', '" + TxtMesaj.Text + "','" + today + "')", baglanti);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız Başarıyla Gönderildi");
            
        }

        private void BtnCikis2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
