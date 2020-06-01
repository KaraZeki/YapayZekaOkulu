using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_Me_Happy.Facade
{
    public class MMH_Resim
    {
        public static bool resimEkle(string resimYolu,string resimTip)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO tbl_Resim(Resim,Tip) values(@resimYolu,@resimTip)", Tools.Baglanti);
            komut.Parameters.AddWithValue("@resimYolu", resimYolu);
            komut.Parameters.AddWithValue("@resimTip", resimTip);
            return Tools.ExecuteNonQuery(komut);
        }
        public static string resimKontrol(string resimYolu)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_Resim WHERE Resim='"+resimYolu+"'", Tools.Baglanti);
            Tools.Baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            string resimTip="";
            while (dr.Read())
            {
                resimTip = dr["Tip"].ToString();
            }
            Tools.Baglanti.Close();

            return resimTip;
        }
    }
}
