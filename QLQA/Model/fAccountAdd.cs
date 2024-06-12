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
    public partial class fAccountAdd : SampleAdd
    {
        public fAccountAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void fAccountAdd_Load(object sender, EventArgs e)
        {

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string query = "";


            if (txtName.Text.Equals(""))
            {
                guna2MessageDialog1.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            else
            {
                if (id == 0) // Insert
                {
                    query = "Insert into users Values(@Username, @Pass, @Name, @Phone)";
                }
                else
                {
                    query = "Update users Set username = @Username, upass=@Pass, uName=@Name, uPhone=@Phone where userID = @id";

                }
            }

            Hashtable ht = new Hashtable();
            string hashpass = MainClass.EncryptPassword(txtPass.Text);
            ht.Add("@id", id);
            ht.Add("@Username", txtUsername.Text);
            ht.Add("@Pass", hashpass);
            ht.Add("@Name", txtName.Text);
            ht.Add("@Phone", txtPhone.Text);

            if (MainClass.SQL(query, ht) > 0)
            {
                guna2MessageDialog1.Show("Lưu thành công");
               
         
                id = 0;
                txtUsername.Text = "";
                txtPass.Text = "";
                txtName.Text = "";
                txtPhone.Text = "";

                txtName.Focus();
            }
        }
    }
}
