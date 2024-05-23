using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace proje1
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("server=.;initial catalog=demirbasKayitDb; integrated security=sspi");
        SqlCommand cmd;
        SqlDataAdapter da;

        public void listele()
        {
            da = new SqlDataAdapter("select * from demirbaslar", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }



        public void temizle()
        {
            txtürünkodu.Text = "";
            txturunadi.Text = "";
            txtalankisi.Text = "";
            txtalistarih.Text = "";
            txtgaranti.Text = "";
            txtmiktar.Text = "";
            txtfiyat.Text = "";
            pictureBox1.ImageLocation = "";


        }




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtürünkodu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txturunadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtalankisi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtalistarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtgaranti.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtmiktar.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtfiyat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            DateTime alisTarih;
            if (!DateTime.TryParseExact(txtalistarih.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out alisTarih))
            {
                MessageBox.Show("Geçersiz tarih formatı! Tarih formatı 'gg.aa.yyyy' şeklinde olmalıdır.");
                return;
            }


            int urunKodu, garantiSuresi, miktar, fiyat;
            if (!int.TryParse(txtürünkodu.Text, out urunKodu) ||
                !int.TryParse(txtgaranti.Text, out garantiSuresi) ||
                !int.TryParse(txtmiktar.Text, out miktar) ||
                !int.TryParse(txtfiyat.Text, out fiyat))
            {
                MessageBox.Show("Geçersiz sayısal bir değer girdiniz!");
                return;
            }

            cmd = new SqlCommand("insert into demirbaslar(urunKodu,urunAdi,alanKisi,alisTarih,garantiSuresi,miktar,fiyat,resim) values(@urunKodu,@urunAdi,@alanKisi,@alisTarih,@garantiSuresi,@miktar,@fiyat,@resim)", con);
            cmd.Parameters.AddWithValue("@urunKodu", urunKodu);
            cmd.Parameters.AddWithValue("@urunAdi", txturunadi.Text);
            cmd.Parameters.AddWithValue("@alanKisi", txtalankisi.Text);
            cmd.Parameters.AddWithValue("@alisTarih", alisTarih);
            cmd.Parameters.AddWithValue("@garantiSuresi", garantiSuresi);
            cmd.Parameters.AddWithValue("@miktar", miktar);
            cmd.Parameters.AddWithValue("@fiyat", fiyat);
            cmd.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Kayıt tamamlandı");


            listele();

        }

        private void btnresim_Click(object sender, EventArgs e)
        {

            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "resim dosyalari | *jpg;*.png";
            dosya.ShowDialog();
            pictureBox1.ImageLocation = dosya.FileName;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            DateTime alisTarih;
            string dateFormat = "dd.MM.yyyy";
            if (!DateTime.TryParseExact(txtalistarih.Text, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out alisTarih))
            {
                MessageBox.Show($"Geçersiz tarih formatı! Tarih formatı '{dateFormat}' şeklinde olmalıdır.");
                return;
            }

            int urunKodu, garantiSuresi, miktar, fiyat;
            if (!int.TryParse(txtürünkodu.Text, out urunKodu) ||
                !int.TryParse(txtgaranti.Text, out garantiSuresi) ||
                !int.TryParse(txtmiktar.Text, out miktar) ||
                !int.TryParse(txtfiyat.Text, out fiyat))
            {
                MessageBox.Show("Geçersiz sayısal bir değer girdiniz!");
                return;
            }

            // Resmi yükleyin
            string resimDosyaYolu = pictureBox1.ImageLocation;

            SqlCommand updateCmd = new SqlCommand("UPDATE demirbaslar SET urunAdi = @urunAdi, alanKisi = @alanKisi, alisTarih = @alisTarih, garantiSuresi = @garantiSuresi, miktar = @miktar, fiyat = @fiyat, resim = @resim WHERE urunKodu = @urunKodu", con);
            updateCmd.Parameters.AddWithValue("@urunKodu", urunKodu);
            updateCmd.Parameters.AddWithValue("@urunAdi", txturunadi.Text);
            updateCmd.Parameters.AddWithValue("@alanKisi", txtalankisi.Text);
            updateCmd.Parameters.AddWithValue("@alisTarih", alisTarih.ToString("yyyy-MM-dd")); // SQL için tarih formatı
            updateCmd.Parameters.AddWithValue("@garantiSuresi", garantiSuresi);
            updateCmd.Parameters.AddWithValue("@miktar", miktar);
            updateCmd.Parameters.AddWithValue("@fiyat", fiyat);
            updateCmd.Parameters.AddWithValue("@resim", resimDosyaYolu); // Resim dosya yolunu parametre olarak ekleyin

            try
            {
                con.Open();
                updateCmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kayıt güncellendi");
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            int urunKodu;
            if (!int.TryParse(txtürünkodu.Text, out urunKodu))
            {
                MessageBox.Show("Geçersiz ürün kodu! Lütfen geçerli bir ürün kodu girin.");
                return;
            }

            try
            {

                SqlCommand deleteCmd = new SqlCommand("DELETE FROM demirbaslar WHERE urunKodu = @urunKodu", con);
                deleteCmd.Parameters.AddWithValue("@urunKodu", urunKodu);


                con.Open();
                int rowsAffected = deleteCmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Ürün başarıyla silindi");
                    listele();
                }
                else
                {
                    MessageBox.Show("Belirtilen ürün kodu bulunamadı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message);

            }



        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void txtürünara_TextChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from demirbaslar where urunKodu like '"+txtürünara.Text+"%'  ", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void ürünlerigoster_Click(object sender, EventArgs e)
        {
            // frmurunler formunu kullanabilmek için bir örnek oluşturun
            frmurunler frmurunler = new frmurunler();

            // Mevcut formu gizleyin
            this.Hide();

            // frmurunler formunu gösterin
            frmurunler.Show();
        }
    }
    }

