using QLQA.Model;
using QLQA.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        // Để truy cập form Main
        static fMain _obj;
        public static fMain Instance
        {
            get { if (_obj == null) { _obj = new fMain(); } return _obj; } 

        }

        // Phương thức add Controls vào form Main
        public void AddControls(Form f)
        {
            ControlsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlsPanel.Controls.Add(f);
            f.Show();

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = MainClass.USER;
            _obj = this;
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            MainTop.Visible = true;
            AddControls(new fHomeView());
        }

        private void btnCategory_Click_1(object sender, EventArgs e)
        {
            MainTop.Visible = true;
            AddControls(new fCategoryView());

        }

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            MainTop.Visible = true;
            AddControls(new fProductView());

        }

        private void btnTable_Click_1(object sender, EventArgs e)
        {
            MainTop.Visible = true;
            AddControls(new fTableView());
        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {
            MainTop.Visible = true;
            AddControls(new fStaffView());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            MainTop.Visible = true;
            AddControls(new fAccountView());
        }

        private void btnPOS_Click_1(object sender, EventArgs e)
        {
            MainTop.Visible = false;
            AddControls(new fManage());
        }

        private void btnKetchen_Click_1(object sender, EventArgs e)
        {
            MainTop.Visible = true;
            AddControls(new fKitchenView());
        }


        private void btnStatis_Click(object sender, EventArgs e)
        {
            MainTop.Visible = true;
            AddControls(new fStatisView());
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            flogin f = new flogin();
            f.Show();
        }

 
    }
}
