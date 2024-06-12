namespace QLQA
{
    partial class fExportOrder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OrderDatagridview = new System.Windows.Forms.DataGridView();
            this.aDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLQADataSet = new QLQA.QLQADataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.tblMainTableAdapter = new QLQA.QLQADataSetTableAdapters.tblMainTableAdapter();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.daThanhToanToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.daThanhToanToolStrip = new System.Windows.Forms.ToolStrip();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQADataSet)).BeginInit();
            this.daThanhToanToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 74);
            this.panel1.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.BorderRadius = 10;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.FillColor = System.Drawing.Color.SeaGreen;
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = global::QLQA.Properties.Resources.icons8_save_100__1_4;
            this.btnExport.Location = new System.Drawing.Point(40, 17);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(135, 45);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Xuất";
            this.btnExport.TextOffset = new System.Drawing.Point(2, 2);
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 464);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.OrderDatagridview);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(894, 433);
            this.panel4.TabIndex = 2;
            // 
            // OrderDatagridview
            // 
            this.OrderDatagridview.AllowUserToAddRows = false;
            this.OrderDatagridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDatagridview.AutoGenerateColumns = false;
            this.OrderDatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDatagridview.BackgroundColor = System.Drawing.Color.Silver;
            this.OrderDatagridview.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDateDataGridViewTextBoxColumn,
            this.aTimeDataGridViewTextBoxColumn,
            this.orderTypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.OrderDatagridview.DataSource = this.tblMainBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDatagridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderDatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDatagridview.Location = new System.Drawing.Point(0, 0);
            this.OrderDatagridview.Name = "OrderDatagridview";
            this.OrderDatagridview.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDatagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OrderDatagridview.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDatagridview.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.OrderDatagridview.RowTemplate.Height = 24;
            this.OrderDatagridview.Size = new System.Drawing.Size(894, 433);
            this.OrderDatagridview.TabIndex = 0;
            // 
            // aDateDataGridViewTextBoxColumn
            // 
            this.aDateDataGridViewTextBoxColumn.DataPropertyName = "aDate";
            this.aDateDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.aDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDateDataGridViewTextBoxColumn.Name = "aDateDataGridViewTextBoxColumn";
            this.aDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aTimeDataGridViewTextBoxColumn
            // 
            this.aTimeDataGridViewTextBoxColumn.DataPropertyName = "aTime";
            this.aTimeDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.aTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aTimeDataGridViewTextBoxColumn.Name = "aTimeDataGridViewTextBoxColumn";
            this.aTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTypeDataGridViewTextBoxColumn
            // 
            this.orderTypeDataGridViewTextBoxColumn.DataPropertyName = "orderType";
            this.orderTypeDataGridViewTextBoxColumn.HeaderText = "Loại đơn hàng";
            this.orderTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTypeDataGridViewTextBoxColumn.Name = "orderTypeDataGridViewTextBoxColumn";
            this.orderTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblMainBindingSource
            // 
            this.tblMainBindingSource.DataMember = "tblMain";
            this.tblMainBindingSource.DataSource = this.qLQADataSet;
            // 
            // qLQADataSet
            // 
            this.qLQADataSet.DataSetName = "QLQADataSet";
            this.qLQADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(894, 31);
            this.panel3.TabIndex = 1;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "QLQA";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // tblMainTableAdapter
            // 
            this.tblMainTableAdapter.ClearBeforeFill = true;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 326);
            // 
            // daThanhToanToolStripButton
            // 
            this.daThanhToanToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.daThanhToanToolStripButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daThanhToanToolStripButton.Name = "daThanhToanToolStripButton";
            this.daThanhToanToolStripButton.Size = new System.Drawing.Size(115, 24);
            this.daThanhToanToolStripButton.Text = "Đã thanh toán";
            this.daThanhToanToolStripButton.Click += new System.EventHandler(this.daThanhToanToolStripButton_Click);
            // 
            // daThanhToanToolStrip
            // 
            this.daThanhToanToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.daThanhToanToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daThanhToanToolStripButton});
            this.daThanhToanToolStrip.Location = new System.Drawing.Point(0, 0);
            this.daThanhToanToolStrip.Name = "daThanhToanToolStrip";
            this.daThanhToanToolStrip.Size = new System.Drawing.Size(894, 27);
            this.daThanhToanToolStrip.TabIndex = 4;
            this.daThanhToanToolStrip.Text = "Đã thanh toán";
            // 
            // fExportOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 538);
            this.Controls.Add(this.daThanhToanToolStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fExportOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất đơn hàng";
            this.Load += new System.EventHandler(this.fExportOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQADataSet)).EndInit();
            this.daThanhToanToolStrip.ResumeLayout(false);
            this.daThanhToanToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView OrderDatagridview;
        private QLQADataSet qLQADataSet;
        private System.Windows.Forms.BindingSource tblMainBindingSource;
        private QLQADataSetTableAdapters.tblMainTableAdapter tblMainTableAdapter;
        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripButton daThanhToanToolStripButton;
        private System.Windows.Forms.ToolStrip daThanhToanToolStrip;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}