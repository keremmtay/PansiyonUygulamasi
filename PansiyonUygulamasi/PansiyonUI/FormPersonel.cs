using PansiyonUygulamasi.DataAccessLayer;
using PansiyonUygulamasi.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonUygulamasi.PansiyonUI
{
    public partial class FormPersonel : Form
    {
        PersonelDal db = new PersonelDal();

        public FormPersonel()
        {
            InitializeComponent();
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = db.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel()
            {
                Adi = tbxAdi.Text,
                Soyadi = tbxSoyadi.Text,
                KimlikNo = tbxKimlikNo.Text,
                KullaniciAdi = tbxKullaniciAdi.Text,
                Sifre = tbxSifre.Text,
                Telefon = mtbxTelefon.Text,
                Adres = tbxAdres.Text
            };

            if (db.Ekle(personel))
            {
                MessageBox.Show("Personel başarıyla kaydedildi.");
            }
            else
            {
                MessageBox.Show("Personel kaydedilirken bir hata oluştu.");
            }

            Listele();

            FormuTemizle();
        }

        private void FormuTemizle()
        {
            tbxAdi.Clear();
            tbxSoyadi.Clear();
            tbxKimlikNo.Clear();
            tbxKullaniciAdi.Clear();
            tbxSifre.Clear();
            mtbxTelefon.Clear();
            tbxAdres.Clear();
            tbxID.Clear();
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxKimlikNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxKullaniciAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxSifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            mtbxTelefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbxAdres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxID.Text != null && tbxID.Text != string.Empty)
            {
                Personel personel = new Personel()
                {
                    Id = Convert.ToInt32(tbxID.Text),
                    Adi = tbxAdi.Text,
                    Soyadi = tbxSoyadi.Text,
                    KimlikNo = tbxKimlikNo.Text,
                    KullaniciAdi = tbxKullaniciAdi.Text,
                    Sifre = tbxSifre.Text,
                    Telefon = mtbxTelefon.Text,
                    Adres = tbxAdres.Text,
                    GuncellemeTarihi = DateTime.Now
                };

                if (db.Guncelle(personel))
                {
                    MessageBox.Show($"{personel.Id} nolu ID'ye sahip veri güncellendi.");
                }
                else
                {
                    MessageBox.Show($"{personel.Id} nolu ID'ye sahip veri güncellenirken bir hata oluştu.");
                }

                FormuTemizle();

                Listele();
            }
            else
            {
                Console.WriteLine("Lütfen güncellemek için bir kayıt seçin..");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (tbxID.Text != string.Empty)
            {
                DialogResult secenek = MessageBox.Show("Seçili kaydı silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                // MessageBoxButtons. 'un farklı kullanım alanları da bulunmaktadır.

                if (secenek == DialogResult.Yes)
                {
                    // Kaydı silecek kodlar buraya yazılır.

                    //bool sonuc = db.Sil(Convert.ToInt32(tbxId.Text));
                    //if (sonuc)
                    if (db.Sil(Convert.ToInt32(tbxID.Text)))
                    {
                        MessageBox.Show($"{tbxID.Text} id'li kayıt silindi");
                    }
                    else
                    {
                        MessageBox.Show($"{tbxID.Text} id'li kayıt silinemedi");
                    }
                    FormuTemizle();
                    Listele();

                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi.");
                }
            }
            else
            {
                MessageBox.Show("Silme işlemi için bir kayıt seçin.");
            }

        }
    }
}
