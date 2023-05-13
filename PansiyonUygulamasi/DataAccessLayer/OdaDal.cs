using PansiyonUygulamasi.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PansiyonUygulamasi.DataAccessLayer
{
    public class OdaDal : IRepository<Oda>
    {
        public bool Ekle(Oda entity)
        {
            SqlCommand komut = new SqlCommand("Insert Into Odalar (OdaNo, OdaFiyati, MusaitMi, AktifMi) Values (@odaNo, @odaFiyati, @musaitMi, @aktifMi)", Tools.Baglanti);

            komut.Parameters.AddWithValue("@odaNo", entity.OdaNo);
            komut.Parameters.AddWithValue("@odaFiyati", entity.OdaFiyati);
            komut.Parameters.AddWithValue("@musaitMi", entity.MusaitMi);
            komut.Parameters.AddWithValue("@aktifMi", entity.AktifMi);

            return Tools.ExecuteNonQuery(komut);
        }

        public bool Guncelle(Oda entity)
        {
            SqlCommand komut = new SqlCommand("Update Odalar SET OdaNo = @odaNo, OdaFiyati = @odaFiyati, MusaitMi = @musaitMi, AktifMi = @aktifMi, GuncellemeTarihi = @guncellemeTarihi where Id = @id", Tools.Baglanti);

            komut.Parameters.AddWithValue("@id", entity.Id);
            komut.Parameters.AddWithValue("@odaNo", entity.OdaNo);
            komut.Parameters.AddWithValue("@odaFiyati", entity.OdaFiyati);
            komut.Parameters.AddWithValue("@musaitMi", entity.MusaitMi);
            komut.Parameters.AddWithValue("@aktifMi", entity.AktifMi);
            komut.Parameters.AddWithValue("@guncellemeTarihi", entity.GuncellemeTarihi);

            return Tools.ExecuteNonQuery(komut);
        }

        public DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("OdaListele", Tools.Baglanti);

            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            adp.Fill(dt);

            return dt;
        }

        public bool Sil(int id)
        {
            SqlCommand komut = new SqlCommand("Delete from Odalar where Id=@id", Tools.Baglanti);

            komut.Parameters.AddWithValue("@id", id);

            return Tools.ExecuteNonQuery(komut);
        }

        public List<Oda> OdaListele()
        {
            List<Oda> odaList = new List<Oda>();

            SqlCommand komut = new SqlCommand("Select * from Odalar where AktifMi = @aktifMi", Tools.Baglanti);

            komut.Parameters.AddWithValue("@aktifMi", true);

            try
            {
                if (Tools.Baglanti.State == ConnectionState.Closed)
                {
                    Tools.Baglanti.Open();
                }
                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    Oda oda = new Oda()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        OdaNo = reader["OdaNo"].ToString(),
                        OdaFiyati = Convert.ToDouble(reader["OdaFiyati"]),
                        MusaitMi = Convert.ToBoolean(reader["MusaitMi"]),
                        AktifMi = Convert.ToBoolean(reader["AktifMi"])
                    };

                    odaList.Add(oda);

                }
            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                if (Tools.Baglanti.State == ConnectionState.Open)
                {
                    Tools.Baglanti.Close();
                }
            }

            return odaList;
        }

        public bool DurumGuncelle(Oda oda)
        {
            SqlCommand komut = new SqlCommand("Update Odalar set MusaitMi = @musaitMi where Id=@id", Tools.Baglanti);
            komut.Parameters.AddWithValue("@musaitMi", oda.MusaitMi);
            komut.Parameters.AddWithValue("@id", oda.Id);
            return Tools.ExecuteNonQuery(komut);
        }
    }
}
