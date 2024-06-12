using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA.Model
{
    public partial class fProductAdd : SampleAdd
    {
        public fProductAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int cID = 0;

        private void fProductAdd_Load(object sender, EventArgs e)
        {
            // For cb Fill
            string query = "Select catID 'id', catName 'name' from category";

            MainClass.CBFill(query, cbCat);

            if(cID > 0) // Cập nhật
            {
                cbCat.SelectedValue= cID;
            }

            if(id > 0)
            {
                ForUpdateLoadData();
            }
        }

        string filePath;
        Byte[] imageByteArray;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|* .png; *.jpg";
            if(ofd.ShowDialog() == DialogResult.OK ) 
            {
                filePath = ofd.FileName;
                txtImage.Image = new Bitmap(filePath);
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string query = "";

            if (txtName.Text.Equals(""))
            {
                guna2MessageDialog1.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            else if (id == 0) // Insert
            {
                query = "Insert into products Values(@Name, @price, @cat, @img)";
            }
            else
            {
                query = "Update products Set pName = @Name, pPrice = @Price, CategoryID = @cat, pImage = @img where pID = @id";

            }

            // images
            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@price", txtPrice.Text);
            ht.Add("@cat", Convert.ToInt32(cbCat.SelectedValue));
            ht.Add("@img", imageByteArray);

            if (MainClass.SQL(query, ht) > 0)
            {
                guna2MessageDialog1.Show("Lưu thành công");
                id = 0;
                cID = 0;
                txtName.Text = "";
                txtPrice.Text = "";
                cbCat.SelectedIndex = 0;
                cbCat.SelectedIndex = -1;
                txtImage.Image = QLQA.Properties.Resources.producPic;

                txtName.Focus();
            }
        }

        private void ForUpdateLoadData()
        {
            string query = @"Select * from products where pid = '" + id + "'";
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["pName"].ToString();
                txtPrice.Text = dt.Rows[0]["pPrice"].ToString();

                Byte[] imageArray = (byte[])(dt.Rows[0]["pImage"]);
                byte[] imageByteArray = imageArray;
                txtImage.Image = Image.FromStream(new MemoryStream(imageArray));

            }

        }

    }
}
