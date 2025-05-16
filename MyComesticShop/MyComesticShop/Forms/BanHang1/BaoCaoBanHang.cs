using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyComesticShop.Forms.BanHang1
{
    public partial class BaoCaoBanHang : Form
    {
        public BaoCaoBanHang()
        {
        }

        public BaoCaoBanHang(int saleid)
        {
            InitializeComponent();
            rptBanHang rpt = new rptBanHang();
            rpt.SetParameterValue("@IDNhap", saleid);
            crv.ReportSource = rpt;
        }

        private void BaoCaoBanHang_Load(object sender, EventArgs e)
        {

        }
    }
}
