namespace PansiyonUygulamasi.PansiyonUI
{
    partial class FormKonaklamalar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFormuTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.cbxDurum = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxToplamFiyat = new System.Windows.Forms.TextBox();
            this.tbxOdaFiyati = new System.Windows.Forms.TextBox();
            this.tbxOdaId = new System.Windows.Forms.TextBox();
            this.tbxOdaNo = new System.Windows.Forms.TextBox();
            this.tbxMusteriAdiSoyadi = new System.Windows.Forms.TextBox();
            this.tbxKonaklamaId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxOdalar = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnFormuTemizle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.dtpCikis);
            this.groupBox1.Controls.Add(this.dtpGiris);
            this.groupBox1.Controls.Add(this.cbxDurum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxToplamFiyat);
            this.groupBox1.Controls.Add(this.tbxOdaFiyati);
            this.groupBox1.Controls.Add(this.tbxOdaId);
            this.groupBox1.Controls.Add(this.tbxOdaNo);
            this.groupBox1.Controls.Add(this.tbxMusteriAdiSoyadi);
            this.groupBox1.Controls.Add(this.tbxKonaklamaId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(511, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konaklamalar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(282, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "TL";
            // 
            // btnFormuTemizle
            // 
            this.btnFormuTemizle.Location = new System.Drawing.Point(387, 188);
            this.btnFormuTemizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFormuTemizle.Name = "btnFormuTemizle";
            this.btnFormuTemizle.Size = new System.Drawing.Size(108, 46);
            this.btnFormuTemizle.TabIndex = 12;
            this.btnFormuTemizle.Text = "Formu Temizle";
            this.btnFormuTemizle.UseVisualStyleBackColor = true;
            this.btnFormuTemizle.Click += new System.EventHandler(this.btnFormuTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(387, 136);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(108, 46);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(387, 85);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 46);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(387, 34);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(108, 46);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtpCikis
            // 
            this.dtpCikis.Location = new System.Drawing.Point(170, 175);
            this.dtpCikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(200, 24);
            this.dtpCikis.TabIndex = 6;
            this.dtpCikis.ValueChanged += new System.EventHandler(this.dtpCikis_ValueChanged);
            // 
            // dtpGiris
            // 
            this.dtpGiris.Location = new System.Drawing.Point(170, 139);
            this.dtpGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(200, 24);
            this.dtpGiris.TabIndex = 5;
            this.dtpGiris.ValueChanged += new System.EventHandler(this.dtpGiris_ValueChanged);
            // 
            // cbxDurum
            // 
            this.cbxDurum.AutoSize = true;
            this.cbxDurum.Location = new System.Drawing.Point(170, 251);
            this.cbxDurum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(101, 22);
            this.cbxDurum.TabIndex = 8;
            this.cbxDurum.Text = "checkBox1";
            this.cbxDurum.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Durum";
            // 
            // tbxToplamFiyat
            // 
            this.tbxToplamFiyat.Location = new System.Drawing.Point(170, 210);
            this.tbxToplamFiyat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxToplamFiyat.Name = "tbxToplamFiyat";
            this.tbxToplamFiyat.Size = new System.Drawing.Size(108, 24);
            this.tbxToplamFiyat.TabIndex = 7;
            // 
            // tbxOdaFiyati
            // 
            this.tbxOdaFiyati.Location = new System.Drawing.Point(292, 106);
            this.tbxOdaFiyati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxOdaFiyati.Name = "tbxOdaFiyati";
            this.tbxOdaFiyati.Size = new System.Drawing.Size(57, 24);
            this.tbxOdaFiyati.TabIndex = 4;
            this.tbxOdaFiyati.TextChanged += new System.EventHandler(this.tbxOdaFiyati_TextChanged);
            // 
            // tbxOdaId
            // 
            this.tbxOdaId.Location = new System.Drawing.Point(231, 106);
            this.tbxOdaId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxOdaId.Name = "tbxOdaId";
            this.tbxOdaId.Size = new System.Drawing.Size(57, 24);
            this.tbxOdaId.TabIndex = 3;
            // 
            // tbxOdaNo
            // 
            this.tbxOdaNo.Location = new System.Drawing.Point(170, 106);
            this.tbxOdaNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxOdaNo.Name = "tbxOdaNo";
            this.tbxOdaNo.Size = new System.Drawing.Size(57, 24);
            this.tbxOdaNo.TabIndex = 2;
            // 
            // tbxMusteriAdiSoyadi
            // 
            this.tbxMusteriAdiSoyadi.Location = new System.Drawing.Point(170, 76);
            this.tbxMusteriAdiSoyadi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxMusteriAdiSoyadi.Name = "tbxMusteriAdiSoyadi";
            this.tbxMusteriAdiSoyadi.Size = new System.Drawing.Size(108, 24);
            this.tbxMusteriAdiSoyadi.TabIndex = 1;
            // 
            // tbxKonaklamaId
            // 
            this.tbxKonaklamaId.Location = new System.Drawing.Point(170, 43);
            this.tbxKonaklamaId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxKonaklamaId.Name = "tbxKonaklamaId";
            this.tbxKonaklamaId.Size = new System.Drawing.Size(57, 24);
            this.tbxKonaklamaId.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Toplam Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Çıkış Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giriş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Oda No - ID - Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Adı - Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konaklama ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 345);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(864, 247);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBoxOdalar
            // 
            this.groupBoxOdalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxOdalar.Location = new System.Drawing.Point(538, 10);
            this.groupBoxOdalar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOdalar.Name = "groupBoxOdalar";
            this.groupBoxOdalar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOdalar.Size = new System.Drawing.Size(334, 308);
            this.groupBoxOdalar.TabIndex = 2;
            this.groupBoxOdalar.TabStop = false;
            this.groupBoxOdalar.Text = "Odalar";
            // 
            // FormKonaklamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 602);
            this.Controls.Add(this.groupBoxOdalar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKonaklamalar";
            this.Text = "FormKonaklamalar";
            this.Load += new System.EventHandler(this.FormKonaklamalar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxToplamFiyat;
        private System.Windows.Forms.TextBox tbxOdaFiyati;
        private System.Windows.Forms.TextBox tbxOdaId;
        private System.Windows.Forms.TextBox tbxOdaNo;
        private System.Windows.Forms.TextBox tbxMusteriAdiSoyadi;
        private System.Windows.Forms.TextBox tbxKonaklamaId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFormuTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.CheckBox cbxDurum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxOdalar;
        private System.Windows.Forms.Label label8;
    }
}