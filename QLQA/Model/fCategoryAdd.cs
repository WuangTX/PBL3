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
    public partial class fCategoryAdd : SampleAdd
    {
        public fCategoryAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

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
                    query = "Insert into category Values(@Name)";
                }
                else
                {
                    query = "Update category Set catName = @Name where catID = @id";

                }
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if( MainClass.SQL(query, ht)>0) 
            {
                guna2MessageDialog1.Show("Lưu thành công");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }

    }
}
