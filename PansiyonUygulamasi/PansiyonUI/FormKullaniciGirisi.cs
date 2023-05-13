using PansiyonUygulamasi.DataAccessLayer;
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
    public partial class FormKullaniciGirisi : Form
    {
        public FormKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciKontrolDal kullanici = new KullaniciKontrolDal();

            if (kullanici.KullaniciKontrol(tbxKullaniciAdi.Text, tbxSifre.Text))
            {
                Anasayfa anasayfa = new Anasayfa();

                anasayfa.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı. Lütfen tekrar deneyiniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxKullaniciAdi.Clear();

                tbxSifre.Clear();
            }

            
        }
    }
}
