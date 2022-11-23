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
    public partial class Admin_Kampanyalar : Form
    {
        public Admin_Kampanyalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
        private void BtnKampanyaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into UrunKampanya(urunid,KampanyaFiyati,Aktiflik) values('" + TxtUrunid.Text.ToString() + "', '" + TxtKampanyaF.Text.ToString() + "', '"+checkBoxAktif.Checked.ToString()+"')", baglanti);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(" Ürün Kampanya Fiyatı Eklendi");
        }
        private void griurundoldur()
        {
           
            string doldur = "select Urunler.Id,Urunler.UrunAdi, Urunler.UrunFiyat from Urunler";
            DataTable urungetir = Yardimci.VeriOku(doldur);
            dataurun.DataSource = urungetir;
        }

        private void gridkampanyadoldur()
        {
            string doldur = "select urunid, KampanyaFiyati, Aktiflik from UrunKampanya";
            DataTable kampanyaurungetir = Yardimci.VeriOku(doldur);
            datakampanya.DataSource = kampanyaurungetir;
        }
        private void Admin_Kampanyalar_Load(object sender, EventArgs e)
        {
            griurundoldur();
            gridkampanyadoldur();
        }

        private void dataurun_SelectionChanged(object sender, EventArgs e)
        {
            if (dataurun.SelectedRows.Count > 0)
            {
                int secilensatir = dataurun.CurrentRow.Index;

                TxtUrunid.Text = dataurun.Rows[secilensatir].Cells[0].Value.ToString();
                TxtKampanyaF.Text = dataurun.Rows[secilensatir].Cells[2].Value.ToString();
            }
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
