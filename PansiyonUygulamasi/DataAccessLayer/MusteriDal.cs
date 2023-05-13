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
    public class MusteriDal : IRepository<Musteri>
    {
        public bool Ekle(Musteri entity)
        {
            SqlCommand komut = new SqlCommand("Insert Into Musteriler (Adi, Soyadi, KimlikNo, Cinsiyet, Telefon, Adres, Email) Values (@adi, @soyadi, @kimlikNo, @cinsiyet, @telefon, @adres, @email)",Tools.Baglanti);

            komut.Parameters.AddWithValue("@adi",entity.Adi);
            komut.Parameters.AddWithValue("@soyadi",entity.Soyadi);
            komut.Parameters.AddWithValue("@kimlikNo",entity.KimlikNo);
            komut.Parameters.AddWithValue("@cinsiyet",entity.Cinsiyet);
            komut.Parameters.AddWithValue("@telefon",entity.Telefon);
            komut.Parameters.AddWithValue("@adres",entity.Adres);
            komut.Parameters.AddWithValue("@email",entity.Email);

            return Tools.ExecuteNonQuery(komut);
        }

        public bool Guncelle(Musteri entity)
        {
            SqlCommand komut = new SqlCommand("Update Musteriler set Adi = @adi, Soyadi = @soyadi, KimlikNo = @kimlikNo, Cinsiyet = @cinsiyet, Telefon = @telefon, Adres = @adres, Email = @email, GuncellemeTarihi = @guncellemeTarihi where Id = @id", Tools.Baglanti);

            komut.Parameters.AddWithValue("@id", entity.Id);
            komut.Parameters.AddWithValue("@adi", entity.Adi);
            komut.Parameters.AddWithValue("@soyadi", entity.Soyadi);
            komut.Parameters.AddWithValue("@kimlikNo", entity.KimlikNo);
            komut.Parameters.AddWithValue("@cinsiyet", entity.Cinsiyet);
            komut.Parameters.AddWithValue("@telefon", entity.Telefon);
            komut.Parameters.AddWithValue("@adres", entity.Adres);
            komut.Parameters.AddWithValue("@email", entity.Email);
            komut.Parameters.AddWithValue("@guncellemeTarihi", entity.GuncellemeTarihi);

            return Tools.ExecuteNonQuery(komut);
        }

        public DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("MusteriListele", Tools.Baglanti);

            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dataTable = new DataTable();

            adp.Fill(dataTable);

            return dataTable;
        }

        public bool Sil(int id)
        {
            SqlCommand komut = new SqlCommand("Delete from Musteriler where Id=@id", Tools.Baglanti);

            komut.Parameters.AddWithValue("@id", id);

            return Tools.ExecuteNonQuery(komut);
        }
    }
}
