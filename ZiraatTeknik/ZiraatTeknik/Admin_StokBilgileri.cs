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
    public partial class Admin_StokBilgileri : Form
    {
        public Admin_StokBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into UrunStok(urunid,UrunStokAdedi) values('" +TxtId.Text.ToString() +"', '" + TxtAdet.Text.ToString() + "')", baglanti);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("stok adedi eklendi");
        }
        private void StokBilgileri_Load(object sender, EventArgs e)
        {
            gridoldur();
            gridstokdoldur();
        } 

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update UrunStok set UrunStokAdedi='" + TxtAdet.Text +"'  where urunid='" + TxtId.Text + "'", baglanti);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Bilgileri Güncellendi");
            TextBos();
        }

        private void BtnCikis3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataStokUrun_SelectionChanged(object sender, EventArgs e)
        {
            if (dataUrunler.SelectedRows.Count > 0)
            {
                int secilensatir = dataUrunler.CurrentRow.Index;
               
                TxtId.Text = dataUrunler.Rows[secilensatir].Cells[0].Value.ToString();
                TxtAdet.Text = dataUrunler.Rows[secilensatir].Cells[2].Value.ToString();
            }
        } //grid verilerini texbox a aktarır
        private void gridoldur()
        {
            baglanti.Open();
            string sorgu = ("select Urunler.Id,Urunler.UrunAdi,UrunStok.UrunStokAdedi" +
                " from Urunler left join UrunStok On Urunler.Id=UrunStok.urunid");
            SqlDataAdapter Tercuman = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            Tercuman.Fill(dt);
            dataUrunler.DataSource = dt;
            baglanti.Close();
        } 
        private void gridstokdoldur()
        {
            baglanti.Open();
            string sorgu = ("select urunid,UrunStokAdedi from UrunStok");
            SqlDataAdapter Tercuman = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            Tercuman.Fill(dt);
            dataStokAdedi.DataSource = dt;
            baglanti.Close();
        }

        private void TextBos()
        {
            TxtId.Text = "";
            TxtAdet.Text = "";
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            gridstokdoldur();
        }

        private void BtnUrunListele_Click(object sender, EventArgs e)
        {
            gridoldur();
        }

        //burada aynı ürüne ikinci bir kayıt ekletmezzz....

        //         if (listView1.Items.Count > 0) //eğer kayıt varsa kontrol işlemine başla
        //            {
        //                for (int i = 0; i<listView1.Items.Count; i++) //tüm kayıtlarda dön
        //                {
        //                    if (listView1.Items[0].SubItems[0].Text == TxtUyeNo.Text) //girilen üyeno listview içindeki items içinde varsa
        //                    {
        //                        MessageBox.Show("Girilen üye no kayıtlı... Başka bir üye numarası giriniz!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);  //kayıt var mesajı gönder
        //                        TxtUyeNo.Text = "";
        //                        TxtAd.Text = "";
        //                        TxtSoyad.Text = "";
        //                        TxtUyeNo.Focus();
        //                        TxtUyeNo.BackColor = Color.LightPink;
        //                        break;
        //                    }
        //                    else   //girilen üyeno listview içindeki items içinde yoksa kayıt yap
        //                    {

        //                        Kaydet();
        //}
        //                }
        //            }
        //            else //listview içinde herhangi bir kayıt yoksa direk kaydet
        //             {

        //                 Kaydet();
        //             }
    }
}
