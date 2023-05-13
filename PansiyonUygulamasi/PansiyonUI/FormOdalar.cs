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
    public partial class FormOdalar : Form
    {
        OdaDal odaDal = new OdaDal();

        public FormOdalar()
        {
            InitializeComponent();
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void FormuTemizle()
        {
            tbxId.Clear();
            tbxOdaNo.Clear();
            tbxOdaFiyati.Clear();
            cbxMusaitMi.Checked = false;
            cbxAktifMi.Checked = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Oda oda = new Oda()
            {
                OdaNo = tbxOdaNo.Text,
                OdaFiyati = Convert.ToDouble(tbxOdaFiyati.Text),
                MusaitMi = cbxMusaitMi.Checked,
                AktifMi = cbxAktifMi.Checked
            };
            
            if (odaDal.Ekle(oda))
            {
                MessageBox.Show("Oda başarıyla eklendi.");
            }
            else
            {
                MessageBox.Show("Oda eklenirken bir hata oluştu.");
            }

            Listele();

            FormuTemizle();
        }

        private void Listele()
        {
            dataGridView1.DataSource = odaDal.Listele();
        }

        private void FormOdalar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxOdaNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxOdaFiyati.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbxMusaitMi.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[3].Value);
            cbxAktifMi.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[4].Value);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxId.Text != null && tbxId.Text != string.Empty)
            {
                Oda oda = new Oda()
                {
                    Id = Convert.ToInt32(tbxId.Text),
                    OdaNo = tbxOdaNo.Text,
                    OdaFiyati = Convert.ToDouble(tbxOdaFiyati.Text),
                    MusaitMi = cbxMusaitMi.Checked,
                    AktifMi = cbxAktifMi.Checked,
                    GuncellemeTarihi = DateTime.Now
                    
                };

                if (odaDal.Guncelle(oda))
                {
                    MessageBox.Show($"{oda.Id} id'li oda başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show($"{oda.Id} id'li oda güncellenirken bir hata oluştu.");
                }

                FormuTemizle();

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
                    if (odaDal.Sil(Convert.ToInt32(tbxId.Text)))
                    {
                        MessageBox.Show($"{tbxId.Text} id'li oda silinmiştir.");
                    }
                    else
                    {
                        MessageBox.Show($"{tbxId.Text} id'li oda silinirken bir hata oluştu.");
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
                MessageBox.Show("Silme işlemi için kayıt seçmeniz gerekmektedir.");
            }
        }

        private void cbxMusaitMi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMusaitMi.Checked)
            {
                cbxMusaitMi.Text = "Müsait";
            }
            else
            {
                cbxMusaitMi.Text = "Müsait Değil";
            }
        }

        private void cbxAktifMi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAktifMi.Checked)
            {
                cbxAktifMi.Text = "Aktif";
            }
            else
            {
                cbxAktifMi.Text = "Aktif Değil";
            }
        }
    }
}
