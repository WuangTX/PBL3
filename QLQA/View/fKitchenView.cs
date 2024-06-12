using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA.View
{
    public partial class fKitchenView : Form
    {
        public fKitchenView()
        {
            InitializeComponent();
        }

        public string OrderType = "";

        private void fKitchenView_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            string query1 = @"Select * from tblMain where status = N'Chờ'";
            SqlCommand cmd1 = new SqlCommand(query1, MainClass.con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt1);



            FlowLayoutPanel p1;

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 230;
                p1.Height = 350;
                p1.FlowDirection= FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10,10,10,10);

                FlowLayoutPanel p2 = new FlowLayoutPanel();
                p2 = new FlowLayoutPanel();
                p2.BackColor = Color.FromArgb(127, 148, 237);
                p2.AutoSize = true;
                p2.Width = 230;
                p2.Height = 125;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.Margin = new Padding(0,0,0,0);

                Label lb1 = new Label();
                lb1.ForeColor = Color.White;
                lb1.Margin = new Padding(10, 10, 3, 0);
                lb1.AutoSize = true;
                lb1.Font = new Font("Times New Roman", 12);

                Label lb2 = new Label();
                lb2.ForeColor = Color.White;
                lb2.Margin = new Padding(10, 5, 3, 10);
                lb2.AutoSize = true;
                lb2.Font = new Font("Times New Roman", 12);

                Label lb3 = new Label();
                lb3.ForeColor = Color.White;
                lb3.Margin = new Padding(10, 5, 3, 0);
                lb3.AutoSize = true;
                lb3.Font = new Font("Times New Roman", 12);

                Label lb4 = new Label();
                lb4.ForeColor = Color.White;
                lb4.Margin = new Padding(10, 5, 12,10);
                lb4.AutoSize = true;
                lb4.Font = new Font("Times New Roman", 12); 

                if(dt1.Rows[i]["TableName"].ToString() != "" && dt1.Rows[i]["WaiterName"].ToString() != "")
                {
                    lb1.Text = "Bàn : " + dt1.Rows[i]["TableName"].ToString();
                    lb2.Text = "Tên phục vụ : " + dt1.Rows[i]["WaiterName"].ToString();
                    lb3.Text = "Thời gian đặt hàng : " + dt1.Rows[i]["aTime"].ToString();
                    lb4.Text = "Kiểu đặt hàng : " + dt1.Rows[i]["orderType"].ToString();
                }
                else 
                {
                    lb1.Text = "Tên khách hàng : " + dt1.Rows[i]["custName"].ToString();
                    lb2.Text = "Số khách hàng : " + dt1.Rows[i]["custPhone"].ToString();
                    lb3.Text = "Thời gian đặt hàng : " + dt1.Rows[i]["aTime"].ToString();
                    lb4.Text = "Kiểu đặt hàng : " + dt1.Rows[i]["orderType"].ToString();
                }
                
     

                p2.Controls.Add(lb1);
                p2.Controls.Add(lb2);
                p2.Controls.Add(lb3);
                p2.Controls.Add(lb4);

                p1.Controls.Add(p2);

                // Thêm sản phẩm
                int mid = 0;
                mid = Convert.ToInt32(dt1.Rows[i]["MainID"].ToString());

                string query2 = @"Select * from tblMain m
                                    inner join tblDetails d on m.MainID = d.MainID
                                    inner join products p on p.pID = d.proID
                                        where m.MainID = "+mid+"";

                SqlCommand cmd2 = new SqlCommand(query2, MainClass.con);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);

                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    Label lb5 = new Label();
                    lb5.ForeColor = Color.Black;
                    lb5.Margin = new Padding(10, 5, 3, 0);
                    lb5.AutoSize = true;

                    int no = j + 1;
                    
                    lb5.Text = "#" + no + "  -  " + dt2.Rows[j]["pName"].ToString() + "  -  " + dt2.Rows[j]["qty"].ToString();

                    p1.Controls.Add(lb5);
                }
                

                // Thêm button để thay đổi trạng thái đặt hàng
                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                b.AutoRoundedCorners = true;
                b.Size = new Size(100, 35);
                b.FillColor = Color.SeaGreen;
                b.Margin = new Padding(45, 10, 3, 10);
                b.Text = "Hoàn thành";
                b.Tag = dt1.Rows[i]["MainID"].ToString(); // Lưu trữ id

                b.Click += new EventHandler(b_click);
                p1.Controls.Add(b);

                flowLayoutPanel1.Controls.Add(p1);
            }



        }

        private void b_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Guna.UI2.WinForms.Guna2Button).Tag.ToString());

            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            if (guna2MessageDialog1.Show("Bạn có chắc chắn đã hoàn thành đơn này không?") == DialogResult.Yes)
            {
                string query = @"Update tblMain set status = 'Hoàn thành' where MainID = @ID";
                Hashtable ht = new Hashtable();
                ht.Add("@ID", id);

                if(MainClass.SQL(query, ht) > 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Lưu thành công");
                }
                GetOrders();
            }
        }
    }
}
