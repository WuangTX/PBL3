using QLQA.Model;
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

namespace QLQA.View
{
    public partial class fTableView : SampleView
    {
        public fTableView()
        {
            InitializeComponent();
        }

        private void fTableView_Load(object sender, EventArgs e)
        {
            // Tạo bảng đầu tiên
            GetData();
        }

        public void GetData()
        {
            string query = "Select * from tables where tName like '%" + txtSearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(query, guna2DataGridView1, lb);
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            // Thêm hiệu ứng xanh
            //fTableAdd f = new fTableAdd();
            //f.ShowDialog();

            MainClass.BlurBackground(new fTableAdd());

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

                fTableAdd f = new fTableAdd();
                f.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                f.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                MainClass.BlurBackground(f);
                GetData();

            }
            // Delete
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                // Xác nhận trước khi xóa
                if (guna2MessageDialog1.Show("Bạn có muốn xóa không?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string query = "Delete from tables where tID = '" + id + "'";
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
