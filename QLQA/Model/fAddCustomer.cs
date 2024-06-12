using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA.Model
{
    public partial class fAddCustomer : Form
    {
        public fAddCustomer()
        {
            InitializeComponent();
        }

        public string orderType = "";
        public int driverID = 0;
        public string cusName = "";

        public int mainID = 0;

        private void fAddCustomer_Load(object sender, EventArgs e)
        {
            if(orderType == "Mua mang về")
            {
                lblDriver.Visible = false;
                cbDriver.Visible = false;
            }

            string query = "Select staffID 'id', sName 'name' from staff where sRole = N'Giao hàng'";
            MainClass.CBFill(query, cbDriver);

            if(mainID > 0)
            {
                cbDriver.SelectedIndex = driverID;
            }
        }

        private void cbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            driverID = Convert.ToInt32(cbDriver.SelectedValue);
        }

        private void btnApc_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
