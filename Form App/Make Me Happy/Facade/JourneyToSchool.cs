using Make_Me_Happy.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_Me_Happy.Facade
{
    public class JourneyToSchool
    {
        public static bool egitimEkle(string yas,string kilo,string uzaklik,string ulasimTipi)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO tbl_JourneyToSchool(Yas,Kilo,Uzaklik,UlasimTipi) values (@p1,@p2,@p3,@p4)", Tools.Baglanti);
            komut.Parameters.AddWithValue("@p1", yas);
            komut.Parameters.AddWithValue("@p2", kilo);
            komut.Parameters.AddWithValue("@p3", uzaklik);
            komut.Parameters.AddWithValue("@p4", ulasimTipi);
            return Tools.ExecuteNonQuery(komut);
        }
        public static string veriGetir(JourneySchool journey)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_JourneyToSchool WHERE Yas='"+journey.Yas+"'"+" and Kilo='"+journey.Kilo+"'"+" and uzaklik='"+journey.Uzaklik+"'",Tools.Baglanti);
            Tools.Baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            string gelenVeri = "";
            while (dr.Read())
            {
                gelenVeri = dr["UlasimTipi"].ToString();
            }
            Tools.Baglanti.Close();
            return gelenVeri;
        }
    }
}
