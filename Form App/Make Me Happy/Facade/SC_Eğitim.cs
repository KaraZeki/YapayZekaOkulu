using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_Me_Happy.Facade
{
    public class SC_Eğitim
    {
        public static bool egitimEkle(string komut,string fonksiyon)
        {
            SqlCommand komt = new SqlCommand("INSERT INTO tbl_SC(Komut,Calisacak_Fonk) values (@p1,@p2)", Tools.Baglanti);
            komt.Parameters.AddWithValue("@p1", komut);
            komt.Parameters.AddWithValue("@p2", fonksiyon);
            return Tools.ExecuteNonQuery(komt);

        }
        public static string veriGetir(string komut)
        {
            SqlCommand komt = new SqlCommand("SELECT * FROM tbl_SC WHERE Komut='" + komut + "'", Tools.Baglanti);
            Tools.Baglanti.Open();
            SqlDataReader dr = komt.ExecuteReader();
            string fonksiyon = "";
            while (dr.Read())
            {
                fonksiyon = dr["Calisacak_Fonk"].ToString();
            }

            Tools.Baglanti.Close();
            return fonksiyon;
        }
    }
}
