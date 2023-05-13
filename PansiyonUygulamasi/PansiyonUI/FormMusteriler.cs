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
    public partial class FormMusteriler : Form
    {

        MusteriDal musteriDal = new MusteriDal();

        public FormMusteriler()
        {
            InitializeComponent();
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void FormTemizle()
        {
            tbxId.Clear();
            tbxAdi.Clear();
            tbxSoyadi.Clear();
            tbxKimlikNo.Clear();
            cbxCinsiyet.Text = string.Empty;
            mtbxTelefon.Clear();
            tbxAdres.Clear();
            tbxEmail.Clear();


        }

        private void FormMusteriler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = musteriDal.Listele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri()
            {
                Adi = tbxAdi.Text,
                Soyadi = tbxSoyadi.Text,
                KimlikNo = tbxKimlikNo.Text,
                Cinsiyet = cbxCinsiyet.Text,
                Telefon = mtbxTelefon.Text,
                Email = tbxEmail.Text,
                Adres = tbxAdres.Text
            };

            if (musteriDal.Ekle(musteri))
            {
                MessageBox.Show("Müşteri başarıyla kaydedildi.");
            }
            else
            {
                MessageBox.Show("Müşteri kaydedilirken bir hata oluştu.");
            }

            Listele();

            FormTemizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxKimlikNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbxCinsiyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mtbxTelefon.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbxAdres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxId.Text != null && tbxId.Text != string.Empty)
            {
                Musteri musteri = new Musteri()
                {
                    Id = Convert.ToInt32(tbxId.Text),
                    Adi = tbxAdi.Text,
                    Soyadi = tbxSoyadi.Text,
                    KimlikNo = tbxKimlikNo.Text,
                    Cinsiyet = cbxCinsiyet.Text,
                    Telefon = mtbxTelefon.Text,
                    Email = tbxEmail.Text,
                    Adres = tbxAdres.Text,
                    GuncellemeTarihi = DateTime.Now
                };

                if (musteriDal.Guncelle(musteri))
                {
                    MessageBox.Show($"{musteri.Id} id'li müşteri başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show($"{musteri.Id} id'li müşteri güncellenirken bir hata oluştu.");
                }

                FormTemizle();

                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir kayıt seçiniz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbxId.Text != string.Empty)
            {
                DialogResult secenek = MessageBox.Show("Seçili kaydı silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    if (musteriDal.Sil(Convert.ToInt32(tbxId.Text)))
                    {
                        MessageBox.Show($"{tbxId.Text} id'li müşteri kaydı silinmiştir.");
                    }
                    else
                    {
                        MessageBox.Show($"{tbxId.Text} id'li müşteri kaydı silinemedi.");
                    }

                    FormTemizle();

                    Listele();
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi.");
                }
            }
            else
            {
                MessageBox.Show("Silme işlemi için kayıt seçmeniz gerekmektedir.");
            }
        }

        private void btnKonaklamaEkle_Click(object sender, EventArgs e)
        {
            FormKonaklamalar formKonaklamalar = new FormKonaklamalar();

            formKonaklamalar.MusteriAdiSoyadi = tbxAdi.Text + " " + tbxSoyadi.Text;

            formKonaklamalar.MusteriId = tbxId.Text;

            formKonaklamalar.ShowDialog();
        }

        
    }
}
