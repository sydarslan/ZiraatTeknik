using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ZiraatTeknik
{
    class Yardimci
    {

        public static SqlConnection Baglanti()
        {
            SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=Ziraat;Integrated Security=True");
            return baglanti;
        }

        public static DataTable VeriOku(string sorgu)
        {
            DataTable dt = new DataTable();
            SqlConnection baglanti = Baglanti();
            SqlCommand Komut = new SqlCommand(sorgu, baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(Komut);
            try
            {
                baglanti.Open();
                sda.Fill(dt);
                baglanti.Close();
            }
            catch (Exception)
            {
                dt = null;

            }
            return dt;
        }

        public static bool Kaydet_Procedure(string sorgu, string[] Parametreler, string[] Degerler)
        {
            bool sonuc = false;
            SqlConnection baglanti = Baglanti();
            SqlCommand Komut = new SqlCommand();
            Komut.Connection = baglanti;
            Komut.CommandType = CommandType.StoredProcedure;
            Komut.CommandText = sorgu;

            for (int i = 0; i < Parametreler.Length; i++)
            {
                Komut.Parameters.AddWithValue(Parametreler[i].ToString(), Degerler[i].ToString());
            }
            try
            {
                baglanti.Open();
                Komut.ExecuteNonQuery();
                baglanti.Close();
                sonuc = true;
            }
            catch (Exception)
            {
                sonuc = false;
            }

            return sonuc;
        }

    }
}
