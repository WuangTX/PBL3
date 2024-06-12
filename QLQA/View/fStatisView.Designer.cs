namespace QLQA
{
    partial class fStatisView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDisplayStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnDisplayProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportExel = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportExel);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.dtToDate);
            this.panel1.Controls.Add(this.dtFromDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 79);
            this.panel1.TabIndex = 0;
            // 
            // dtToDate
            // 
            this.dtToDate.BorderRadius = 5;
            this.dtToDate.Checked = true;
            this.dtToDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtToDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(340, 25);
            this.dtToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(150, 36);
            this.dtToDate.TabIndex = 3;
            this.dtToDate.Value = new System.DateTime(2024, 6, 13, 0, 0, 0, 0);
            // 
            // dtFromDate
            // 
            this.dtFromDate.BorderRadius = 5;
            this.dtFromDate.Checked = true;
            this.dtFromDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtFromDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(90, 25);
            this.dtFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(150, 36);
            this.dtFromDate.TabIndex = 2;
            this.dtFromDate.Value = new System.DateTime(2024, 5, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.crystalReportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 483);
            this.panel2.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(949, 483);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btnDisplayStaff);
            this.panel3.Controls.Add(this.btnDisplayProduct);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 495);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 67);
            this.panel3.TabIndex = 2;
            // 
            // btnDisplayStaff
            // 
            this.btnDisplayStaff.BorderRadius = 10;
            this.btnDisplayStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDisplayStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDisplayStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDisplayStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDisplayStaff.FillColor = System.Drawing.Color.SeaGreen;
            this.btnDisplayStaff.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayStaff.ForeColor = System.Drawing.Color.White;
            this.btnDisplayStaff.Image = global::QLQA.Properties.Resources.icons8_staff_1004;
            this.btnDisplayStaff.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDisplayStaff.Location = new System.Drawing.Point(247, 10);
            this.btnDisplayStaff.Name = "btnDisplayStaff";
            this.btnDisplayStaff.Size = new System.Drawing.Size(135, 48);
            this.btnDisplayStaff.TabIndex = 1;
            this.btnDisplayStaff.Text = "Nhân viên";
            this.btnDisplayStaff.TextOffset = new System.Drawing.Point(2, 0);
            this.btnDisplayStaff.Click += new System.EventHandler(this.btnDisplayStaff_Click);
            // 
            // btnDisplayProduct
            // 
            this.btnDisplayProduct.BorderRadius = 10;
            this.btnDisplayProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDisplayProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDisplayProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDisplayProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDisplayProduct.FillColor = System.Drawing.Color.SeaGreen;
            this.btnDisplayProduct.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayProduct.ForeColor = System.Drawing.Color.White;
            this.btnDisplayProduct.Image = global::QLQA.Properties.Resources.icons8_tableware_100__1_1;
            this.btnDisplayProduct.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDisplayProduct.Location = new System.Drawing.Point(68, 10);
            this.btnDisplayProduct.Name = "btnDisplayProduct";
            this.btnDisplayProduct.Size = new System.Drawing.Size(135, 48);
            this.btnDisplayProduct.TabIndex = 0;
            this.btnDisplayProduct.Text = "Món ăn";
            this.btnDisplayProduct.TextOffset = new System.Drawing.Point(2, 0);
            this.btnDisplayProduct.Click += new System.EventHandler(this.btnDisplayProduct_Click);
            // 
            // btnExportExel
            // 
            this.btnExportExel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExel.BorderRadius = 10;
            this.btnExportExel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportExel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportExel.FillColor = System.Drawing.Color.ForestGreen;
            this.btnExportExel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExel.ForeColor = System.Drawing.Color.White;
            this.btnExportExel.Image = global::QLQA.Properties.Resources.excel;
            this.btnExportExel.Location = new System.Drawing.Point(633, 16);
            this.btnExportExel.Name = "btnExportExel";
            this.btnExportExel.Size = new System.Drawing.Size(123, 45);
            this.btnExportExel.TabIndex = 5;
            this.btnExportExel.Text = "Xuất Exel";
            this.btnExportExel.TextOffset = new System.Drawing.Point(2, 0);
            this.btnExportExel.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BorderRadius = 10;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.Peru;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::QLQA.Properties.Resources.icons8_print_100;
            this.btnPrint.Location = new System.Drawing.Point(814, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(123, 45);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "IN";
            this.btnPrint.TextOffset = new System.Drawing.Point(2, 0);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // fStatisView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 562);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fStatisView";
            this.Text = "fPrint";
            this.Load += new System.EventHandler(this.fPrint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtToDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnDisplayProduct;
        private Guna.UI2.WinForms.Guna2Button btnDisplayStaff;
        private Guna.UI2.WinForms.Guna2Button btnExportExel;
    }
}