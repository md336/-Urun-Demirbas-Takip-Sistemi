using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace proje1
{
    public partial class frmurunler : Form
    {
        public frmurunler()
        {
            InitializeComponent();
        }

        private void frmurunler_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBarkodOlustur_Click(object sender, EventArgs e)
        {
            string urunKodu = txtUrunKodu.Text; // Barkod içeriği olarak kullanılacak ürün kodu alınır

            // Barkod oluşturucu yardımcı sınıfından örnek oluşturulur
            BarkodQRKodHelper helper = new BarkodQRKodHelper();

            // Barkod oluşturulur ve PictureBox'a yüklenir
            Bitmap barkodImage = helper.GenerateBarcode(urunKodu);
            pictureBox1.Image = barkodImage;
        }

        private void btnQROlustur_Click(object sender, EventArgs e)
        {
            string urunKodu = txtUrunKodu.Text; // QR kod içeriği olarak kullanılacak ürün kodu alınır

            // QR kod oluşturucu yardımcı sınıfından örnek oluşturulur
            BarkodQRKodHelper helper = new BarkodQRKodHelper();

            // QR kod oluşturulur ve PictureBox'a yüklenir
            Bitmap qrCodeImage = helper.GenerateQRCode(urunKodu);
            pictureBox1.Image = qrCodeImage;
        }
    }
    }

