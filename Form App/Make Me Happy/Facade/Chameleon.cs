using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_Me_Happy.Facade
{
    public class Chameleon
    {
        public static bool egitimEkle(string resim, string renk)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO tbl_Chameleon(resimYolu,resimRenk) values (@p1,@p2)", Tools.Baglanti);
            komut.Parameters.AddWithValue("@p1", resim);
            komut.Parameters.AddWithValue("@p2", renk);
            return Tools.ExecuteNonQuery(komut);
        }
        public static string veriGetir(string resimYolu)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_Chameleon WHERE resimYolu='" + resimYolu + "'", Tools.Baglanti);
            Tools.Baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            string fonksiyon = "";
            while (dr.Read())
            {
                fonksiyon = dr["resimRenk"].ToString();
            }
            Tools.Baglanti.Close();
            return fonksiyon;
        }

    }
}
