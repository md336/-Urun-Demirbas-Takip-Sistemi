using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;
using System.Drawing;
using ZXing.QrCode;

namespace proje1
{
    internal class BarkodQRKodHelper
    {
        public Bitmap GenerateBarcode(string content)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions { Width = 300, Height = 100 }
            };
            Bitmap barcodeBitmap = writer.Write(content);
            return barcodeBitmap;
        }

        public Bitmap GenerateQRCode(string content)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions { Width = 200, Height = 200 }
            };
            Bitmap qrCodeBitmap = writer.Write(content);
            return qrCodeBitmap;
        }
    }
}
