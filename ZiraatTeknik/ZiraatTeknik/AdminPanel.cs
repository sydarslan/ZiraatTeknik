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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
        private Form activeForm = null;
        private void openChilForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void BtnUrun_Click(object sender, EventArgs e)
        {
            openChilForm(new Admin_UrunIslemleri());
         
        }
        private void BtnStok_Click(object sender, EventArgs e)
        {
            openChilForm(new Admin_StokBilgileri ());
        }
        private void BtnUye_Click(object sender, EventArgs e)
        {
            openChilForm(new Admin_UyeListesi());
        }
        private void BtnSiparis_Click(object sender, EventArgs e)
        {
            openChilForm(new Admin_Siparisler());
        }    
        private void BtnKampanya_Click(object sender, EventArgs e)
        {
            openChilForm(new Admin_Kampanyalar());
        }
        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            openChilForm(new AdminHesap());
        }
        private void BtnKupon_Click(object sender, EventArgs e)
        {
            openChilForm(new Admin_Kupon());
        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
        private void BtnBildirim_Click(object sender, EventArgs e)
        {
            openChilForm(new Admin_Bildirim());
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            FillChart();
            kategorisayisi();
            siparissayisi();
            urunsayisi();
            mesaj();
            uye();

        }
        void FillChart()
        {
            string sorgu = "SELECT Urunler.UrunAdi, UrunStok.UrunStokAdedi FROM Urunler INNER JOIN UrunStok ON Urunler.Id = UrunStok.urunid";
            DataTable chart = Yardimci.VeriOku(sorgu);
            chart1.DataSource = chart;

            chart1.Series["Ürün Stok Adedi"].XValueMember = "UrunAdi";
            chart1.Series["Ürün Stok Adedi"].YValueMembers = "UrunStokAdedi";
            //chart1.Titles.Add("Ürünlerin Stok Adedleri");

        }
        void kategorisayisi()
        {
            string sorgu = "SELECT Id From UrunKategori";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds);
            lblkategori.Text = ds.Tables[0].Rows.Count.ToString();
            baglanti.Close();
        }
        private void siparissayisi()
        {
            string sorgu = "SELECT Id FROM Siparisler";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds);
            lblsiparis.Text = ds.Tables[0].Rows.Count.ToString();
            baglanti.Close();
        }
        private void urunsayisi()
        {
            string urun = "SELECT Id FROM Urunler";
            SqlDataAdapter da = new SqlDataAdapter(urun, baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds);
            lblurun.Text= ds.Tables[0].Rows.Count.ToString();
            baglanti.Close();
        }
        private void mesaj()
        {
            string mesaj = "SELECT Id FROM IletisimFormu";
            SqlDataAdapter adap = new SqlDataAdapter(mesaj, baglanti);
            DataSet data = new DataSet();
            baglanti.Open();
            adap.Fill(data);
            lblmesaj.Text = data.Tables[0].Rows.Count.ToString();
            baglanti.Close();
        }
        private void uye()
        {
            string urun = "SELECT Id FROM Uyeler where tipid=2";
            SqlDataAdapter sda = new SqlDataAdapter(urun, baglanti);
            DataSet sds = new DataSet();
            baglanti.Open();
            sda.Fill(sds);
            lbluye.Text = sds.Tables[0].Rows.Count.ToString();
            baglanti.Close();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
            //FillChart();
            //kategorisayisi();
            //siparissayisi();
            //urunsayisi();
            //mesaj();
            //uye();
        }
    }
}
