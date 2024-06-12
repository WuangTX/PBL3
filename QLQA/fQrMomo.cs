using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using ZXing;
using System.Collections;

namespace QLQA
{
    public partial class fQrMomo : Form
    {

        public double amt;
        public int MainID = 0;


        public fQrMomo()
        {
            InitializeComponent();

            double amt = 0;
            double.TryParse(txt_sotien.Text, out amt);
        }

        private void fQrMomo_Load(object sender, EventArgs e)
        {
            txt_sotien.Text = amt.ToString();
        }

        //tạo qr momo
        private void btn_pay_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu số tiền (amt) lớn hơn 0
            if (amt > 0)
            {
                // Tạo chuỗi văn bản cho mã QR từ các thông tin đầu vào
                var qrcode_text = $"2|99|{txt_phone.Text.Trim()}|{txt_name.Text.Trim()}|{txt_email.Text.Trim()}|0|0|{txt_sotien.Text.Trim()}";

                // Khởi tạo đối tượng BarcodeWriter để tạo mã QR
                BarcodeWriter barcodeWriter = new BarcodeWriter();

                // Thiết lập các tùy chọn mã hóa cho mã QR
                EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

                // Thiết lập Renderer và các tùy chọn cho BarcodeWriter
                barcodeWriter.Renderer = new BitmapRenderer();
                barcodeWriter.Options = encodingOptions;
                barcodeWriter.Format = BarcodeFormat.QR_CODE;

                // Tạo bitmap từ chuỗi mã QR
                Bitmap bitmap = barcodeWriter.Write(qrcode_text);

                // Gọi hàm resizeImage để thay đổi kích thước logo
                Bitmap logo = resizeImage(Properties.Resources.logo_momo, 64, 64) as Bitmap;

                // Vẽ logo lên mã QR tại vị trí trung tâm
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));

                // Hiển thị mã QR lên PictureBox
                pic_qrcode.Image = bitmap;
            }
            else
            {
                // Hiển thị thông báo nếu số tiền bằng 0
                guna2MessageDialog1.Show("Vui lòng chọn đơn hàng cần thanh toán");
            }
        }

        // Phương thức thay đổi kích thước hình ảnh
        public Image resizeImage(Image image, int new_height, int new_width)
        {
            // Tạo Bitmap mới với kích thước mới
            Bitmap new_image = new Bitmap(new_width, new_height);

            // Tạo đối tượng Graphics từ Bitmap mới
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;

            // Vẽ lại hình ảnh với kích thước mới
            g.DrawImage(image, 0, 0, new_width, new_height);

            // Trả về hình ảnh mới đã được thay đổi kích thước
            return new_image;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string query = @"Update tblMain set total = @total,
                             status = N'Đã thanh toán' where MainID = @id";

            Hashtable ht = new Hashtable();
            ht.Add("@id", MainID);
            ht.Add("@total", txt_sotien.Text);
 

            if (MainClass.SQL(query, ht) > 0)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("Thanh toán thành công");
                this.Close();
            }
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
