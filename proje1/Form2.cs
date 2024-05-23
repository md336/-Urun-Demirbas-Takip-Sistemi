using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace proje1
{
    public partial class Form2 : Form
    {

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=DESKTOP-GR67PAK;Initial Catalog=ornek;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * From Kullanici_Bilgi where kullanici_adi='" + textBox1.Text +
                "' And sifre='" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler Giriş Başarılı");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            con.Close();
        }
    }
}

