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
    public partial class Admin_Bildirim : Form
    {
        public Admin_Bildirim()
        {
            InitializeComponent();
        }
        private void Admin_Bildirim_Load(object sender, EventArgs e)
        {
           
            string sorgu = "Select * from IletisimFormu";
            DataTable bildirimgetir = Yardimci.VeriOku(sorgu);
            databildirim.DataSource = bildirimgetir;
            //grid içinde mesaja tıklanınca detayı gözükmeli!!!!
        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
