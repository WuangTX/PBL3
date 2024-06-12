using QLQA.Model;
using System;
using System.Collections;
using System.Windows.Forms;

namespace QLQA.View
{
    public partial class fAccountView : SampleView
    {
        public fAccountView()
        {
            InitializeComponent();
        }

        private void fAccountView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string query = "Select * from users where uName like '%" + txtSearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvUsername);
            lb.Items.Add(dgvPass);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPhone);

            MainClass.LoadData(query, guna2DataGridView1, lb);
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
           
            MainClass.BlurBackground(new fAccountAdd());
            GetData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }


        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Edit 
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                fAccountAdd f = new fAccountAdd();
                f.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                f.txtUsername.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvUsername"].Value);
                f.txtPass.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPass"].Value);
                f.txtPass.PasswordChar = '•'; // Thiết lập ký tự đặc biệt để ẩn mật khẩu
                f.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                f.txtPhone.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPhone"].Value);

                MainClass.BlurBackground(f);
                GetData();
            }

            // Delete
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                // Xác nhận trước khi xóa
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (guna2MessageDialog1.Show("Bạn có muốn xóa không?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string query = "Delete from users where userID = '" + id + "'";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(query, ht);

                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Xóa thành công");
                    GetData();
                }



            }
        }
    }
}
