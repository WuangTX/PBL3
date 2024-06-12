using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace QLQA.Model
{
    public partial class fManage : Form
    {
        public fManage()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        public string OrderType = "";
        public int driverID = 0;
        public string customerName = "";
        public string customerPhone = "";
        public string status = "";


        // Để truy cập form Main
        static fMain _obj;
        public static fMain Instance
        {
            get { if (_obj == null) { _obj = new fMain(); } return _obj; }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fManage_Load(object sender, EventArgs e)
        {
            lblUserPos.Text = MainClass.USER;

            guna2DataGridView1.BorderStyle = BorderStyle.Fixed3D;
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProducts();

        }

        private void AddCategory() 
        {
            string query = "Select * from Category";
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);    
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();

            if(dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(127, 148, 237);
                    b.Size = new Size(120, 50);
                     b.BorderRadius = 6;
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["catName"].ToString();

                    // Sự kiện click
                    b.Click += new EventHandler(b_Click);

                    CategoryPanel.Controls.Add(b);
                }

            }

        }

        private void b_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            if(b.Text == "All Categories")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
                return;
            }

            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id, String proID, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID),
            };
            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach(DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    // Kiểm tra xem sản phẩm đã có chưa, sau đó kiểm tra số lượng và cập nhật giá
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvPrice"].Value.ToString());

                        GetTotal();
                        return;
                    }

                }
                // Dòng để thêm sản phẩm
                guna2DataGridView1.Rows.Add(new object[] {0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };
        }

        // Lấy sản phẩm từ database
         private void LoadProducts()
         {
            string query = "Select * from products inner join category on catID = CategoryID";
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pImage"];
                byte[] imagebytearray = imagearray;

                AddItems("0" ,item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(),
                        item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }
         }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach ( var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
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

        private void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";

            foreach(DataGridViewRow item in guna2DataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }

            lblTotal.Text = tot.ToString("N2");

        }


        //private string GetTotal()
        //{
        //    double grandTotal = 0; 
        //    foreach (DataGridViewRow row in guna2DataGridView1.Rows)
        //    {
        //        double amount = Convert.ToDouble(row.Cells["dgvAmount"].Value);
        //        grandTotal += amount;
        //    }
        //    string grandTotalString = grandTotal.ToString("C"); // Format the grand total as currency
        //    lblTotal.Text = grandTotalString; // Update the label with the grand total value
        //    return grandTotalString; // Return the grand total as a string
        //}

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            guna2DataGridView1.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "00";
        }


        private void btnDelivery_Click_1(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Vận chuyển";

            fAddCustomer f = new fAddCustomer();
            f.mainID = MainID;
            f.orderType = OrderType;
            MainClass.BlurBackground(f);


            if (f.txtName.Text != "") // Mua mang đi không có thông tin người giao hàng
            {
                driverID = f.driverID;
                lblDriverName.Text = "Tên khách hàng: " + f.txtName.Text + " - "
                                    + "Số điện thoại: " + f.txtPhone.Text + " - "
                                    + "Người giao hàng: " + f.cbDriver.Text;
                lblDriverName.Visible = true;
                customerName = f.txtName.Text;
                customerPhone = f.txtPhone.Text;

            }
        }

        private void btnTake_Click_1(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Mua mang về";

            fAddCustomer f = new fAddCustomer();
            f.mainID = MainID;
            f.orderType = OrderType;
            MainClass.BlurBackground(f);


            if (f.txtName.Text != "") // Mua mang đi không có thông tin người giao hàng
            {
                driverID = f.driverID;
                lblDriverName.Text = "Tên khách hàng: " + f.txtName.Text + " - "
                                    + "Số điện thoại: " + f.txtPhone.Text;
                lblDriverName.Visible = true;
                customerName = f.txtName.Text;
                customerPhone = f.txtPhone.Text;

            }
        }

        private void btnDin_Click_1(object sender, EventArgs e)
        {
            OrderType = "Ăn tại quán";
            lblDriverName.Visible = false;

            // Tạo form cho chọn bàn và chọn phục vụ
            fTableSelect f = new fTableSelect();
            MainClass.BlurBackground(f);
            if (f.TableName != "")
            {
                lblTable.Text = f.TableName;
                lblTable.Visible = true;
            }
            else
            {
                lblTable.Text = "";
                lblTable.Visible = false;

            }

            fWaiterSelect f2 = new fWaiterSelect();
            MainClass.BlurBackground(f2);
            if (f2.waiterName != "")
            {
                lblWaiter.Text = f2.waiterName;
                lblWaiter.Visible = true;
            }
            else
            {
                lblWaiter.Text = "";
                lblWaiter.Visible = false;

            }
        }

        private void btnKot_Click_1(object sender, EventArgs e)
        {
            // Thêm thông tin filed vào table để lưu trữ thông tin bổ sung

            string query1 = ""; // Main table
            string query2 = ""; // Detail table

            int detailID = 0;

            if (OrderType == "")
            {
                guna2MessageDialog1.Show("Vui lòng chọn loại đơn hàng");
                return;
            }
            else if (guna2DataGridView1.RowCount == 0)
            {
                guna2MessageDialog1.Show("Vui lòng chọn món ăn");
                return;
            }
            else 
            {
                if (MainID == 0) // Insert
                {
                    query1 = @"Insert into tblMain Values(@aDate, @aTime, @TableName, @WaiterName, 
                            @status, @orderType, @total, @received, @change, @driverID, @custName, @custPhone);
                                Select SCOPE_IDENTITY()";
                    // Dòng nhận giá trị id gân đây

                }
                else // Update
                {
                    query1 = @"Update tblMain Set status = @status, total = @total, 
                        received = @received, change = @change where MainID = @ID";

                }

            }



            SqlCommand cmd = new SqlCommand(query1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Chờ");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text)); // Chỉ lưu dât cho giá trị nhà bếp sẽ cập nhật khi thanh toán hóa đơn
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@custName", customerName);
            cmd.Parameters.AddWithValue("@custPhone", customerPhone);


            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }


            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0) // Insert
                {
                    query2 = @"Insert into tblDetails Values(@MainID, @proID, @qty, @price, @amount)";
                }
                else // Update
                {
                    query2 = @"Update tblDetails Set proID = @proID, qty = @qty, price = @price, amount = @amount
                                where DetailID = @ID";

                }

                SqlCommand cmd2 = new SqlCommand(query2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteNonQuery();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }


            }


            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                guna2MessageDialog1.Show("Đặt đơn thành công");
                MainID = 0;
                detailID = 0;
                guna2DataGridView1.Rows.Clear();
                lblTable.Text = "";
                lblWaiter.Text = "";
                lblTable.Visible = false;
                lblWaiter.Visible = false;
                lblTotal.Text = "00";
                lblDriverName.Text = "";
            }



        }


        public int id = 0;
        private void btnBill_Click_1(object sender, EventArgs e)
        {
            fBillList f = new fBillList();
            MainClass.BlurBackground(f);

            if (f.MainID > 0)
            {
                id = f.MainID;
                MainID = f.MainID;
                LoadEntries();
            }
        }


        private void LoadEntries()
        {
            string query = @"Select * from tblMain m
                                    inner join tblDetails d on m.MainID = d.MainID
                                    inner join products p on p.pID = d.proID
                                        where m.MainID = " + id + "";

            SqlCommand cmd2 = new SqlCommand(query, MainClass.con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);


            if (dt2.Rows[0]["orderType"].ToString() == "Vận Chuyển")
            {
                btnDelivery.Checked= true;
                lblWaiter.Visible = false;
                lblTable.Visible= false;
            }
            else if (dt2.Rows[0]["orderType"].ToString() == "Mua mang về")
            {
                btnTake.Checked = true;
                lblWaiter.Visible = false;
                lblTable.Visible = false;
            }
            else
            {
                btnDin.Checked = true;
                lblWaiter.Visible = true;
                lblTable.Visible = true;
               
            }

            guna2DataGridView1.Rows.Clear();

            foreach(DataRow item in dt2.Rows)
            {
                lblTable.Text = item["TableName"].ToString();
                lblWaiter.Text = item["WaiterName"].ToString();


                string detailid = item["DetailID"].ToString();
                string proName = item["pName"].ToString();
                string proid = item["proID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();


                object[] obj = {0, detailid, proid, proName, qty, price, amount };
                guna2DataGridView1.Rows.Add(obj);
            }
            GetTotal();
        }

        private void btnCheckout_Click_1(object sender, EventArgs e)
        {

            if (MainID == id)
            {

                fCheckout f = new fCheckout();
                f.MainID = id;
                f.amt = Convert.ToDouble(lblTotal.Text);
                MainClass.BlurBackground(f);

                MainID = 0;
                guna2DataGridView1.Rows.Clear();
                lblTable.Text = "";
                lblWaiter.Text = "";
                lblTable.Visible = false;
                lblWaiter.Visible = false;
                lblTotal.Text = "00";
            }
            else
            {
                guna2MessageDialog1.Show("Vui lòng chọn loại đơn hàng");
                return;
            }


            btnDelivery.FillColor = Color.Transparent;
            btnDelivery.FillColor2 = Color.Transparent;

            btnTake.FillColor = Color.Transparent;
            btnTake.FillColor2 = Color.Transparent;

            btnDin.FillColor = Color.Transparent;
            btnDin.FillColor2 = Color.Transparent;
        }

        private void btnHold_Click_1(object sender, EventArgs e)
        {
            string query1 = ""; // Main table
            string query2 = ""; // Detail table

            int detailID = 0;

            if (OrderType == "")
            {
                guna2MessageDialog1.Show("Vui lòng chọn loại đơn hàng");
                return;
            }
            else if (guna2DataGridView1.RowCount == 0)
            {
                guna2MessageDialog1.Show("Vui lòng chọn món ăn");
                return;
            }
            if (MainID == 0) // Insert
            {
                query1 = @"Insert into tblMain Values(@aDate, @aTime, @TableName, @WaiterName, 
                            @status, @orderType, @total, @received, @change, @driverID, @custName, @custPhone);
                                Select SCOPE_IDENTITY()";
                // Dòng nhận giá trị id gân đây

            }
            else // Update
            {
                query1 = @"Update tblMain Set status = @status, total = @total, 
                        received = @received, change = @change where MainID = @ID";
            }



            SqlCommand cmd = new SqlCommand(query1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Lưu");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text)); // Chỉ lưu dât cho giá trị nhà bếp sẽ cập nhật khi thanh toán hóa đơn
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@custName", customerName);
            cmd.Parameters.AddWithValue("@custPhone", customerPhone);

            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }


            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0) // Insert
                {
                    query2 = @"Insert into tblDetails Values(@MainID, @proID, @qty, @price, @amount)";
                }
                else // Update
                {
                    query2 = @"Update tblDetails Set proID = @proID, qty = @qty, price = @price, amount = @amount
                                where DetailID = @ID";

                }

                SqlCommand cmd2 = new SqlCommand(query2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteNonQuery();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }


            }
            guna2MessageDialog1.Show("Lưu thành công");
            MainID = 0;
            detailID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "00";
            lblDriverName.Text = "";
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                if (guna2DataGridView1.SelectedRows.Count > 0)
                {
                    int rowIndex = guna2DataGridView1.SelectedRows[0].Index;
                    
                    guna2DataGridView1.Rows.RemoveAt(rowIndex);
                    GetTotal();
                }
            }
        }


        private void btnQrMomo_Click_1(object sender, EventArgs e)
        {
            if (MainID == id)
            {

                fQrMomo f = new fQrMomo();
                f.MainID = id;
                f.amt = Convert.ToDouble(lblTotal.Text);
                MainClass.BlurBackground(f);

                MainID = 0;
                guna2DataGridView1.Rows.Clear();
                lblTable.Text = "";
                lblWaiter.Text = "";
                lblTable.Visible = false;
                lblWaiter.Visible = false;
                lblTotal.Text = "00";
            }
            else
            {
                guna2MessageDialog1.Show("Vui lòng chọn loại đơn hàng");
                return;
            }
        }
    }
}
