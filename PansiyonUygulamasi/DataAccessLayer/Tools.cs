using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PansiyonUygulamasi.DataAccessLayer
{
    public class Tools
    {
        private static readonly SqlConnection baglanti = new SqlConnection("Server=ASUS;Database=PansiyonUygulamasi;Integrated Security=true");

        public static SqlConnection Baglanti
        {
            get { return baglanti; }
        }

        public static bool ExecuteNonQuery(SqlCommand komut)
        {
            bool sonuc = false;

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                if (komut.ExecuteNonQuery()>0)
                {
                    sonuc = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ExecuteNonQuery çalışırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }

            return sonuc;

        }

        public static bool ExecuteReader(SqlCommand komut)
        {
            bool sonuc = false;

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                if (komut.ExecuteReader().HasRows)
                {
                    sonuc = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }


            return sonuc;
        }
    }
}
