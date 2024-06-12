using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA.Model
{
    public partial class fCheckout : SampleAdd
    {
        public fCheckout()
        {
            InitializeComponent();
        }

        public double amt;
        public int MainID = 0;

        private void txtReceived_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double receipt = 0;
            double change = 0;

            double.TryParse(txtBillAmount.Text, out amt);
            double.TryParse(txtReceived.Text, out receipt);

            change = Math.Abs(amt - receipt); 

            txtChange.Text = change.ToString();
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (Decimal.TryParse(txtReceived.Text, out decimal received) &&
                Decimal.TryParse(txtBillAmount.Text, out decimal billAmount))
            {
                if (received >= billAmount)
                {
                    string query = @"Update tblMain set total = @total, received = @rec, change = @change,
                             status = N'Đã thanh toán' where MainID = @id";

                    Hashtable ht = new Hashtable();
                    ht.Add("@id", MainID);
                    ht.Add("@total", txtBillAmount.Text);
                    ht.Add("@rec", txtReceived.Text);
                    ht.Add("@change", txtChange.Text);

                    if (MainClass.SQL(query, ht) > 0)
                    {
                        guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                        guna2MessageDialog1.Show("Thanh toán thành công");
                        this.Close();
                    }
                }
                else
                {
                    // Hiển thị thông báo khi không thỏa mãn điều kiện
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Số tiền nhận không đủ để thanh toán.");
                }
            }
            else
            {
                // Hiển thị thông báo khi giá trị không hợp lệ
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("Vui lòng nhập số tiền hợp lệ.");
            }
        }

        private void fCheckout_Load(object sender, EventArgs e)
        {
            txtBillAmount.Text = amt.ToString();
        }
    }
}
