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

namespace QLQA
{
    public partial class fHomeView : Form
    {
        public fHomeView()
        {
            InitializeComponent();
        }


        private void fHome_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-CUA-QUAN\\SQLEXPRESS;Initial Catalog=qlqa;Integrated Security=True");

            // Thống kê doanh thu đơn hàng theo tháng (chart column)
            SqlDataAdapter da1 = new SqlDataAdapter("select Month(aDate) as months ,SUM(total) as total from tblMain where status = N'Đã thanh toán' group by Month(aDate)", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            chart1.DataSource= dt1;

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tổng số tiền";
     
            chart1.Series["Tổng tiền"].XValueMember = "months";
            chart1.Series["Tổng tiền"].YValueMembers = "total";

            // Thống kê doanh thu đơn hàng theo năm (chart circle)
            SqlDataAdapter da2 = new SqlDataAdapter("select Year(aDate) as years ,SUM(total) as total from tblMain where status = N'Đã thanh toán' group by Year(aDate)", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            chart2.DataSource= dt2;
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Tổng số tiền";

            chart2.Series["Tổng tiền"].XValueMember = "years";
            chart2.Series["Tổng tiền"].YValueMembers = "total";

            con.Open();

            SqlCommand cmd1 = new SqlCommand("select Count(*) from category", con);
            var countCategory = cmd1.ExecuteScalar();
            lblCategory.Text = countCategory.ToString();

            SqlCommand cmd2 = new SqlCommand("select Count(*) from products", con);
            var countProduct = cmd2.ExecuteScalar();
            lblProduct.Text = countProduct.ToString();

            SqlCommand cmd3 = new SqlCommand("select Count(*) from tables", con);
            var countTable = cmd3.ExecuteScalar();
            lblTable.Text = countTable.ToString();

            SqlCommand cmd4 = new SqlCommand("select Count(*) from staff", con);
            var countStaff = cmd4.ExecuteScalar();
            lblStaff.Text = countStaff.ToString();

            con.Close();
        }
    }
}
