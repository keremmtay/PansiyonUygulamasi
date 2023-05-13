using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikButonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aşağıda dinamik bir şekilde bir buton nesnesi oluşturduk ve butonun konumlanacağı X ve Y koordinatlarını verdik. Ve yine butonun boyutlarını belirlemek için yükseklik ve genişlik değerlerini verdik.
            // İstediğimiz sayıda buton nesnesi oluşturmak için for döngüsünü kullandık. Birden fazla buton nesnesi oluşturduğumuz için de her bir butonun farklı yerlerde konumlanması için X ve Y değerlerini değiştirdik.
            // Her bir satirda kaç tane buton olacağını belirlemek için satır isimli değişkeni tanımladık.

            int pozisyonX = 50, pozisyonY = 50;

            int satir = 1;

            int butonSayisi = 8;    // buton sayısını burada belirliyoruz.

            for (int i = 0; i < butonSayisi; i++) // buton sayısı kadar döngü çalışacak
            {
                Button button = new Button(); // buton nesnesini oluşturuyoruz

                button.Text = "Button Nesnesi"; // textine bir şeyler yazdık

                // Aşağıda butonun boyutlarını belirledik.

                button.Height = 50; // yükseklik

                button.Width = 75; // genişlik

                // yukarıda tanımladığımız pozisyonX ve pozisyonY ile ilk butonun konumlanacağı yeri aşağıdaki satırda belirledik.

                button.Location = new Point(pozisyonX, pozisyonY);

                // Aşağıdaki satır ile buton nesnesini form içine ekledik.

                this.Controls.Add(button);

                // if ile satırdaki buton sayısını belirliyoruz ve her br satırda butonların konumlanacağı X değerini değiştiriyoruz.

                if (satir < 5)
                {
                    pozisyonX += 100;
                    satir++;
                }
                else
                {
                    // satırda 5 tane buton yerleştirildikten sonra alt satıra geçmesi için Y değerini değiştiriyoruz ve butonların X değerini de ilk değerine çekiyoruz

                    pozisyonX = 50;
                    pozisyonY += 75;
                    satir = 1;
                }

                
            }
        }
    }
}
