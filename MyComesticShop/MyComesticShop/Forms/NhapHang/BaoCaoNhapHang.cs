using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyComesticShop.Forms.NhapHang
{
    public partial class BaoCaoNhapHang : Form
    {
        public BaoCaoNhapHang(int purchaseid)
        {
            InitializeComponent();
            rptNhapHang rpt = new rptNhapHang();
            rpt.SetParameterValue("@IDNhập", purchaseid);
            crv.ReportSource = rpt;
        }


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void BaoCaoNhapHang_Load(object sender, EventArgs e)
        {

        }
    }
}
