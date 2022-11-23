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
    public partial class Admin_UyeListesi : Form
    {
        public Admin_UyeListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
        private void Btnuyegetir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = ("SELECT  Uyeler.UyeAdi, Uyeler.UyeSoyadi, Uyeler.Telefon, Uyeler.Mail, Uyeler.UyelikTarihi, Uyeler.UyeAdres, Uyeilce.IlceAdi, Uyeil.IlAdi FROM Uyeil INNER JOIN Uyeilce ON Uyeil.Id = Uyeilce.ilid INNER JOIN Uyeler ON Uyeil.Id = Uyeler.ilid AND Uyeilce.Id = Uyeler.ilceid where Uyeler.tipid = 2 ");
            SqlDataAdapter Tercuman = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            Tercuman.Fill(dt);
            datauye.DataSource = dt;
            baglanti.Close();
        }
        private void Admin_UyeListesi_Load(object sender, EventArgs e)
        {
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
