using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_Me_Happy.Facade
{
    public class CarOrCup
    {
        public static bool egitimEkle(string resimYolu,string tip)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO tbl_CarOrCup(ResimYolu,Tip) values (@p1,@p2)", Tools.Baglanti);
            komut.Parameters.AddWithValue("@p1", resimYolu);
            komut.Parameters.AddWithValue("@p2", tip);
            return Tools.ExecuteNonQuery(komut);
        }
        public static List<string> veriGetirAraba()
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_CarOrCup where Tip='Araba'", Tools.Baglanti);
            Tools.Baglanti.Open();
            List<string> listVeriAraba = new List<string>();
            SqlDataReader dr = komut.ExecuteReader();
            string resimYolu = "";
            while (dr.Read())
            {
                resimYolu = dr["ResimYolu"].ToString();
                listVeriAraba.Add(resimYolu);
            }
            Tools.Baglanti.Close();

            return listVeriAraba;
        }
        public static List<string> veriGetirBardak()
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_CarOrCup where Tip='Kupa Bardak'", Tools.Baglanti);
            Tools.Baglanti.Open();
            List<string> listVeriBardak = new List<string>();
            SqlDataReader dr = komut.ExecuteReader();
            string resimYolu = "";
            while (dr.Read())
            {
                resimYolu = dr["ResimYolu"].ToString();
                listVeriBardak.Add(resimYolu);
            }
            Tools.Baglanti.Close();

            return listVeriBardak;
        }
    }
}
