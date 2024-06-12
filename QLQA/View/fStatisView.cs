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
    public partial class fStatisView : Form
    {
        public fStatisView()
        {
            InitializeComponent();
        }

        private void fPrint_Load(object sender, EventArgs e)
        {
          
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DateTime fromDate = DateTime.Parse(dtFromDate.Text);
            DateTime toDate = DateTime.Parse(dtToDate.Text);

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-CUA-QUAN\\SQLEXPRESS;Initial Catalog=qlqa;Integrated Security=True");
            SqlCommand command = new SqlCommand("select * from tblMain where status = N'Đã thanh toán' " +
               "and aDate >= '" + fromDate + "' and aDate <= '" + toDate + "'", con);

            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataSet s = new DataSet();
            sd.Fill(s);

            rptListOrder sr = new rptListOrder();
            sr.SetDataSource(s.Tables["table"]);
            crystalReportViewer1.ReportSource = sr;
        }

        private void btnDisplayProduct_Click(object sender, EventArgs e)
        {
            fPrintProduct f = new fPrintProduct();
            f.ShowDialog();
        }


        private void btnDisplayStaff_Click(object sender, EventArgs e)
        {
            fPrintStaff f = new fPrintStaff();
            f.ShowDialog();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            fExportOrder f = new fExportOrder();
            f.ShowDialog();
        }
    }
}
