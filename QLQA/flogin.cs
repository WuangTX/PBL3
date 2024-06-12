using System;
using System.Windows.Forms;

namespace QLQA
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            // Tạo database và bảng users
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                guna2MessageDialog1.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else if (MainClass.IsValidUser(txtUser.Text, txtPass.Text) == false )
            {
                guna2MessageDialog1.Show("Sai tài khoản hoặc mật khẩu");
                return;
            }
            else
            {
                this.Hide();
                fMain frm = new fMain();
                frm.Show();
            }

            // Thêm 1 user


        }
        

        private void guna2PictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void guna2PictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }


    }
}
