using PansiyonUygulamasi.DataAccessLayer;
using PansiyonUygulamasi.EntityLayer.Entities;
using PansiyonUygulamasi.PansiyonUI.Araclar;
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
    public partial class FormKonaklamalar : Form
    {
        public string MusteriId { get; set; }
        public string MusteriAdiSoyadi { get; set; }

        KonaklamaDal konaklamaDal = new KonaklamaDal();

        Oda oda;

        public FormKonaklamalar()
        {
            InitializeComponent();
        }

        private void FormKonaklamalar_Load(object sender, EventArgs e)
        {
            tbxMusteriAdiSoyadi.Text = MusteriAdiSoyadi;

            Listele();

            OdaSec();
        }

        private void ToplamFiyatHesapla()
        {
            if (tbxOdaFiyati.Text != string.Empty && dtpGiris.Text != dtpCikis.Text)
            {
                TimeSpan gunSayisi;

                gunSayisi = DateTime.Parse(dtpCikis.Text) - DateTime.Parse(dtpGiris.Text);

                tbxToplamFiyat.Text = (gunSayisi.TotalDays * Convert.ToDouble(tbxOdaFiyati.Text)).ToString();
            }


        }

        private void Listele()
        {
            dataGridView1.DataSource = konaklamaDal.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Konaklama konaklama = new Konaklama()
            {
                MusteriId = Convert.ToInt32(MusteriId),
                OdaId = Convert.ToInt32(tbxOdaId.Text),
                ToplamFiyat = Convert.ToDouble(tbxToplamFiyat.Text),
                GirisTarihi = Convert.ToDateTime(dtpGiris.Text),
                CikisTarihi = Convert.ToDateTime(dtpCikis.Text),
                AktifMi = cbxDurum.Checked,
                GuncellemeTarihi = DateTime.Now,
            };

            oda.MusaitMi = false; // Odanın dolu olduğuna dair ilgili kolondaki veriyi değiştiriyorum

            oda.GuncellemeTarihi = DateTime.Now;

            OdaDal odaDal = new OdaDal();

            // Konaklama ekleniyor ve ilgili odanın müsaitlik durumu da değiştiriliyor.

            if (konaklamaDal.Ekle(konaklama) && odaDal.Guncelle(oda))
            {
                MessageBox.Show("Konaklama başarılı bir şekilde kaydedildi.");

                Listele();

                FormTemizle();

                groupBoxOdalar.Controls.Clear(); // groupBoxOdalar içindeki her bir myButton nesnesi temizleniyor.

                OdaSec(); // Odalar
            }
            else
            {
                MessageBox.Show("Konaklama kaydedilirken bir hata oluştu.");
            }
        }

        private void FormTemizle()
        {
            foreach (Control item in groupBox1.Controls)
                // Her bir element aslında birer Control nesnesidir. Yukarıda groupbox1 içindeki bütün control nesnelerini teker teker geziyorum
            {
                if (item is TextBox) // gezdiğim Control eğer Textbox ise if içindeki işlemleri yap
                {
                    if (item.Name != "tbxMusteriAdiSoyadi") // textbox eğer tbxMusteriAdiSoyadi'na sahipse herhangi bir işlem yapma. Aksi takdirde textbox içeriğini temizle.                   
                        item.Text = "";
                }
                else if (item is DateTimePicker)
                {
                    item.Text = DateTime.Now.ToString();
                }
                cbxDurum.Checked = false;
            }

            //tbxKonaklamaId.Clear();
            //tbxMusteriAdiSoyadi.Clear();
            //tbxOdaFiyati.Clear();
            //tbxOdaId.Clear();
            //tbxOdaNo.Clear();
            //tbxToplamFiyat.Clear();
            //cbxDurum.Checked = false;
            //dtpGiris.Checked = false;
            //dtpCikis.Checked = false;
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void OdaSec()
        {
            OdaDal odaDal = new OdaDal();

            int pozisyonX = 30, pozisyonY = 30, sutun = 1;

            for (int i = 0; i < odaDal.OdaListele().Count; i++)
            {
                MyButton myButton = new MyButton();

                myButton.Oda = odaDal.OdaListele()[i];

                myButton.Location = new Point(pozisyonX, pozisyonY);

                myButton.Width = 50;

                myButton.Height = 50;

                myButton.Text = odaDal.OdaListele()[i].OdaNo;

                myButton.Name = odaDal.OdaListele()[i].Id.ToString();

                // O anki buton nesnesinin Click eventi aşağıdaki satırda olduğu gibi çağırabiliriz. Parantez içerisindeki (SeciliButon) Bu event için çalışacak olan metodun adıdır.

                myButton.Click += new EventHandler(SeciliButon);

                groupBoxOdalar.Controls.Add(myButton);

                if (odaDal.OdaListele()[i].MusaitMi)
                {
                    myButton.BackColor = Color.Green; // oda boşsa buton yeşil olacak
                }
                else
                {
                    myButton.BackColor= Color.Red; // oda doluysa kırmızı olacak
                    myButton.Enabled = false; // oda doluysa buton tıklanamaz olacak
                }

                // Aşağıdaki yapı ile butonların farklı noktalarda konumlanmasını sağlamış olduk.

                if (sutun < 4)
                {
                    pozisyonX += 75;
                    sutun++;
                }
                else
                {
                    pozisyonX = 30;
                    pozisyonY += 75;
                    sutun = 1;
                }
            }


        }

        // Yukarıda tanımladığımız MyButton nesnelerinin Click Event'i olarak çalışacak metodtur.

        private void SeciliButon(Object sender, EventArgs eventArgs)
        {
            MyButton dinamikButon = (sender as MyButton); //(MyButton)sender; iki şekilde de tanımlanabilir

            tbxOdaNo.Text = dinamikButon.Oda.OdaNo;
            tbxOdaId.Text = dinamikButon.Oda.Id.ToString();
            tbxOdaFiyati.Text = dinamikButon.Oda.OdaFiyati.ToString();

            oda = dinamikButon.Oda;
        }

        private void tbxOdaFiyati_TextChanged(object sender, EventArgs e)
        {
            ToplamFiyatHesapla();
        }

        private void dtpGiris_ValueChanged(object sender, EventArgs e)
        {
            ToplamFiyatHesapla();
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
            ToplamFiyatHesapla();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKonaklamaId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MusteriId = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxMusteriAdiSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxOdaId.Text=dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxOdaNo.Text=dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxOdaFiyati.Text=dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxToplamFiyat.Text=dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dtpGiris.Text=dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dtpCikis.Text=dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cbxDurum.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[9].Value);
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxKonaklamaId.Text != string.Empty && tbxKonaklamaId.Text != null)
            {
                Konaklama konaklama = new Konaklama()
                {
                    Id = Convert.ToInt32(tbxKonaklamaId.Text),
                    MusteriId = Convert.ToInt32(this.MusteriId),
                    OdaId = Convert.ToInt32(tbxOdaId.Text),
                    ToplamFiyat = Convert.ToDouble(tbxToplamFiyat.Text),
                    GirisTarihi = dtpGiris.Value,
                    CikisTarihi = dtpCikis.Value,
                    AktifMi = cbxDurum.Checked,
                    GuncellemeTarihi = DateTime.Now,
                };

                if (konaklamaDal.Guncelle(konaklama))
                {
                    if (konaklama.AktifMi == false)
                    {
                        OdaDal odaDal = new OdaDal();

                        if (oda == null)
                        {
                            oda = new Oda();

                            oda.Id = konaklama.OdaId;
                        }
                        oda.MusaitMi = true;

                        if (odaDal.DurumGuncelle(oda))
                        {
                            MessageBox.Show("Oda güncellendi.");
                        }
                    }

                    MessageBox.Show("Güncelleme işlemi tamamlandı..");

                    Listele();

                    FormTemizle();

                    groupBoxOdalar.Controls.Clear();

                    OdaSec();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi yapılırken hata oluştu.");
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbxKonaklamaId.Text != string.Empty)
            {
                if (konaklamaDal.Sil(Convert.ToInt32(tbxKonaklamaId.Text)))
                {
                    Listele();

                    FormTemizle();
                }
                else
                {
                    MessageBox.Show("Konaklamayı silmek için öncelikle durumu false yapmalısınız.");
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir kayıt seçin.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
