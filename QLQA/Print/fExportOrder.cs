using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QLQA
{
    public partial class fExportOrder : Form
    {
        public fExportOrder()
        {
            InitializeComponent();
        }

        private void fExportOrder_Load(object sender, EventArgs e)
        {
        
            // TODO: This line of code loads data into the 'qLQADataSet.tblMain' table. You can move, or remove it, as needed.
            this.tblMainTableAdapter.Fill(this.qLQADataSet.tblMain);

        }

        private void export2Excel(DataGridView g, string filePath)
        {
            // Tạo đối tượng ứng dụng Excel
            app obj = new app();

            // Kiểm tra xem file đã tồn tại chưa
            if (System.IO.File.Exists(filePath))
            {
                // Mở file Excel nếu đã tồn tại
                obj.Workbooks.Open(filePath);
            }
            else
            {
                // Tạo workbook mới nếu file chưa tồn tại
                obj.Workbooks.Add(Type.Missing);
            }

            // Thiết lập chiều rộng cột
            obj.Columns.ColumnWidth = 25;

            // Ghi tiêu đề của các cột vào hàng đầu tiên của Excel
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }

            // Ghi dữ liệu từ DataGridView vào Excel
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            // Lưu workbook hiện tại với đường dẫn và tên tệp được chỉ định
            obj.ActiveWorkbook.SaveCopyAs(filePath);
            obj.ActiveWorkbook.Saved = true;
        }



        private void btnExport_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại lưu tệp mới
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Thiết lập bộ lọc để chỉ hiển thị tệp Excel
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                // Thiết lập tiêu đề cho hộp thoại
                saveFileDialog.Title = "Save an Excel File";
                // Thiết lập tên tệp mặc định
                saveFileDialog.FileName = "xuatfileExcel.xlsx";

                // Kiểm tra xem người dùng đã nhấn nút "Save" trong hộp thoại chưa
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Gọi hàm export2Excel với đường dẫn tệp mà người dùng đã chọn
                        export2Excel(OrderDatagridview, saveFileDialog.FileName);
                        // Hiển thị thông báo thành công
                        guna2MessageDialog1.Show("Xuất excel thành công");
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo lỗi nếu có vấn đề xảy ra
                        guna2MessageDialog1.Show("Lỗi không thể lưu file: " + ex.Message);
                    }
                }
            }
        }



        private void daThanhToanToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblMainTableAdapter.DaThanhToan(this.qLQADataSet.tblMain);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
