using QLQA.Reports;
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
    public partial class fPrintProduct : Form
    {
        public fPrintProduct()
        {
            InitializeComponent();
        }

        private void btnPrintProduct_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-CUA-QUAN\\SQLEXPRESS;Initial Catalog=qlqa;Integrated Security=True");
            SqlCommand command = new SqlCommand("select * from products", con);

            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataSet s = new DataSet();
            sd.Fill(s);

            // Kiểm tra xem DataSet có chứa bảng hay không
            if (s.Tables.Count > 0)
            {
                rptListProducts sr = new rptListProducts();
                
                sr.SetDataSource(s.Tables[0]); // Truy cập bảng đầu tiên trong DataSet
                crystalReportViewer1.ReportSource = sr;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }
        }

    }
}
