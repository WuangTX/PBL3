using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA.Model
{
    public partial class fTableSelect : Form
    {
        public fTableSelect()
        {
            InitializeComponent();
        }

        public string TableName;

        private void fTableSelect_Load(object sender, EventArgs e)
        {
            string query = "Select * from tables";

            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow row in dt.Rows)
            {
                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                b.Text = row["tname"].ToString();
                b.Width = 150;
                b.Height = 50;
                b.Cursor = Cursors.Hand;
                b.FillColor = Color.SeaGreen;
                b.HoverState.FillColor = Color.FromArgb(50, 55, 89);

                // Sự kiện click
                b.Click += new EventHandler(b_Click);
                flowLayoutPanel1.Controls.Add(b);

            }
        }

        private void b_Click(object sender, EventArgs e)
        {
           TableName = (sender as Guna.UI2.WinForms.Guna2Button).Text.ToString();
            this.Close();
        }
    }
}
