using System;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Transkript_Uygulaması
{
    public partial class Form1 : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=dbTranskriptUygulamasi; user ID=postgres; password=1234");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM ders ORDER BY ders_kodu", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox_DersKodu.ValueMember = "ders_kodu";
            comboBox_DersKodu.DisplayMember = "ders_kodu";
            comboBox_DersKodu.DataSource = dt;
            connection.Close();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            connection.Open();

            NpgsqlCommand query2 = new NpgsqlCommand("INSERT INTO ders (ders_kodu,ders_adi,kredi,akts,ogretim_uyesi_adi,ogretim_uyesi_soyadi,donem) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connection);

            query2.Parameters.AddWithValue("@p1", txt_DersKodu.Text);
            query2.Parameters.AddWithValue("@p2", txt_DersAdi.Text);
            query2.Parameters.AddWithValue("@p3", int.Parse(txt_Kredi.Text));
            query2.Parameters.AddWithValue("@p4", int.Parse(txt_AKTS.Text));
            query2.Parameters.AddWithValue("@p5", txt_OgretimUyesiAdi.Text);
            query2.Parameters.AddWithValue("@p6", txt_OgretimUyesiSoyadi.Text);
            query2.Parameters.AddWithValue("@p7", int.Parse(txt_Donem.Text));

            query2.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Kayıt Başarıyla Sisteme Eklendi.");
        }

        private void btn_KayitlariListele_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlDataAdapter query1 = new NpgsqlDataAdapter("SELECT * FROM ders ORDER BY ders_kodu", connection);
            DataSet dataSet = new DataSet();
            query1.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            txt_DersAdi.Clear();
            txt_DersKodu.Clear();
            txt_Donem.Clear();
            txt_Kredi.Clear();
            txt_OgretimUyesiAdi.Clear();
            txt_OgretimUyesiSoyadi.Clear();
            txt_AKTS.Clear();

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            connection.Open();

            NpgsqlCommand query3 = new NpgsqlCommand("DELETE FROM ders Where ders_kodu=@p1", connection);

            query3.Parameters.AddWithValue("@p1", txt_DersKoduKayitSil.Text);

            DialogResult dialogResult = MessageBox.Show("Kayıt Silinecektir. Devam etmek istiyor musunuz?", "DİKKAT!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                query3.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarıyla Silindi.");
            }
            connection.Close();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            connection.Open();

            NpgsqlCommand query4 = new NpgsqlCommand("UPDATE ders SET ders_adi=@p2,kredi=@p3,akts=@p4,ogretim_uyesi_adi=@p5,ogretim_uyesi_soyadi=@p6,donem=@p7 WHERE ders_kodu=@p1", connection);

            query4.Parameters.AddWithValue("@p1", txt_DersKodu.Text);
            query4.Parameters.AddWithValue("@p2", txt_DersAdi.Text);
            query4.Parameters.AddWithValue("@p3", int.Parse(txt_Kredi.Text));
            query4.Parameters.AddWithValue("@p4", int.Parse(txt_AKTS.Text));
            query4.Parameters.AddWithValue("@p5", txt_OgretimUyesiAdi.Text);
            query4.Parameters.AddWithValue("@p6", txt_OgretimUyesiSoyadi.Text);
            query4.Parameters.AddWithValue("@p7", int.Parse(txt_Donem.Text));

            query4.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Kayıt Başarıyla Güncellendi.");

        }

        private void btn_NotGirisi_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand query5 = new NpgsqlCommand("UPDATE ders SET harf_notu=@p1 WHERE ders_kodu=@p2", connection);
            query5.Parameters.AddWithValue("@p1", txt_HarfNotu.Text);
            query5.Parameters.AddWithValue("@p2", comboBox_DersKodu.SelectedValue);
            query5.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Notunuz Başarıyla Kaydedilmiştir.");


        }
        public float HarfNotu2Kredi(string harfNotu) 
            {
                if (harfNotu == "AA")
                    {
                         float alinanKredi = 4.0f;
                         return alinanKredi;
                    }
                if (harfNotu == "BA")
                    {
                        float alinanKredi = 4.0f;
                        return alinanKredi;
                    }
                if (harfNotu == "BB")
                    {
                        float alinanKredi = 4.0f;
                        return alinanKredi;
                    }
                if (harfNotu == "BC")
                    {
                        float alinanKredi = 4.0f;
                        return alinanKredi;
                    }
                if (harfNotu == "CC")
                    {
                        float alinanKredi = 4.0f;
                        return alinanKredi;
                    }
                if (harfNotu == "DC")
                    {
                        float alinanKredi = 4.0f;
                        return alinanKredi;
                    }
                if (harfNotu == "DD")
                    {
                        float alinanKredi = 4.0f;
                        return alinanKredi;
                    }
                if (harfNotu == "DF")
                    {
                        float alinanKredi = 4.0f;
                        return alinanKredi;
                    }
                if (harfNotu == "FF")
                    {
                        float alinanKredi = 4.0f;
                        return alinanKredi;
                    }
                return 0;
            }
        private void btn_GanoHesapla_Click(object sender, EventArgs e)
        {

        }

        private void btn_Gano_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

    


