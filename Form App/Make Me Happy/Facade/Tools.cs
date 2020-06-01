using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_Me_Happy.Facade
{
    public class Tools
    {
        private static SqlConnection baglanti = new SqlConnection(@"Data Source = YAKUP\SQLEXPRESS; Initial Catalog = MakeMeHappy; Integrated Security = True");

        public static SqlConnection Baglanti
        {
            get { return baglanti; }
            set { baglanti = value; }
        }

        public static bool ExecuteNonQuery(SqlCommand komut)
        {
            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                    komut.Connection.Open();
                return komut.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (komut.Connection.State != ConnectionState.Closed)
                    komut.Connection.Close();
            }
        }
    }
}
