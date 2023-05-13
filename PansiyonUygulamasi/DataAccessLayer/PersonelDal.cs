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
    public class PersonelDal : IRepository<Personel>
    {
        public bool Ekle(Personel entity)
        {
            //throw new NotImplementedException(); // bu satır kalırsa Ekle metodu çağrıldığında bir exception fırlatacak (NotImplementedException). Bunun anlamı metot Interface vasıtasıyla oluşturulduğu için yazılımcının burayı doldurması gerekir. Gerekli kodları yazmayı unutmaması için bu satır otomatik olarak ekleniyor...

            SqlCommand komut = new SqlCommand("Insert Into Personeller (Adi, Soyadi, KimlikNo, KullaniciAdi, Sifre, Telefon, Adres) Values(@adi, @soyadi, @kimlikNo, @kullaniciAdi, @sifre, @telefon, @adres)",Tools.Baglanti);

            komut.Parameters.AddWithValue("@adi", entity.Adi);
            komut.Parameters.AddWithValue("@soyadi", entity.Soyadi);
            komut.Parameters.AddWithValue("@kimlikNo", entity.KimlikNo);
            komut.Parameters.AddWithValue("@kullaniciAdi", entity.KullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", entity.Sifre);
            komut.Parameters.AddWithValue("@telefon", entity.Telefon);
            komut.Parameters.AddWithValue("@adres", entity.Adres);

            return Tools.ExecuteNonQuery(komut);
        }

        public bool Guncelle(Personel entity)
        {
            SqlCommand komut = new SqlCommand("Update Personeller SET Adi=@adi, Soyadi=@soyadi, KimlikNo=@kimlikNo, KullaniciAdi=@kullaniciAdi, Sifre=@sifre, Telefon=@telefon, Adres=@adres, GuncellemeTarihi=@guncellemeTarihi where Id=@id", Tools.Baglanti);

            komut.Parameters.AddWithValue("@id", entity.Id);
            komut.Parameters.AddWithValue("@adi", entity.Adi);
            komut.Parameters.AddWithValue("@soyadi", entity.Soyadi);
            komut.Parameters.AddWithValue("@kimlikNo", entity.KimlikNo);
            komut.Parameters.AddWithValue("@kullaniciAdi", entity.KullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", entity.Sifre);
            komut.Parameters.AddWithValue("@telefon", entity.Telefon);
            komut.Parameters.AddWithValue("@adres", entity.Adres);
            komut.Parameters.AddWithValue("@guncellemeTarihi", entity.GuncellemeTarihi);

            return Tools.ExecuteNonQuery(komut);
        }

        public DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("PersonelListele", Tools.Baglanti);

            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dataTable = new DataTable();

            adp.Fill(dataTable);

            return dataTable;
        }

        public bool Sil(int id)
        {
            SqlCommand komut = new SqlCommand("Delete from Personeller where Id=@id", Tools.Baglanti);

            komut.Parameters.AddWithValue("@id", id);

            return Tools.ExecuteNonQuery(komut);
        }
    }
}
