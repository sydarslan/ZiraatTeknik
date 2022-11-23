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
    public partial class Admin_UrunIslemleri : Form
    {
        public Admin_UrunIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
        private void BtnKategoriEkle_Click(object sender, EventArgs e)
        {

            //kontroller eklenecek
            Admin_Kategoriekleme kategori = new Admin_Kategoriekleme();
            kategori.ShowDialog();
        } // kategori eklenir
        private void BtnAltKategoriEkle_Click(object sender, EventArgs e)
        {
            //kontroller eklenecek
            Admin_Altkategoriekle altkategori = new Admin_Altkategoriekle();
            altkategori.ShowDialog();
        } //alt kategori eklenir
        private void BtnMarkaEkle_Click(object sender, EventArgs e)
        {
            //kontroller eklenecek
            Admin_Markaekle marka = new Admin_Markaekle();
            marka.ShowDialog();
        } //marka eklenir
        private void UrunIslemleri_Load(object sender, EventArgs e)
        {
            kategorigetir();
            markagetir();
        } //ürün işlemleri açılınca gelen bilgiler
        private void kategorigetir()
        {
            string kategorigetir="Select Id,KategoriAdi From UrunKategori";
            CmbUrunKategori.DataSource = null;
            DataTable kategoritablosu = Yardimci.VeriOku(kategorigetir);
            CmbUrunKategori.ValueMember = "Id";
            CmbUrunKategori.DisplayMember = "KategoriAdi";
            CmbUrunKategori.DataSource = kategoritablosu;
            CmbUrunKategori.SelectedIndex = -1;
            CmbUrunKategori.Text = "Seçiniz...";
        } //combobox içine kategoriler gelir
        private void altkategorigetir()
        {
            string altkategorigetir= "Select * From UrunAltKategori where kategorid= "+ CmbUrunKategori.SelectedValue;
            CmbAltKategori.DataSource = null;
            DataTable altkategoritablosu = Yardimci.VeriOku(altkategorigetir);
            CmbAltKategori.ValueMember = "Id";
            CmbAltKategori.DisplayMember = "AltKategoriAdi";
            CmbAltKategori.DataSource = altkategoritablosu;
            CmbAltKategori.Text = "Seçiniz...";
        } //combobox içine alt kategoriler gelir
        private void markagetir()
        {
            string markagetir = "Select Id,MarkaAdi From Markalar";
            CmbUrunMarka.DataSource = null;
            DataTable markatablosu = Yardimci.VeriOku(markagetir);
            CmbUrunMarka.ValueMember = "Id";
            CmbUrunMarka.DisplayMember = "MarkaAdi";
            CmbUrunMarka.DataSource = markatablosu;
            CmbUrunMarka.SelectedIndex = -1;
            CmbUrunMarka.Text = "Seçiniz...";
        } //combobox içine marka gelir
        private void TextBos()
        {
            TxtUrunAdi.Text = "";
            TxtUrunKodu.Text = "";
            CmbUrunMarka.SelectedIndex = -1;
            CmbUrunKategori.SelectedIndex = -1;
            CmbAltKategori.SelectedIndex = -1;
            TxtUrunFiyati.Text = "";
            TxtUrunAciklama.Text = "";
            checkBoxAktiflik.Checked = false;
        } //texbox içini boşaltır
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        } //çarpıya basılınca kapanan ekran
        private void CmbUrunKategori_SelectedIndexChanged(object sender, EventArgs e) //kategorinin altkategorilerini getirir
        {
            if(CmbUrunKategori.SelectedIndex != -1)
            {
                altkategorigetir();
            }
           
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string today = DateTime.Now.ToString("yyyy/MM/dd");
            string[] Param = { "@UrunAdi", "@UrunKodu", "@markaid","@kategorid","@altkategorid","@UrunFiyat","@UrunAciklama", "@UrunDurum", "@UrunEklemeTarih" };
            string[] Deger = { TxtUrunAdi.Text, TxtUrunKodu.Text, CmbUrunMarka.SelectedValue.ToString(), CmbUrunKategori.SelectedValue.ToString() , CmbAltKategori.SelectedValue.ToString(), TxtUrunFiyati.Text.ToString(),TxtUrunAciklama.Text, checkBoxAktiflik.Checked.ToString(),today };
            bool mesaj = Yardimci.Kaydet_Procedure("spUrunEkle", Param, Deger);
            if (mesaj)
            {
                MessageBox.Show("Ürün Ekleme İşlemi Başarılı...");
            }
            else
            {
                MessageBox.Show("İşlem başarısız","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
             TextBos();
        } //ürün eklenir
        private void BtnListele_Click(object sender, EventArgs e) //grid içine verileri getirme
        {
            string urunlistele = "exec spUrunListele";
            DataTable urungetir = Yardimci.VeriOku(urunlistele);
            dataUrunler.DataSource = urungetir;
        }
        private void Btngüncelle_Click(object sender, EventArgs e) //bilgileri güncelle
        {
            string today = DateTime.Now.ToString("yyyy/MM/dd");
            string[] Param = { "@Id","@UrunAdi", "@UrunKodu", "@markaid", "@kategorid", "@altkategorid", "@UrunFiyat", "@UrunAciklama", "@UrunDurum", "@UrunEklemeTarih" };
            string[] Deger = { labelid.Text,TxtUrunAdi.Text , TxtUrunKodu.Text ,CmbUrunMarka.SelectedValue.ToString() , CmbUrunKategori.SelectedValue.ToString() , CmbAltKategori.SelectedValue.ToString() ,TxtUrunFiyati.Text.ToString() ,TxtUrunAciklama.Text ,checkBoxAktiflik.Checked.ToString() , today.ToString()};
            bool mesaj = Yardimci.Kaydet_Procedure("spUrunGuncelle", Param, Deger);
            if (mesaj)
            {
                MessageBox.Show("Ürün Güncelleme İşlemi Başarılı...");
            }
            else
            {
                MessageBox.Show("İşlem başarısız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TextBos();
        }
        private void dataUrunler_SelectionChanged(object sender, EventArgs e) //grid verileri texbox a aktarma
        {
            if ( dataUrunler.SelectedRows.Count>0)
            {  
                int secilensatir = dataUrunler.CurrentRow.Index;
                int id = Convert.ToInt32(dataUrunler.Rows[secilensatir].Cells[0].Value.ToString());
                labelid.Text = id.ToString();
                TxtUrunAdi.Text = dataUrunler.Rows[secilensatir].Cells[1].Value.ToString();
                TxtUrunKodu.Text = dataUrunler.Rows[secilensatir].Cells[2].Value.ToString();
                CmbUrunMarka.Text = dataUrunler.Rows[secilensatir].Cells[3].Value.ToString();
                CmbUrunKategori.Text = dataUrunler.Rows[secilensatir].Cells[4].Value.ToString();
                CmbAltKategori.Text = dataUrunler.Rows[secilensatir].Cells[5].Value.ToString();
                TxtUrunFiyati.Text = dataUrunler.Rows[secilensatir].Cells[6].Value.ToString();
                TxtUrunAciklama.Text = dataUrunler.Rows[secilensatir].Cells[7].Value.ToString();
                checkBoxAktiflik.Checked = Convert.ToBoolean(dataUrunler.Rows[secilensatir].Cells[8].Value.ToString());
            }  
        }
        private void BtnSil_Click(object sender, EventArgs e) //ürün sil
        {
            DialogResult cevap = MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    string[] Param = { "@Id"};
                    string[] Deger = { labelid.Text};
                    bool mesaj = Yardimci.Kaydet_Procedure("spUrunSil", Param, Deger);
                    if (mesaj)
                    {
                        MessageBox.Show("Ürün Silme İşlemi Başarılı...");
                    }
                    else
                    {
                        MessageBox.Show("İşlem başarısız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    TextBos();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata meydana geldi!",hata.Message);
                }
            }
        }
    }
}
