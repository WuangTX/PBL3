using System.Windows.Forms;

namespace QLQA
{
    public partial class fPrintBill : Form
    {

        public fPrintBill()
        {
            InitializeComponent();
        }


        public void SetReportSource(CrystalDecisions.CrystalReports.Engine.ReportDocument report)
        {
            crystalReportViewerPrintBill.ReportSource = report;
        }
    }
}
