
namespace Transkript_Uygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DersKodu = new System.Windows.Forms.TextBox();
            this.txt_DersAdi = new System.Windows.Forms.TextBox();
            this.txt_Kredi = new System.Windows.Forms.TextBox();
            this.txt_AKTS = new System.Windows.Forms.TextBox();
            this.txt_OgretimUyesiAdi = new System.Windows.Forms.TextBox();
            this.txt_OgretimUyesiSoyadi = new System.Windows.Forms.TextBox();
            this.txt_Donem = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btn_KayitlariListele = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_DersKodu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_HarfNotu = new System.Windows.Forms.ComboBox();
            this.btn_NotGirisi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_DersKoduKayitSil = new System.Windows.Forms.TextBox();
            this.txt_Gano = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_GanoHesapla = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Gano = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kredi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "AKTS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Öğretim Üyesinin Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Öğretim Üyesinin Soyadı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dersin Bulunduğu Dönem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(33, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Harf Notu";
            // 
            // txt_DersKodu
            // 
            this.txt_DersKodu.Location = new System.Drawing.Point(136, 44);
            this.txt_DersKodu.Name = "txt_DersKodu";
            this.txt_DersKodu.Size = new System.Drawing.Size(73, 22);
            this.txt_DersKodu.TabIndex = 8;
            // 
            // txt_DersAdi
            // 
            this.txt_DersAdi.Location = new System.Drawing.Point(136, 86);
            this.txt_DersAdi.Name = "txt_DersAdi";
            this.txt_DersAdi.Size = new System.Drawing.Size(73, 22);
            this.txt_DersAdi.TabIndex = 9;
            // 
            // txt_Kredi
            // 
            this.txt_Kredi.Location = new System.Drawing.Point(136, 135);
            this.txt_Kredi.Name = "txt_Kredi";
            this.txt_Kredi.Size = new System.Drawing.Size(73, 22);
            this.txt_Kredi.TabIndex = 10;
            // 
            // txt_AKTS
            // 
            this.txt_AKTS.Location = new System.Drawing.Point(136, 186);
            this.txt_AKTS.Name = "txt_AKTS";
            this.txt_AKTS.Size = new System.Drawing.Size(73, 22);
            this.txt_AKTS.TabIndex = 11;
            // 
            // txt_OgretimUyesiAdi
            // 
            this.txt_OgretimUyesiAdi.Location = new System.Drawing.Point(395, 44);
            this.txt_OgretimUyesiAdi.Name = "txt_OgretimUyesiAdi";
            this.txt_OgretimUyesiAdi.Size = new System.Drawing.Size(100, 22);
            this.txt_OgretimUyesiAdi.TabIndex = 12;
            // 
            // txt_OgretimUyesiSoyadi
            // 
            this.txt_OgretimUyesiSoyadi.Location = new System.Drawing.Point(395, 88);
            this.txt_OgretimUyesiSoyadi.Name = "txt_OgretimUyesiSoyadi";
            this.txt_OgretimUyesiSoyadi.Size = new System.Drawing.Size(100, 22);
            this.txt_OgretimUyesiSoyadi.TabIndex = 13;
            // 
            // txt_Donem
            // 
            this.txt_Donem.Location = new System.Drawing.Point(395, 137);
            this.txt_Donem.Name = "txt_Donem";
            this.txt_Donem.Size = new System.Drawing.Size(100, 22);
            this.txt_Donem.TabIndex = 14;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btn_KayitlariListele);
            this.groupBox.Controls.Add(this.btn_Temizle);
            this.groupBox.Controls.Add(this.btn_Guncelle);
            this.groupBox.Controls.Add(this.btn_Ekle);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.txt_Donem);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.txt_OgretimUyesiSoyadi);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.txt_OgretimUyesiAdi);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.txt_AKTS);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.txt_Kredi);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.txt_DersAdi);
            this.groupBox.Controls.Add(this.txt_DersKodu);
            this.groupBox.Location = new System.Drawing.Point(12, 71);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(501, 294);
            this.groupBox.TabIndex = 16;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Bilgiler";
            // 
            // btn_KayitlariListele
            // 
            this.btn_KayitlariListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KayitlariListele.Location = new System.Drawing.Point(243, 239);
            this.btn_KayitlariListele.Name = "btn_KayitlariListele";
            this.btn_KayitlariListele.Size = new System.Drawing.Size(223, 32);
            this.btn_KayitlariListele.TabIndex = 3;
            this.btn_KayitlariListele.Text = "Kayıtları Listele";
            this.btn_KayitlariListele.UseVisualStyleBackColor = true;
            this.btn_KayitlariListele.Click += new System.EventHandler(this.btn_KayitlariListele_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Location = new System.Drawing.Point(26, 239);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(203, 32);
            this.btn_Temizle.TabIndex = 19;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(366, 186);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(100, 29);
            this.btn_Guncelle.TabIndex = 17;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(243, 186);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(101, 29);
            this.btn_Ekle.TabIndex = 16;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(22, 70);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(191, 31);
            this.btn_Sil.TabIndex = 18;
            this.btn_Sil.Text = "Kaydı Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(544, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 302);
            this.dataGridView1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(829, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 36);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ders Bilgileri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_DersKodu);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_HarfNotu);
            this.groupBox1.Controls.Add(this.btn_NotGirisi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(565, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 164);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Not Girişi";
            // 
            // comboBox_DersKodu
            // 
            this.comboBox_DersKodu.FormattingEnabled = true;
            this.comboBox_DersKodu.Location = new System.Drawing.Point(121, 34);
            this.comboBox_DersKodu.Name = "comboBox_DersKodu";
            this.comboBox_DersKodu.Size = new System.Drawing.Size(97, 24);
            this.comboBox_DersKodu.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(31, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "DersKodu";
            // 
            // txt_HarfNotu
            // 
            this.txt_HarfNotu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_HarfNotu.FormattingEnabled = true;
            this.txt_HarfNotu.Items.AddRange(new object[] {
            "AA",
            "AB",
            "BB",
            "BC",
            "CC",
            "CD",
            "DD",
            "FF"});
            this.txt_HarfNotu.Location = new System.Drawing.Point(121, 75);
            this.txt_HarfNotu.Name = "txt_HarfNotu";
            this.txt_HarfNotu.Size = new System.Drawing.Size(97, 24);
            this.txt_HarfNotu.TabIndex = 25;
            // 
            // btn_NotGirisi
            // 
            this.btn_NotGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_NotGirisi.Location = new System.Drawing.Point(37, 115);
            this.btn_NotGirisi.Name = "btn_NotGirisi";
            this.btn_NotGirisi.Size = new System.Drawing.Size(181, 31);
            this.btn_NotGirisi.TabIndex = 19;
            this.btn_NotGirisi.Text = "Not Girişi Yap";
            this.btn_NotGirisi.UseVisualStyleBackColor = true;
            this.btn_NotGirisi.Click += new System.EventHandler(this.btn_NotGirisi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(18, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ders Kodu";
            // 
            // txt_DersKoduKayitSil
            // 
            this.txt_DersKoduKayitSil.Location = new System.Drawing.Point(113, 29);
            this.txt_DersKoduKayitSil.Name = "txt_DersKoduKayitSil";
            this.txt_DersKoduKayitSil.Size = new System.Drawing.Size(100, 22);
            this.txt_DersKoduKayitSil.TabIndex = 17;
            // 
            // txt_Gano
            // 
            this.txt_Gano.Location = new System.Drawing.Point(354, 32);
            this.txt_Gano.Name = "txt_Gano";
            this.txt_Gano.ReadOnly = true;
            this.txt_Gano.Size = new System.Drawing.Size(90, 22);
            this.txt_Gano.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(269, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "GANO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_GanoHesapla);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_Gano);
            this.groupBox3.Location = new System.Drawing.Point(12, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 183);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gano";
            // 
            // btn_GanoHesapla
            // 
            this.btn_GanoHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GanoHesapla.Location = new System.Drawing.Point(273, 74);
            this.btn_GanoHesapla.Name = "btn_GanoHesapla";
            this.btn_GanoHesapla.Size = new System.Drawing.Size(165, 35);
            this.btn_GanoHesapla.TabIndex = 23;
            this.btn_GanoHesapla.Text = "Gano Hesapla";
            this.btn_GanoHesapla.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_DersKoduKayitSil);
            this.groupBox2.Controls.Add(this.btn_Sil);
            this.groupBox2.Location = new System.Drawing.Point(857, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 126);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btn_Gano
            // 
            this.btn_Gano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Gano.Location = new System.Drawing.Point(1160, 398);
            this.btn_Gano.Name = "btn_Gano";
            this.btn_Gano.Size = new System.Drawing.Size(112, 47);
            this.btn_Gano.TabIndex = 25;
            this.btn_Gano.Text = "Gano ";
            this.btn_Gano.UseVisualStyleBackColor = true;
            this.btn_Gano.Click += new System.EventHandler(this.btn_Gano_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 576);
            this.Controls.Add(this.btn_Gano);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DersKodu;
        private System.Windows.Forms.TextBox txt_DersAdi;
        private System.Windows.Forms.TextBox txt_Kredi;
        private System.Windows.Forms.TextBox txt_AKTS;
        private System.Windows.Forms.TextBox txt_OgretimUyesiAdi;
        private System.Windows.Forms.TextBox txt_OgretimUyesiSoyadi;
        private System.Windows.Forms.TextBox txt_Donem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_NotGirisi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_DersKoduKayitSil;
        private System.Windows.Forms.Button btn_KayitlariListele;
        private System.Windows.Forms.TextBox txt_Gano;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_GanoHesapla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox txt_HarfNotu;
        private System.Windows.Forms.ComboBox comboBox_DersKodu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Gano;
    }
}

