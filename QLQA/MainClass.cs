using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA
{
    class MainClass
    {
       
        public static readonly string con_string = "Data Source=LAPTOP-CUA-QUAN\\SQLEXPRESS;Initial Catalog=qlqa;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        //mã hóa
        public static string EncryptPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //Chuyển đổi chuỗi mật khẩu đầu vào thành một mảng byte sử dụng mã hóa UTF-8, Tính toán giá trị băm SHA-256 của mảng byte, kết quả là một mảng byte mới đại diện cho giá trị băm.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Chuyển đổi mảng byte chứa giá trị băm SHA-256 thành một chuỗi mã hóa base64
                string hashedPassword = Convert.ToBase64String(bytes);

                return hashedPassword;
            }
        }
        

        // Phương thức kiểm tra user
        public static bool IsValidUser(string user, string pass)
        {
            string hashpass = EncryptPassword(pass);

            bool isValid = false;
            string query = @"Select * from users where username = '" + user + "' and upass='"+hashpass+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if(dt.Rows.Count > 0 )
            {
                isValid= true;
                USER = dt.Rows[0]["uName"].ToString();
            }

            return isValid;

        }

        // Tạo thuộc tính username
        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }


        // CRUD danh mục
        public static int SQL(string query, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;

                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if(con.State == ConnectionState.Closed) { con.Open(); };
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); };
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

            return res;
        }

        // Load dữ liệu từ database
        public static void LoadData(string query, DataGridView gv, ListBox lb)
        {
            // Số Sr# trong danh mục gridview 
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++) 
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

        }

        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;

            foreach( DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }

        }
        //làm mờ form cũ khi form mới xuất hiện 
        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition= FormStartPosition.Manual;
                Background.FormBorderStyle= FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = fMain.Instance.Size;
                Background.Location = fMain.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner= Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }

        // điền dữ liệu vào combobox
        public static void CBFill(string query, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember= "id";
            cb.DataSource= dt;
            cb.SelectedIndex= -1;


        }

    }
}
