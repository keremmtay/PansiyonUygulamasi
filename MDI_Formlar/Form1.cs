using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Formlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.MdiParent = this;

            FormGetir(form2);



            
        }

        private void FormGetir(Form form)
        {
            panel2.Controls.Clear();

            panel2.Controls.Add(form);

            //form.FormBorderStyle = FormBorderStyle.None;

            form.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.MdiParent = this;

            FormGetir(form3);
        }

        

        private void form2AçToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            FormGetir(form2);
        }

        private void form3AçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            FormGetir(form3);
        }
    }
}
