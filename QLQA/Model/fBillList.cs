using QLQA.Reports;
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

namespace QLQA.Model
{
    public partial class fBillList : SampleAdd
    {
        public fBillList()
        {
            InitializeComponent();
        }

        public int MainID = 0;

        private void fBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = @"select MainID, TableName, WaiterName, orderType, status, total from 
                            tblMain where status <> 'Chờ' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);


            MainClass.LoadData(query, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // for searil no
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Edit 
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                string status = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvStatus"].Value);

                if (status == "Hoàn thành" || status == "Lưu")
                {
                    MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    this.Close();
                }
                else if (status == "Đã thanh toán")
                {
                    guna2MessageDialog1.Show("Đơn hàng đã thanh toán");
                }
                else
                {
                    guna2MessageDialog1.Show("Đơn hàng chưa hoàn thành không thể xem");
                }

            }

            // Print
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvPrint")
            {
                string status = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvStatus"].Value);

                if (status == "Đã thanh toán")
                {
                    int mainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string connectionString = "Data Source=LAPTOP-CUA-QUAN\\SQLEXPRESS;Initial Catalog=qlqa;Integrated Security=True";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = @"SELECT 
                                tm.MainID,
                                tm.aDate,
                                tm.aTime,
                                tm.orderType,
                                tm.received,
                                tm.change,
                                p.pName,
                                td.qty,
                                td.price,
                                td.amount
                             FROM 
                                tblMain tm
                             JOIN 
                                tblDetails td ON tm.MainID = td.MainID
                             JOIN 
                                products p ON td.proID = p.pID
                             WHERE 
                                tm.MainID = @MainID";

                        SqlCommand command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@MainID", mainID);

                        SqlDataAdapter sd = new SqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        sd.Fill(ds, "BillData");

                        if (ds.Tables.Count > 0 && ds.Tables["BillData"].Rows.Count > 0)
                        {
                            rptListBill report = new rptListBill();
                            report.SetDataSource(ds.Tables["BillData"]);

                            // Thiết lập giá trị tham số cho báo cáo
                            report.SetParameterValue("@MainID", mainID);

                            fPrintBill printForm = new fPrintBill();
                            printForm.crystalReportViewerPrintBill.ReportSource = report;
                            printForm.crystalReportViewerPrintBill.Refresh();
                            printForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu để hiển thị.");
                        }
                    }
                }
                else
                {
                    guna2MessageDialog1.Show("Bạn chưa thanh toán");
                }
            }


        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
